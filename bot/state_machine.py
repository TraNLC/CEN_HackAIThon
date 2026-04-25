"""
state_machine.py — Logic nhiệm vụ Dã Tẩu

State machine event-driven: nhận S2C packets → quyết định action → gửi C2S packets.
Không poll, không sleep dài — phản ứng theo events từ server.

QUAN TRỌNG: Các opcode S2C và NPC/quest ID cần điền sau khi RE.
"""

import logging
import time
from enum import Enum, auto
from typing import Optional

from packet_builder import PacketBuilder
from vltk_client import VLTKClient, Packet


logger = logging.getLogger(__name__)


# ============================================================
# S2C opcodes — THAY BẰNG GIÁ TRỊ THẬT SAU KHI RE
# ============================================================
class S2C:
    LOGIN_OK        = 0xFFFF  # TODO
    LOGIN_FAIL      = 0xFFFF  # TODO
    CHAR_LIST       = 0xFFFF  # TODO: server gửi danh sách nhân vật
    ENTER_WORLD_OK  = 0xFFFF  # TODO: vào game thành công
    NPC_DIALOG_OPEN = 0xFFFF  # TODO: dialog NPC mở
    QUEST_ACCEPT_OK = 0xFFFF  # TODO: nhận NV thành công
    QUEST_PROGRESS  = 0xFFFF  # TODO: cập nhật tiến độ NV
    QUEST_DONE      = 0xFFFF  # TODO: NV hoàn thành
    QUEST_SUBMIT_OK = 0xFFFF  # TODO: nộp NV thành công
    MOB_SPAWN       = 0xFFFF  # TODO: mob xuất hiện
    MOB_DEAD        = 0xFFFF  # TODO: mob chết
    MOVE_OK         = 0xFFFF  # TODO: di chuyển thành công
    ERROR_MSG       = 0xFFFF  # TODO: server báo lỗi


# ============================================================
# Quest và NPC IDs — THAY SAU KHI RE
# ============================================================
class Config:
    DA_TAU_NPC_ID   = 0       # TODO: NPC ID nhận/nộp dã tẩu
    DA_TAU_QUEST_ID = 0       # TODO: Quest ID của dã tẩu
    CHAR_INDEX      = 0       # Chọn nhân vật đầu tiên
    # Vị trí NPC trên map (x, y) — từ minimap hoặc RE map data
    NPC_COORDS      = (0, 0)  # TODO
    # Vùng spawn mob dã tẩu
    MOB_AREA_COORDS = (0, 0)  # TODO


class State(Enum):
    INIT        = auto()
    LOGGING_IN  = auto()
    SELECTING_CHAR = auto()
    IN_WORLD    = auto()
    GOING_TO_NPC = auto()
    ACCEPTING_QUEST = auto()
    GOING_TO_MOB = auto()
    FIGHTING    = auto()
    QUEST_DONE_WAIT = auto()
    SUBMITTING_QUEST = auto()
    DONE        = auto()  # 1 vòng hoàn thành
    ERROR       = auto()


