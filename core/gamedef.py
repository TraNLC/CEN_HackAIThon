"""
gamedef.py
Mapped from VLAuto src_VLauto_goc/GameDef.h and VLYeSou.cpp
Provides Enums and constants for VLTK1 Android auto.
"""

# ==========================================
# 1. TASK CODES (Nhiệm vụ & Trạng thái)
# Lấy từ enum TASK_CODES
# ==========================================
TASK_CODES = {
    'ys_taskgid': 1020,     # Group ID nhiệm vụ Dã Tẩu
    'ys_majorid': 1021,     # Loại nhiệm vụ chính (Mua đồ, tìm đồ, tọa độ...)
    'ys_maphave': 1025,
    'ys_repvalue': 1026,    # Chỉ số Phúc Duyên & Danh Vọng
    'ys_shxtmap': 1027,     # Số lượng bản đồ SHXT
    'ys_taskstatus': 1028,  # Trạng thái nhiệm vụ
    'ys_task405': 1029,
    'ys_minorid': 1030,     # Chi tiết nhiệm vụ (Ví dụ: Mua kiếm hay mua đao)
    'ys_mapid': 1031,       # ID Map yêu cầu đến
    'ys_smapreq': 1032,
    'ys_prelevel': 1033,
    'ys_preexp': 1034,
    'ys_tasknum': 1044,     # Tổng số nhiệm vụ đã làm
    'ys_taskccl': 1046,     # Số cơ hội Hủy nhiệm vụ (Cancel)
}

# Trạng thái nhiệm vụ Dã Tẩu (ys_taskstatus)
YS_TASK_STATUS = {
    1: 'Đang làm nhiệm vụ',
    2: 'Đã hoàn thành - Chờ nhận thưởng',
    3: 'Chưa nhận nhiệm vụ',
}

# Loại nhiệm vụ Dã Tẩu chính (ys_majorid) - Lấy từ VLYeSou.cpp -> DoCurrentQuest()
YS_MAJOR_TYPES = {
    1: 'Mua vật phẩm từ NPC (Tạp hóa/Thợ rèn)',
    2: 'Tìm vật phẩm (Không yêu cầu trả lại)',
    3: 'Tìm vật phẩm (Có yêu cầu trả lại)',
    4: 'Đi đến tọa độ / Bản đồ đặc biệt',
    5: 'Tăng chỉ số (Phúc Duyên/Danh Vọng)',
    6: 'Tìm Mảnh Sơn Hà Xã Tắc',
}

# ==========================================
# 2. ITEM MAPS (Vật phẩm)
# ==========================================
# enum ITEMGENRE
ITEM_GENRE = {
    0: 'item_equip',        # Trang bị
    1: 'item_medicine',     # Thuốc
    2: 'item_mine',         # Khoáng thạch
    3: 'item_materials',    # Nguyên liệu
    4: 'item_task',         # Đồ nhiệm vụ
    5: 'item_townportal',   # Thổ địa phù
    6: 'item_special',      # Vật phẩm đặc biệt
}

# enum ITEM_PART (Phân loại trang bị)
ITEM_PART = {
    0: 'Nón (Head)',
    1: 'Áo (Body)',
    2: 'Thắt lưng (Belt)',
    3: 'Vũ khí (Weapon)',
    4: 'Giày (Foot)',
    5: 'Bao tay (Cuff)',
    6: 'Dây chuyền (Amulet)',
    7: 'Nhẫn dưới (Ring 1)',
    8: 'Nhẫn trên (Ring 2)',
    9: 'Ngọc bội (Pendant)',
    10: 'Ngựa (Horse)',
    11: 'Mặt nạ (Mask)',
}

# ==========================================
# 3. MAP IDs
# ==========================================
CITY_MAP_ID = {
    1: 'Phượng Tường',
    78: 'Tương Dương',
    37: 'Biện Kinh',
    11: 'Thành Đô',
    162: 'Đại Lý',
    80: 'Dương Châu',
    176: 'Lâm An',
    # Các thôn làng
    121: 'Long Môn Trấn',
    93: 'Ba Lăng Huyện',
    100: 'Chu Tiên Trấn',
}

def get_ys_status_name(status_id):
    return YS_TASK_STATUS.get(status_id, f"Unknown ({status_id})")

def get_ys_major_type(major_id):
    return YS_MAJOR_TYPES.get(major_id, f"Unknown ({major_id})")
