
ItemParamFunctionMapping = 
{
	[1] = function(itemparam) return DesTongKim(itemparam) end,
	[2] = function(itemparam) return DesTongKim(itemparam) end,
	[3] = function(itemparam) return DesTongKim(itemparam) end,
	[4] = function(itemparam) return DesTongKim(itemparam) end,
	[5] = function(itemparam) return DesTongKim(itemparam) end,
	[6] = function(itemparam) return DesTongKim(itemparam) end,
	[7] = function(itemparam) return DesTongKim(itemparam) end,
	[8] = function(itemparam) return DesTongKim(itemparam) end,
	[9] = function(itemparam) return DesTongKim(itemparam) end,
	[10] = function(itemparam) return DesBossHoangKim(itemparam) end,
	[11] = function(itemparam) return DesBossTieuHoangKimPlayerAround(itemparam) end,
	[12] = function(itemparam) return DesBossTieuHoangKimKiller(itemparam) end,
	[13] = function(itemparam) return TongKimDatMocTichLuy1(itemparam) end,
	[14] = function(itemparam) return TongKimDatMocTichLuy2(itemparam) end,
	[15] = function(itemparam) return EventNhatThongGiangSon(itemparam) end,
	[16] = function(itemparam) return EventNhatThongGiangSon(itemparam) end,
	[17] = function(itemparam) return EventNhatThongGiangSon(itemparam) end,
}

function GetDesc(itemparam)
	local itemFunction = ItemParamFunctionMapping[itemparam]
	
	if itemFunction ~= nil then
		return itemFunction(itemparam)
	end
	
	return "\nsử dụng sẽ hấp thụ lượng kinh nghiệm tương ứng"
end

function EventNhatThongGiangSon(itemparam)
	local expParamMapping = 
	{
		[15] = {fixedExp=100000000, name="100 triệu"},
		[16] = {fixedExp=200000000, name="200 triệu"},
		[17] = {fixedExp=300000000, name="300 triệu"},
	}
	
	return "\n\n"..expParamMapping[itemparam].name.." điểm kinh nghiệm, nhận được từ sự kiện Nhất Thống Giang Sơn"
end

function TongKimDatMocTichLuy1(itemparam)
	return "\n\nTặng phẩm dành cho các tráng sĩ đạt <color=#ffff00>5.000</color> điểm tích lũy trong một trận Tống Kim(trung cấp). "
		.."Sử dụng sẽ nhận được <color=#ffff00>5.000.000</color> điểm kinh nghiệm cộng dồn"
end

function TongKimDatMocTichLuy2(itemparam)
	return "\n\nTặng phẩm dành cho các tráng sĩ đạt <color=#ffff00>10.000</color> điểm tích lũy trong một trận Tống Kim(trung cấp). "
		.."Sử dụng sẽ nhận được <color=#ffff00>5.000.000</color> điểm kinh nghiệm cộng dồn"
end

function DesBossTieuHoangKimKiller(itemparam)
	return "\n\nTặng phẩm dành cho cao thủ ra tay kết liễu boss Tiểu Hoàng Kim. "
		.."Sử dụng sẽ nhận được ngay <color=#ffff00>3.000.000</color> điểm kinh nghiệm."
end

function DesBossTieuHoangKimPlayerAround(itemparam)
	return "\n\nTặng phẩm dành cho các hiệp khách tham gia đánh bại boss Tiểu Hoàng Kim. "
		.."Sử dụng sẽ nhận được ngay <color=#ffff00>3.000.000</color> điểm kinh nghiệm."
end

local descriptionBossHoangKim = 
{
	{level=0, expMin=5000000, expMax=5000000},
	{level=20, expMin=5000000, expMax=5000000},
	{level=40, expMin=5000000, expMax=5000000},
	{level=60, expMin=5000000, expMax=5000000},
	{level=80, expMin=5000000, expMax=5000000},
	{level=100, expMin=5000000, expMax=5000000},
	{level=120, expMin=5000000, expMax=5000000},
}

function DesBossHoangKim(itemparam)
	local content = "\n\nTặng phẩm dành cho các hiệp khách tham gia hạ gục Boss Hoàng Kim. "
		.."Sau khi sử dụng, tùy vào cấp độ hiện tại mà sẽ ngẫu nhiên nhận được một số mốc kinh nghiệm tương ứng.\n"
	
	for index = 1,#descriptionBossHoangKim do
		content = content.."\nTừ <color=#ffff00>cấp "..descriptionBossHoangKim[index].level
			.."</color> exp <color=#00ff00>"..descriptionBossHoangKim[index].expMin.."</color> đến <color=#00ff00>"
			..descriptionBossHoangKim[index].expMax.."</color>"
	end
	
	return content
end

local descriptionTongKimParam = 
{
		["1-1"]={des="sơ cấp, thắng", expMin=2000000, expMax=3000000, itemLock=true, itemExpireSeconds=60*60*24, itemParticular=70, itemParam=1, },
		["1-2"]={des="sơ cấp, hòa", expMin=100000, expMax=500000, itemLock=true, itemExpireSeconds=60*60*24, itemParticular=70, itemParam=2, },
		["1-3"]={des="sơ cấp, thua", expMin=1500000, expMax=2500000, itemLock=true, itemExpireSeconds=60*60*24, itemParticular=70, itemParam=3, },
		["2-1"]={des="trung cấp, thắng", expMin=2000000, expMax=3000000, itemLock=true, itemExpireSeconds=60*60*24, itemParticular=70, itemParam=4, },
		["2-2"]={des="trung cấp, hòa", expMin=100000, expMax=500000, itemLock=true, itemExpireSeconds=60*60*24, itemParticular=70, itemParam=5, },
		["2-3"]={des="trung cấp, thua", expMin=1500000, expMax=2500000, itemLock=true, itemExpireSeconds=60*60*24, itemParticular=70, itemParam=6, },
		["3-1"]={des="cao cấp, thắng", expMin=2000000, expMax=5000000, itemLock=true, itemExpireSeconds=60*60*24, itemParticular=70, itemParam=7, },
		["3-2"]={des="cao cấp, hòa", expMin=100000, expMax=1000000, itemLock=true, itemExpireSeconds=60*60*24, itemParticular=70, itemParam=8, },
		["3-3"]={des="cao cấp, thua", expMin=1500000, expMax=2500000, itemLock=true, itemExpireSeconds=60*60*24, itemParticular=70, itemParam=9, },
}

function DesTongKim(itemparam)
	local desField = nil
	
	for key,value in pairs(descriptionTongKimParam) do
		if value.itemParam == itemparam then
			desField = value
			break
		end
	end
	
	if desField == nil then
		return "\nTặng phẩm này có vẻ không phải được cấp từ quân binh!"
	end

	return "\nTặng phẩm tri ân các anh hùng dân tộc có đóng góp với quê hương, tổ quốc. "
		.."Tùy vào kết quả và bản đồ của trận Tống Kim(<color=#ffff00>"..desField.des.."</color>) đã nhận tặng phẩm này mà "
		.."sử dụng có thể nhận được ngẫu nhiên(<color=#ffff00>"..desField.expMin.." đến "..desField.expMax.."</color>) điểm kinh nghiệm tương ứng."
end

