
function GetDesc(scriptParamLongValue)
	if scriptParamLongValue == 0 then
		scriptParamLongValue = 101
	end

	return "Còn có thể sử dụng <color=#00ff00>"..(scriptParamLongValue-1).."</color> lần nữa"
end
