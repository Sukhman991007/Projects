using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    [Serializable()]
    public class PSGame : Game
    {
        public PSGame(string gameTitle, string gameDev, decimal originalPrice, DateTime releseDate, Condition condition)
            : base(gameTitle, gameDev, originalPrice, releseDate, condition)
        {
            //nothing to put in the constructor because the xboxGames classs does not add any attributes
        }
        //this calculation is overriden in both classes the base and the derived
        public override decimal CalculateApproximateValue()
        {
            //var to store the value
            decimal value = 0;
            // modify the game value based on the condition
            if (condition == Condition.mint)
            {
                value = originalPrice * 0.8m; //80% of origianl value
            }
            else if (condition == Condition.good)
            {
                value = originalPrice * 0.7m; //70% of origianl value
            }
            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.5m; //50% of origianl value
            }
            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.4m; //40% of origianl value
            }
            //we take in to account the games age
            //for loop to calculate the value each year the PS game looses 20% value
            int age = CalculateApproximateAgeInYears();
            for (int i = 0; i < age; i++)
            {
                //each year we loose 20% of the value
                value = value * 0.8m;
            }
            //round the value to the nearest pound
            value = Decimal.Round(value, 0);
            //round to the nearest £1
            value = value - (value % 1);
            //add £0.99
            value = value + 0.99m;
            //return the value
            return value;
        }
    }

}
