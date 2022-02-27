using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    [Serializable()]
    public class XboxGame : Game
    {
        public XboxGame(string gameTitle, string gameDev, decimal originalPrice, DateTime releseDate, Condition condiditon)
            : base(gameTitle, gameDev, originalPrice, releseDate, condiditon)
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
                value = originalPrice * 0.9m; //90% of origianl value
            }
            else if (condition == Condition.good)
            {
                value = originalPrice * 0.8m; //80% of origianl value
            }
            else if (condition == Condition.fair)
            {
                value = originalPrice * 0.7m; //70% of origianl value
            }
            else if (condition == Condition.poor)
            {
                value = originalPrice * 0.5m; //50% of origianl value
            }
            //we take in to account the games age
            //for loop to calculate the value each year the  XBox game looses 10% value
            int age = CalculateApproximateAgeInYears();
            for (int i = 0; i < age; i++)
            {
                value = value * 0.9m;
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
