
function Main(id, level)
	if not(SKILL[id]) then
		return nil
	end
	
	local data = SKILL[id]
	local valuetype = nil
	local result = ""
	
	for key, value in pairs(data) do
		valuetype = type(value)
		
		if valuetype == "table" then
			if not value[1] then
				SKILL[id][key][1] = {{0,0},{20,0}}
			end
			if not value[2] then
				SKILL[id][key][2] = {{0,0},{20,0}}
			end
			if not value[3] then
				SKILL[id][key][3] = {{0,0},{20,0}}
			end
			
			local p1=math.floor(Link(level,SKILL[id][key][1]))
			local p2=math.floor(Link(level,SKILL[id][key][2]))
			local p3=math.floor(Link(level,SKILL[id][key][3]))
			
			result = result.."|"..key.."="..p1..","..p3..","..p2
		
		elseif valuetype == "string" then
			
		elseif valuetype == "function" then
			result = result.."|"..key.."="..SKILL[id][key](level)
		end
	end
	
	return result;
end
