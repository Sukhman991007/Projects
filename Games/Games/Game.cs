using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    [Serializable()]
    public abstract class Game : IComparable
    {
        public enum Condition
        {
            poor,
            fair,
            good,
            mint
        }

        protected string console;
        protected string gameTitle;
        protected string gameDev;
        protected Condition condition;
        protected decimal originalPrice;
        protected DateTime releaseDate;
        
        public decimal Originalprice
        {
            get
            {
                return originalPrice;
            }
            set
            {
                originalPrice = value;
            }
        }
        public DateTime ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                releaseDate = value;
            }
        }
        public Condition GetCondition
        {
            get
            {
                return condition;
            }
        }
        public string GameTitle
        {
            get
            {
                return gameTitle;
            }
            set
            {
                value = gameTitle;
            }
        }
        public string GameDev
        {
            get 
            {
                return gameDev;
            }
            set
            {
                gameDev = value; 
            }
        }
        //constructor
        public Game(string gameTitle, string gameDev, decimal originalPrice, DateTime releaseDate, Condition condition)
        {
            this.gameTitle = gameTitle;
            this.gameDev = gameDev;
            this.originalPrice = originalPrice;
            this.releaseDate = releaseDate;
            this.condition = condition;
        }
        //method to calcuate the age in years
        public int CalculateApproximateAgeInYears()
        {
            DateTime now = DateTime.Now;
            TimeSpan ageAsTimeSpan = now.Subtract(releaseDate);
            //get the time in years does not take in to account the leap years
            int ageInYears = ageAsTimeSpan.Days / 365;
            //return the age
            return ageInYears;
        }
        //abstract method to be implemented in the derived class
        public abstract decimal CalculateApproximateValue();
        public virtual string Description()
        {
            //get a string describing the current games condition from the names in the condition enumeration
            string conditionName = Enum.GetName(typeof(Condition), condition);
            //strign to describe the current games each attribute will be in written in a new line 
            string description = string.Format("Title: {0}{1}Developer: {2}{3}Condition: {4}{5}Current value:{6:c}", gameTitle, Environment.NewLine, gameDev, Environment.NewLine, condition, Environment.NewLine, CalculateApproximateValue());
            //return the description
            return description;
        }

        //comparing the value to sort them in a default order 
        int IComparable.CompareTo(object obj)
        {
            //IComparable return 1, 0, -1.
            Game otherGame = (Game)obj;
            //difference in price
            decimal differenceInPrice = this.CalculateApproximateValue() - otherGame.CalculateApproximateValue();
            //return the value 1, 0 -1
            return Math.Sign(differenceInPrice);
        }
        //method to check if the current game is older than the game that is compared to
        public bool IsOlderThan( Game otherGame)
        {
            //compare the games
            if(releaseDate <otherGame.ReleaseDate)
            {
                //return true
                return true;
            }
            //if its newer than the other game 
            else
            {
                //return false
                return false;
            }
        }
        //method to check if the current game is newer than the game that is compared to
        public bool IsNewerThan(Game otherGame)
        {
            //compare the games
            if (releaseDate > otherGame.ReleaseDate)
            {
                //return true
                return true;
            }
            //if its older than the other game
            else
            {
                //return false
                return false;
            }
        }
        //method to check if the current game is released on the same day than the game that is compared to
        public bool IsSameAs(Game otherGame)
        {
            //compare the games
            if (releaseDate == otherGame.ReleaseDate)
            {
                //return true
                return true;
            }
            //if the games are not released on the same day
            else
            {
                //return false
                return false;
            }
        }

    }


}
