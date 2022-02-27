//constructor for the box
function Square() {
    //private data members
    //x position
    var x = 50,
        //y position
        y = 650,
        //colour
        colour = "red",
        //size
        size = 10,
        width = 10,
        //boolean variable generate random numbers
        pic = Math.random() > 0.7 ? true : false;

    


    //function public draw method
    Square.prototype.draw = function (context) {
        //save the context
        context.save();
        //set x and y
        context.translate(x, y);
        //set the line width
        context.lineWidth = width;
        //set the colour of the fill
        context.fillStyle = colour;
        //begin the path
        context.beginPath();
        //draw the box
        context.moveTo(-size, -size);
        context.lineTo(-size, size);
        context.lineTo(size, size);
        context.lineTo(size, -size);
        //close the path
        context.closePath();
        //fill the shape
        context.fill();
        //draw it
        context.stroke();
            if (pic == true) {
                //create a new instance of the Image
                img = new Image();
                //get the bitmap source
                img.src = "creators_Name.png";
                //draw the image over the content
                context.drawImage(img, -30, -590);
            }
           
        
        //restore the context
        context.restore();
    };
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


    //create a public property called Top
    Object.defineProperty(this, 'Top',
        {
            //getter
            get: function () {
                //return the y position less the height
                return y - 10;
            }
        }
    )

    //create a public property called Bottom
    Object.defineProperty(this, 'Bottom',
        {
            //getter
            get: function () {
                //return the y position plus the height
                return y + 10;
            }
        }
    )

    //create a public property called Left
    Object.defineProperty(this, 'Left',
        {
            //getter
            get: function () {
                //return the x position less the width
                return x - 10;
            }
        }
    )

    //create a public property called Right
    Object.defineProperty(this, 'Right',
        {
            //getter
            get: function () {
                //return the x position plus the width
                return x + 10;
            }
        }
    )
}


