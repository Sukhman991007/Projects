function Rocket() {
	var x = 300, y = 300, vx = 0, vy = 0, RedEngine = 1, boom = false;

	Rocket.prototype.draw = function (context) {
		context.save();
		context.translate(x, y);
		//begin the path
		context.beginPath();
		//colour for the rectangel
		context.fillStyle = "#FFA600";
		//draw the rectangle
		context.moveTo(-40, -10);
		context.lineTo(40, -10);
		context.lineTo(40, 0);
		context.lineTo(-40, 0);
		//close the path
		context.closePath();
		//fill the rectangle
		context.fill();
		context.stroke();
		//draw the main bory of the rocket
		DrawBody(context);
		//draw the engines for the rocket
		DrawEngines(context);
		//draw the cirlces (the eye of the rocket)
		DrawCircles(context);
		
		//if the ship is blown up
		if (boom == true) {
			//create a new instance of the Image
			img = new Image();
			//get the bitmap source
			img.src = "Boom.jfif";
			//draw the image over the content
			context.drawImage(img, -100, -50);
		}
		//restore the share of the rocket
		context.restore();
	}
	//function to draw the body of the rocket
	function DrawBody(context) {
		Triangle(context, 0, -50, 40, 30, -40, 30, "#FF0000");
		
	}
	//function to draw the engines 
	function DrawEngines(context) {
		EngineNo = 1, Colour = "";
		//change colour after a few seconds 
		while (EngineNo < 6 ) {
			//colour for the engines
			if (EngineNo == RedEngine) { Colour = "#FD0000"; }
			else { Colour = "#FDE200"; }
			//coordinates for the 4 engines
			Engine(context, -40, 60, -30, 40, -40, 40, Colour);
			Engine(context, -20, 60, -10, 40, -20, 40, Colour);
			Engine(context, 20, 60, 10, 40, 20, 40, Colour);
			Engine(context, 40, 60, 30, 40, 40, 40, Colour);
			//increase the number of the engine
			EngineNo = EngineNo+ 0.5;
		}
		//variable that will make the engine increase
		RedEngine = RedEngine + 0.5;
		if (RedEngine == 12) { RedEngine = 1; }
	}
	//function to draw the cirlces
	function DrawCircles(context) {
		Circle2(context, 0, 0, "#081CF1");
		Circle(context, 0, 0, "#000000"); 
		Circle1(context, 0, 0, "#ffa600");
		
		
		
	}
	//function to draw the engine
	function Engine(context, xpos1, ypos1, xpos2, ypos2, xpos3, ypos3, colour) {
		context.beginPath();
		context.fillStyle = colour;
		context.moveTo(xpos1, ypos1);
		context.lineTo(xpos2, ypos2);
		context.lineTo(xpos3, ypos3);
		context.closePath();
		context.fill();
		context.stroke();
	}
	//fucntion for the cirles
	function Circle(context, xposn, yposn, colour) {
		context.beginPath();
		context.fillStyle = colour;
		//x, y, radius, start angle, end angle, anti-clockwise
		context.arc(xposn, yposn, 20, 3, (Math.PI * 2));
		context.closePath();
		context.fill();
		context.stroke();
	}
	//function for the second cirlce
	function Circle1(context, xposn, yposn, colour) {
		context.beginPath();
		context.fillStyle = colour;
		//x, y, radius, start angle, end angle, anti-clockwise
		context.arc(xposn, yposn, 7, 0, (Math.PI * 2));
		context.closePath();
		context.fill();
		context.stroke();
	}
	//function for the third circle
	function Circle2(context, xposn, yposn, colour) {
		context.beginPath();
		context.fillStyle = colour;
		//x, y, radius, start angle, end angle, anti-clockwise
		context.arc(xposn, yposn, 30, 0, (Math.PI * 2));
		context.closePath();
		context.fill();
		context.stroke();
	}
	//this will make the rocket transport to the other side when it hits the edge of the canvas 
	Rocket.prototype.move = function () {
		y = y + vy;
		//if x is 0 then x becomes 700
		if (x < 0) { x = 700; }
		else { x = x + vx; }
		//if x is 880 then x becomes 0
		if (x > 700) { x = 0; }
		else { x = x + vx; }
		//if y is 0 then y becomes 700
		if (y < 0) { y = 700; }
		else { y = y + vy; }
		//if y is 800 then y becomes 0
		if (y > 700) { y = 0; }
		else { y = y + vy; }
	}
	//acceleration of the rocket
	Rocket.prototype.accelerate = function (Acceleration) {
		vx += Acceleration.AX;
		vy += Acceleration.AY;
	}
	//stiopping the rocekt in space
	Rocket.prototype.halt = function () {
		//variable to store the vy
		var temp = vy
		vx = 0;
		vy = 0;
		//set the ship as explosing
		if (temp  > .04) {
			boom = true;
        }
	}
	//define the top of the rocket
	Object.defineProperty(this, 'Top',
	{
		get: function () { return y - 60;}
		})
	//define the bottom if the rocket
	Object.defineProperty(this, 'Bottom',
	{
		get: function () { return y + 60; }
		})
	//define the left side of the rocket
	Object.defineProperty(this, 'Left',
	{
		get: function () { return x - 50; }
		})
	//define the right side of the rocket
	Object.defineProperty(this, 'Right',
	{
		get: function () { return x - 50; }
	})
}


