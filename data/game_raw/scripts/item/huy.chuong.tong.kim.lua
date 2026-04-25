
local descriptionParam = 
{
	["1-1"]={des="sơ cấp, thắng", pointMin=500, pointMax=1000, itemLock=true, itemExpireSeconds=0, itemParticular=71, itemParam=1, },
	["1-2"]={des="sơ cấp, hòa", pointMin=500, pointMax=1000, itemLock=true, itemExpireSeconds=0, itemParticular=71, itemParam=2, },
	["1-3"]={des="sơ cấp, thua", pointMin=100, pointMax=500, itemLock=true, itemExpireSeconds=0, itemParticular=71, itemParam=3, },
	["2-1"]={des="trung cấp, thắng", pointMin=500, pointMax=1500, itemLock=true, itemExpireSeconds=0, itemParticular=71, itemParam=4, },
	["2-2"]={des="trung cấp, hòa", pointMin=500, pointMax=1000, itemLock=true, itemExpireSeconds=0, itemParticular=71, itemParam=5, },
	["2-3"]={des="trung cấp, thua", pointMin=100, pointMax=1000, itemLock=true, itemExpireSeconds=0, itemParticular=71, itemParam=6, },
	["3-1"]={des="cao cấp, thắng", pointMin=500, pointMax=2000, itemLock=true, itemExpireSeconds=0, itemParticular=71, itemParam=7, },
	["3-2"]={des="cao cấp, hòa", pointMin=500, pointMax=1000, itemLock=true, itemExpireSeconds=0, itemParticular=71, itemParam=8, },
	["3-3"]={des="cao cấp, thua", pointMin=100, pointMax=1500, itemLock=true, itemExpireSeconds=0, itemParticular=71, itemParam=9, },
}

function GetDesc(scriptParamLongValue)
	local desField = nil
	
	for key,value in pairs(descriptionParam) do
		if value.itemParam == scriptParamLongValue then
			desField = value
			break
		end
	end
	
	if desField == nil then
		return "\nHuy chương này có vẻ không phải được cấp từ quân binh!"
	end

	return "\nHuy chương vinh danh các anh hùng dân tộc có đóng góp với quê hương, tổ quốc. "
		.."Tùy vào kết quả và bản đồ của trận Tống Kim(<color=#ffff00>"..desField.des.."</color>) đã nhận huy chương này mà "
		.."sử dụng có thể nhận được ngẫu nhiên(<color=#ffff00>"..desField.pointMin.." đến "..desField.pointMax.."</color>) điểm tích lũy Tống Kim tương ứng."
end
