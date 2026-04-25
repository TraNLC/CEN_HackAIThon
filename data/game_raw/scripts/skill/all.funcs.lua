
function SkillExpFunc(Exp0,a,Level,Time,Range)
	return math.floor(Exp0*(a^(Level-1))*Time*Range)
end

function Line(x,x1,y1,x2,y2)
	if(x2==x1) then
		return y2
	end
	return (y2-y1)*(x-x1)/(x2-x1)+y1
end

function Conic(x,x1,y1,x2,y2)
	if((x1 < 0) or (x2<0))then 
		return 0
	end
	if(x2==x1) then
		return y2
	end
	return (y2-y1)*x*x/(x2*x2-x1*x1)-(y2-y1)*x1*x1/(x2*x2-x1*x1)+y1
end

function Extrac(x,x1,y1,x2,y2)
	if((x1 < 0) or (x2<0))then 
		return 0
	end
	if(x2==x1) then
		return y2
	end
	return (y2-y1)*(x-x1)/(x2-x1)+y1
end

function Link(x,points)
	num = #points
	if(num<2) then
		return -1
	end
	for i=1,num do
		if(points[i][3]==nil) then
			points[i][3]=Line
		end
	end
	if(x < points[1][1]) then
		return points[1][3](x,points[1][1],points[1][2],points[2][1],points[2][2])
	end
	if(x > points[num][1]) then
		return points[num][3](x,points[num-1][1],points[num-1][2],points[num][1],points[num][2])
	end
	
	c = 2
	for i=2,num do
		if((x >= points[i-1][1]) and (x <= points[i][1])) then
			c = i
			break
		end
	end
	return points[c][3](x,points[c-1][1],points[c-1][2],points[c][1],points[c][2])
end

SKILL = {}
