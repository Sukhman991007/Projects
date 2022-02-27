function Accelerate(Gravity) 
{
	//variables
    var ax = 0;
	var ay = 0;
	var gravity = Gravity;

    Object.defineProperty(this, 'AX',
    {
        get: function () {
            return ax;
        }
    })

    Object.defineProperty(this, 'AY',
    {
        get: function () {
            return ay + gravity;
        }
    })
    //function to move the sprite up and down
    Accelerate.prototype.VThrust = function (Thrust) 
	{
        // below different from lab download
		// experimenting is key, figures here and HTML called from
		
		ay -= Thrust + 0.002;
		
		if (ay > 1.5) 
			{ ay = 0;}
    }
    //function to move the sprite left to right
    Accelerate.prototype.HThrust = function (Thrust) 
	{
        ax -= Thrust + 0.002;
    }
    //fucntion for halt
	Accelerate.prototype.Halt = function () 
	{
        ay = 0;
        ax = 0;
    }

}