function Enemy() {
	var x = 0, y = 0, vx = 3.5, vy = 0.5, size = 20, GlobeYellow = 1;



	Enemy.prototype.draw = function (context) {
		context.save();
		context.translate(x, y);
		//draw the circle
		DrawCircle(context)
		context.beginPath();
		//colour for the rectangle
		context.fillStyle = "#FFA600";
		//draw the rectangle
		context.moveTo(-120, 0);
		context.lineTo(120, 0);
		context.lineTo(120, 50);
		context.lineTo(-120, 50);
		//close the path
		context.closePath();
		//fill the shape
		context.fill();
		context.stroke();
		//draw the triangle
		DrawTriangle(context);
		//eyes of the enemy		
		DrawEyes(context);
		//draw the mini triangles
		DrawMiniTriangles(context);
		//draw the globe(engine)
		DrawGlobes(context)
		//restore the enemy shape
		context.restore();
	}

	//function to draw the trianlge
	function DrawTriangle(context) {
		Triangle(context, 0, -80, 40, 0, -40, 0, "#FF0000");

	}
	//function to draw the trianlge
	function DrawMiniTriangles(context) {
		Triangle(context, 120, 0, 90, 0, 120, -40, "#FF0000");
		Triangle(context, -120, 0, -90, 0, -120, -40, "#FF0000")

	}
	
	//function that will draw will display the circles
	function DrawEyes(context) {
		Eye(context, -30, 0, 30, "#ffffff");
		Eye(context, -20, 0, 4, "#000000");
		Eye(context, 30, 0, 30, "#ffffff");
		Eye(context, 20, 0, 4, "#000000");
	}
	//function to create the eye		    
	function Eye(context, xposn, yposn, radius, colour) {
		context.beginPath();
		context.fillStyle = colour;
		//x, y, radius, star tangle, end angle, anti-clockwise
		context.arc(xposn, yposn, radius, 0, (Math.PI * 2));
		//clos the path 
		context.closePath();
		context.fill();
		context.stroke();
	}
	//function to draw the cirlce
	function DrawCircle(context) {
		Circle(context, 0, 0, "#081CF1");
		



	}
	//function for the cirle
	function Circle(context, colour) {
		context.beginPath();
		context.fillStyle = colour;
		//x, y, radius, start angle, end angle, anti-clockwise
		context.arc(0, 0, 80, 0, (Math.PI * 1));
		context.closePath();
		context.fill();
		context.stroke();
	}
	//function for the globe
	function Globe(context, xposn, yposn, colour) {
		//begin the path
		context.beginPath();
		//set the fill colour
		context.fillStyle = colour;
		//move to the position to start the globe
		context.moveTo(xposn, yposn);
		//draw the curve from that position to +30px passing toward x+13, y+20
		context.quadraticCurveTo(xposn + 52, yposn + 80, xposn + 120, yposn); 
		//fill the globe
		context.fill();
		//draw the globe
		context.stroke();
	}
	//function to draw the globe
	function DrawGlobes(context) {
		//var to store the colour of the globe
		var colour = "";
		//if the value of GlobeYellow is less than 50
		if (GlobeYellow < 50) {
			//set the colour to yellow
			colour = "#ffff00";
		}
		else {
			//otherwise set it to red
			colour = "#ff0000";
		}
		//globe
		Globe(context, -60, 50, colour);
		//increase the value of globe yellow 
		GlobeYellow += 1;
		//if globe yellow is more than 100 
		if (GlobeYellow > 100) {
			//set it back to 1
			GlobeYellow = 1;
		}
	}

	//function to get and set VX
	Object.defineProperty(this, 'VX',
    {   get: function () {return vx;},
        set: function (value) {vx = value;}
    })
	//function to get and set VY
    Object.defineProperty(this, 'VY',
    {   get: function () {return vy;},
        set: function (value) {vy = value;}
    })
	//function to get and set size
    Object.defineProperty(this, 'Size',
    {   get: function () {return size;},
        set: function (value) {size = value;}
    })
	//function to get and set x
    Object.defineProperty(this, 'X',
    {   get: function () {return x;},
        set: function (value) {x = value;}
    })
	//function to get and set y
    Object.defineProperty(this, 'Y',
    {   get: function () {return y;},
        set: function (value) {y = value;}
    })
	//function to get and set the top of the enemy
	Object.defineProperty(this, 'Top',
	{ 	get: function (){return y - 60;}
	})
	//function to get and set the bottom of the enemy
	 Object.defineProperty(this, 'Bottom',
	{	get: function () {return y + 60;}		
	})
	//function to get and set the left side of the enemy
	Object.defineProperty(this, 'Left',
	{ 	get: function () {return x - 120;}
	})
	//function to get and set right of the enemy
	Object.defineProperty(this, 'Right',
	{	get: function () {return x + 120;}
	})	
		
		
}


