function Star() {
    //initialisation code will go here

    //create private variables for the x and y coordinates
    this.x = Math.random() * 700;
    this.y = Math.random() * 700;
    //set the size of the star
    var size = 3,
        starColour = Math.random()* 10 ;

    Star.prototype.draw = function (context) {
        //save the state of the drawing context before we change it
        context.save();
        if (starColour > 6) {
            context.fillStyle = "#FFFFFF";
        }
        if (starColour > 3 && starColour< 6) {
            context.fillStyle = "#FF0000";
        }
        if (starColour < 3) {
            context.fillStyle = "#000AFF";
        }
        //set the coordinates of the drawing area of the new shape to x and y
        context.translate(this.x, this.y);
        //start the line (path)
        context.beginPath();
        context.moveTo(-size, size);
        context.lineTo(size, size);
        context.lineTo(size, -size);
        context.lineTo(size, -size);
        context.lineTo(-size, -size);
        //context.lineTo(0, 0);
        //close the path
        context.closePath();
        context.fill();
        //go ahead and draw the line
        context.stroke();
        //restore the state of the context to what it was before our drawing
        context.restore();
    }

    Star.prototype.move = function () {
        //change the x axis
        this.x -= .1;
        //if the star has drifted off the left of the canvas
        if (this.x < 0) {
            //place it at the right of the canvas
            this.x = Math.random() * 700;
            //set the y value to a random position
            this.y = Math.random() * 700;
        }
    }

   
}