
SKILL["state_giam_toc_do_di_chuyen_phan_tram"] = {
	["sát_thương_vật_lý_nội_trong_khoảng"]={
		[1]={{1,1},{20,1}},
		[3]={{1,10},{20,10}}
	},
	["tốc_độ_di_chuyển_phần_trăm"] = {{{1,-10},{20,-120}},{{1,18*30},{2,18*30}}},
}

SKILL["state_giam_toc_do_danh_phan_tram"] = {
	["sát_thương_vật_lý_nội_trong_khoảng"]={
		[1]={{1,1},{20,1}},
		[3]={{1,10},{20,10}}
	},
	["tốc_độ_đánh_ngoại_phần_trăm"]={{{1,-20},{20,-50}},{{1,18*30},{2,18*30}}},
	["tốc_độ_đánh_nội_phần_trăm"]={{{1,-20},{20,-50}},{{1,18*30},{2,18*30}}},
}

SKILL["state_lam_choang_phan_tram"]={
	-- state.priority != 3
	-- phải có sát thương, nếu không sẽ dính né tránh 100%
	-- dùng để né tránh hiệu ứng của địch
	["sát_thương_vật_lý_nội_trong_khoảng"]={
		[1]={{1,1},{20,1}},
		[3]={{1,10},{20,10}}
	},
	-- state.priority != 3
	-- khi bị dính hiệu ứng chỉ nhận thuộc tính không phải damage
	["làm_choáng_phần_trăm"]={{{1,10},{20,40}},{{1,18*3},{2,18*3}}},
}

SKILL["state_lam_choang_phan_tram_2"]={
	["sát_thương_vật_lý_nội_trong_khoảng"]={
		[1]={{1,1},{20,1}},
		[3]={{1,10},{20,10}}
	},
	["làm_choáng_phần_trăm"]={{{1,1},{10,5},{15,15},{30,30}},{{1,5},{20,10}}},
}

SKILL["state_lam_trong_thuong"]={
	["sát_thương_vật_lý_nội_trong_khoảng"]={
		[1]={{1,200},{20,500}},
		[3]={{1,200},{20,500}}
	},
	["làm_trọng_thương"] = {{{1,90},{20,180}}},
	["thời_gian_phục_hồi"]={{{1,-10},{20,-50}},{{1,18*30},{2,18*30}}},
}

SKILL["state_bang_sat_lam_cham"]={
	["băng_sát_nội_trong_khoảng"]={
		[1]={{1,200},{20,500}},
		[2]={{1,2},{20,14}},			
		[3]={{1,200},{20,500}}
	},
	["thời_gian_làm_chậm_phần_trăm"]={{{1,-20},{10,-80}},{{1,18*30},{2,18*30}}},
}
