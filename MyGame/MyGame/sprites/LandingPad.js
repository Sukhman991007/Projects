//create the constructor for the class pad
function Pad() {
    //initialisation code will go here

    //create private variables for the x and y coordinates
    var x = 200,
        y = 200,
        GlobeColour = 1;

    //create the draw function to give us the draw method
    //it accepts one parameter which is the context from the canvas it is drawn on
    Pad.prototype.draw = function (context) {
        //save the state of the drawing context before we change it
        context.save();
        //set the coordinates of the drawing area of the new shape to x and y
        context.translate(x, y);
        //start the line (path)
        context.beginPath();
        context.fillStyle = "#858585";
        context.moveTo(-80, -10);
        context.lineTo(80, -10);
        context.lineTo(80, 10);
        context.lineTo(-80, 10);         
        //close the path
        context.closePath();
        context.fill();
        //go ahead and draw the line
        context.stroke();
        //draw the globes
        DrawGlobes(context);
        //restore the state of the context to what it was before our drawing
        context.restore();
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
        context.quadraticCurveTo(xposn -52, yposn + 20, xposn - 120, yposn);
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
        if (GlobeColour < 50) {
            //set the colour to yellow
            colour = "#FF0000";
        }
        else {
            //otherwise set it to red
            colour = "#032BD9";
        }
        //globe
        Globe(context, 60, -5, colour);
        //increase the value of globe yellow (The larger the increment the faster the flashing effect)
        GlobeColour += .2;
        //if globe yellow is more than 100 
        if (GlobeColour > 100) {
            //set it back to 1
            GlobeYellow = 1;
        }
    }
    



    //create a public property called X 
    Object.defineProperty(this, 'X',
        {
            //getter
            get: function () {
                //return the value of x 
                return x;
            },
            //setter
            set: function (value) {
                //ste the value of x 
                x = value;
            }
        }
    )

    //create a public property called Y 
    Object.defineProperty(this, 'Y',
        {
            //getter
            get: function () {
                //return the value of y 
                return y;
            },
            //setter
            set: function (value) {
                //ste the value of y 
                y = value;
            }
        }
    )

    //public property called Top
    Object.defineProperty(this, 'Top',
        {
            //getter
            get: function () {
                //return the y posn less the height
                return y - 10;
            }
        }
    )

    //public property called Bottom
    Object.defineProperty(this, 'Bottom',
        {
            //getter
            get: function () {
                //return the y position plus the height
                return y + 10;
            }
        }
    )

    //public property called Left
    Object.defineProperty(this, 'Left',
        {
            //getter
            get: function () {
                //return the x positionn less the width
                return x - 80;
            }
        }
    )

    //public property called Right
    Object.defineProperty(this, 'Right',
        {
            //getter
            get: function () {
                //return the x position plus the width
                return x + 80;
            }
        }
    )

}