class DaTauStateMachine:
    """
    Chạy 1 vòng nhiệm vụ dã tẩu cho 1 account.
    Gọi run_loop() để chạy nhiều vòng liên tiếp.
    """

    def __init__(self, client: VLTKClient, account: dict):
        self.client = client
        self.account = account
        self.state = State.INIT
        self.quest_progress = 0
        self.quest_target = 0
        self.current_mob_id = 0
        self._state_enter_time = time.time()
        self._loop_count = 0

        # Đăng ký S2C packet handlers
        self._register_handlers()

    def _register_handlers(self):
        c = self.client
        c.on(S2C.LOGIN_OK,        self._on_login_ok)
        c.on(S2C.LOGIN_FAIL,      self._on_login_fail)
        c.on(S2C.CHAR_LIST,       self._on_char_list)
        c.on(S2C.ENTER_WORLD_OK,  self._on_enter_world)
        c.on(S2C.NPC_DIALOG_OPEN, self._on_npc_dialog)
        c.on(S2C.QUEST_ACCEPT_OK, self._on_quest_accept)
        c.on(S2C.QUEST_PROGRESS,  self._on_quest_progress)
        c.on(S2C.QUEST_DONE,      self._on_quest_done)
        c.on(S2C.QUEST_SUBMIT_OK, self._on_quest_submit)
        c.on(S2C.MOB_SPAWN,       self._on_mob_spawn)
        c.on(S2C.MOB_DEAD,        self._on_mob_dead)
        c.on(S2C.ERROR_MSG,       self._on_error)

    # ----------------------------------------------------------
    # Main loop
    # ----------------------------------------------------------

    def run_loop(self, max_loops: int = 0):
        """
        Chạy dã tẩu liên tục.
        max_loops=0 → chạy vô hạn đến khi bị ngắt.
        """
        self._start_login()
        while self.client.is_connected():
            if self.state == State.ERROR:
                logger.error(f"[{self.account['username']}] State ERROR — stopping")
                break
            if self.state == State.DONE:
                self._loop_count += 1
                logger.info(f"[{self.account['username']}] Loop {self._loop_count} done")
                if max_loops and self._loop_count >= max_loops:
                    break
                # Bắt đầu vòng mới
                self._goto_state(State.GOING_TO_NPC)
                self._go_to_npc()
            # Watchdog: nếu stuck quá 60s trong 1 state → reset
            if time.time() - self._state_enter_time > 60:
                logger.warning(f"[{self.account['username']}] Stuck in {self.state} 60s → reset")
                self._goto_state(State.GOING_TO_NPC)
                self._go_to_npc()
            time.sleep(0.2)

    def _goto_state(self, state: State):
        logger.info(f"[{self.account['username']}] {self.state.name} → {state.name}")
        self.state = state
        self._state_enter_time = time.time()

    # ----------------------------------------------------------
    # Actions
    # ----------------------------------------------------------

    def _start_login(self):
        self._goto_state(State.LOGGING_IN)
        self.client.send(PacketBuilder.login(
            self.account['username'],
            self.account['password']
        ))

    def _go_to_npc(self):
        x, y = Config.NPC_COORDS
        if x and y:
            self.client.send(PacketBuilder.move_to(x, y))
        self._goto_state(State.GOING_TO_NPC)

    def _talk_to_npc(self):
        self._goto_state(State.ACCEPTING_QUEST)
        self.client.send(PacketBuilder.talk_to_npc(Config.DA_TAU_NPC_ID))

    def _accept_quest(self):
        self.client.send(PacketBuilder.accept_quest(Config.DA_TAU_QUEST_ID))

    def _go_to_mob_area(self):
        self._goto_state(State.GOING_TO_MOB)
        x, y = Config.MOB_AREA_COORDS
        if x and y:
            self.client.send(PacketBuilder.move_to(x, y))

    def _attack_mob(self, mob_id: int):
        self._goto_state(State.FIGHTING)
        self.current_mob_id = mob_id
        self.client.send(PacketBuilder.attack(mob_id))

    def _submit_quest(self):
        self._goto_state(State.SUBMITTING_QUEST)
        self._go_to_npc()
        # Sau khi đến NPC, _on_npc_dialog sẽ tự nộp NV

    # ----------------------------------------------------------
    # S2C handlers
    # ----------------------------------------------------------

    def _on_login_ok(self, pkt: Packet):
        if self.state != State.LOGGING_IN:
            return
        logger.info(f"[{self.account['username']}] Login OK")
        self._goto_state(State.SELECTING_CHAR)
        # Chọn nhân vật đầu tiên — server thường gửi CHAR_LIST trước
        # Nếu không có CHAR_LIST thì gửi select_char thẳng:
        # self.client.send(PacketBuilder.select_char(Config.CHAR_INDEX))

    def _on_login_fail(self, pkt: Packet):
        logger.error(f"[{self.account['username']}] Login FAILED")
        self._goto_state(State.ERROR)

    def _on_char_list(self, pkt: Packet):
        if self.state != State.SELECTING_CHAR:
            return
        # Parse char_id từ payload — cần RE để biết format
        # Tạm thời dùng char index 0
        # char_id = struct.unpack_from('>I', pkt.payload, 0)[0]
        self.client.send(PacketBuilder.select_char(Config.CHAR_INDEX))

    def _on_enter_world(self, pkt: Packet):
        logger.info(f"[{self.account['username']}] Entered world")
        self._goto_state(State.IN_WORLD)
        self._go_to_npc()

    def _on_npc_dialog(self, pkt: Packet):
        if self.state == State.GOING_TO_NPC:
            # Đến NPC để nhận NV
            self._accept_quest()
        elif self.state == State.SUBMITTING_QUEST:
            # Đến NPC để nộp NV
            self.client.send(PacketBuilder.submit_quest(Config.DA_TAU_QUEST_ID))

    def _on_quest_accept(self, pkt: Packet):
        logger.info(f"[{self.account['username']}] Quest accepted")
        self._goto_state(State.GOING_TO_MOB)
        self._go_to_mob_area()

    def _on_quest_progress(self, pkt: Packet):
        # Parse progress từ payload — cần RE
        # Ví dụ: progress = struct.unpack_from('>H', pkt.payload, 0)[0]
        # target  = struct.unpack_from('>H', pkt.payload, 2)[0]
        logger.debug(f"[{self.account['username']}] Quest progress update")

    def _on_quest_done(self, pkt: Packet):
        logger.info(f"[{self.account['username']}] Quest complete — returning to NPC")
        self._submit_quest()

    def _on_quest_submit(self, pkt: Packet):
        logger.info(f"[{self.account['username']}] Quest submitted — reward collected")
        self._goto_state(State.DONE)

    def _on_mob_spawn(self, pkt: Packet):
        if self.state not in (State.GOING_TO_MOB, State.FIGHTING):
            return
        # Parse mob_id từ payload — cần RE
        # mob_id = struct.unpack_from('>I', pkt.payload, 0)[0]
        # self._attack_mob(mob_id)
        logger.debug(f"[{self.account['username']}] Mob spawned")

    def _on_mob_dead(self, pkt: Packet):
        if self.state != State.FIGHTING:
            return
        logger.debug(f"[{self.account['username']}] Mob dead — looking for next")
        self._goto_state(State.GOING_TO_MOB)
        # Server sẽ gửi tiếp QUEST_PROGRESS hoặc QUEST_DONE

    def _on_error(self, pkt: Packet):
        logger.warning(f"[{self.account['username']}] Server error packet received")
