//constructor for the squid
function Squid() {
    //private data members
    var

        //x position
        x = 0,
        //y position
        y = 0,
        //size
        size = 25,
        //x velocity
        vx = 5,
        //y velocity
        vy = 1.5;




    //public property for VX
    Object.defineProperty(this, 'VX',
        {
            get: function () {
                return vx;
            },
            set: function (value) {
                vx = value;
            }
        }
    )

    //public property for VY
    Object.defineProperty(this, 'VY',
        {
            get: function () {
                return vy;
            },
            set: function (value) {
                vy = value;
            }
        }
    )

    //public property for size
    Object.defineProperty(this, 'Size',
        {
            get: function () {
                return size;
            },
            set: function (value) {
                size = value;
            }
        }
    )

    //public property for X
    Object.defineProperty(this, 'X',
        {
            get: function () {
                return x;
            },
            set: function (value) {
                x = value;
            }
        }
    )

    //public property for Y
    Object.defineProperty(this, 'Y',
        {
            get: function () {
                return y;
            },
            set: function (value) {
                y = value;
            }
        }
    )
    //function to get and set the top of the squid
    Object.defineProperty(this, 'Top',
        {
            get: function () { return y - 10; }
        })
    //function to get and set the bottom of the squid
    Object.defineProperty(this, 'Bottom',
        {
            get: function () { return y + 50; }
        })
    //function to get and set the left side of the squid
    Object.defineProperty(this, 'Left',
        {
            get: function () { return x - 30; }
        })
    //function to get and set the right of the squid
    Object.defineProperty(this, 'Right',
        {
            get: function () { return x + 30; }
        })
    //function public draw method
    Squid.prototype.draw = function (context) {
        //save the context
        context.save();
        //set x and y
        context.translate(x, y);

        //draw it
        context.stroke();
        //draw the triangle
        DrawTriangle(context)
        //draw the other triangle
        DrawTriangle1(context)
        //draw the cirlce
        DrawCircle(context)
        //draw another circle
        DrawCircle1(context);
        //draw the third circle
        DrawCircle2(context);
        //restore the context
        context.restore();

    };

}
//function for the circle
function circle(context, xposn, yposn, colour) {
    context.beginPath();
    context.fillStyle = colour;
    //x, y, radius, start_angle, end_angle, anti-clockwise
    context.arc(xposn, yposn, 32, 0, (Math.PI * 2));
    context.closePath();
    context.fill();
    context.stroke();
}
//function for the cirlce
function circle1(context, xposn, yposn, colour) {
    context.beginPath();
    context.fillStyle = colour;
    //x, y, radius, start angle, end angle, anti-clockwise
    context.arc(xposn, yposn, 15, 0, (Math.PI * 1));
    context.closePath();
    context.fill();
    context.stroke();
}
//fucntion for the circle
function circle2(context, xposn, yposn, colour) {
    context.beginPath();
    context.fillStyle = colour;
    //x, y, radius, start angle, end angle, anti-clockwise
    context.arc(xposn, yposn, 5, 0, (Math.PI * 2));
    context.closePath();
    context.fill();
    context.stroke();
}
//fucntion that will draw the circle
function DrawCircle(context) {
    circle(context, 0, 0, "#B87333");
}
//fucntion that will draw the middle circle
function DrawCircle1(context) {
    circle1(context, 0, 0, "#F5DEB3");
}
//function that will draw the smallest circle
function DrawCircle2(context) {
    circle2(context, 0, 0, "#722F37");
}

//function to draw the triangle
function DrawTriangle(context) {
    Triangle(context, -40, 20, 0, -40, 40, 20, "#8B0000");

}
//function to draw the other triangle
function DrawTriangle1(context) {
    Triangle(context, -40, -20, 0, 40, 40, -20, "#8B0000");

}
//function for the triangle 
function Triangle(context, xpos1, ypos1, xpos2, ypos2, xpos3, ypos3, colour) {
    context.beginPath();
    context.fillStyle = colour;
    context.moveTo(xpos1, ypos1);
    context.lineTo(xpos2, ypos2);
    context.lineTo(xpos3, ypos3);
    context.closePath();
    context.fill();
    context.stroke();
}


