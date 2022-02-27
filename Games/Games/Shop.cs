using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    class Shop
    {
        //this class cointains a list of PS and Xbox games
        private string shopName;
        public List<Game> GamesForSale;
        private int currentlyViewedGame = 0;
        
        //constructor
        public Shop(string shopName)
        {
            GamesForSale = new List<Game>();
            this.shopName = shopName;
        }
        //method for CurrentlyViewedGame
        public int CurrentlyViewedGame
        {
            get { return currentlyViewedGame; }
            set { value = currentlyViewedGame; }
        }
        //method to return number of games
        public int NumberOfGames
        {
            get { return GamesForSale.Count; }
        }
        //method to return the description of a game
        public string DescribeCurrentGame()
        {
            string description;
            //if any games are avaialbe it will display the game
            if (GamesForSale.Count > 0)
            {
                description = GamesForSale[currentlyViewedGame].Description();
            }
            //if there are no games
            else
            {
                description = "No games in stock";
            }
            //return the description
            return description;
        }
        //method to add a game to the list
        public void AddGame(Game game)
        {
            GamesForSale.Add(game);
        }

        public void RemoveGameAt(int index)
        {
            if (index < GamesForSale.Count)
            {
                GamesForSale.RemoveAt(index);
                //enrue that the game is pointing at 0 or at the existing game
                LegaliseCurrentGAme();
            }
        }
        //method to ensire the game currently displaied is indexed at a game that exists
        private void LegaliseCurrentGAme()
        {
            if (currentlyViewedGame > (GamesForSale.Count - 1))
            {
                currentlyViewedGame = GamesForSale.Count - 1;
                //it vill be -1 if the stock is 0
                if (currentlyViewedGame < 0)
                {
                    //its legal or 0
                    currentlyViewedGame = 0;
                }
            }
        }

        //method to check if there is any previous game
        public bool IsPreviousGame()
        {
            if (currentlyViewedGame > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //method to check if there is any next game
        public bool IsNextGame()
        {
            if (currentlyViewedGame < GamesForSale.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //method to move to the previous game
        public void StepToPreviousGame()
        {
            if (IsPreviousGame())
            {
                currentlyViewedGame--;
            }
        }
        //method to move to the next game
        public void StepToNextGame()
        {
            if (IsNextGame())
            {
                currentlyViewedGame++;
            }
        }

        //function to convert the list of games
        //it returns the description of the game
        private string ConvertListToString(List<Game> gamesString)
        {
            //variable to store the result
            string result = "";
            foreach (Game game in gamesString)
            {
                if (result != "")
                {
                    result = result + Environment.NewLine;
                }
                //generate the string
                result = result + game.Description();
            }
            //return the result
            return result;
        }
        //method to find the oldest game
        public string FindOldestGame()
        {
            //variable to store the game
            //if there are no games in the list it will return an empty list
            string result = "";
            //if there is at least 1 game in the list
            if (GamesForSale.Count > 0)
            {
                //there must be an oldest game
                List<Game> OldestGame = new List<Game>();
                //assume it is the first game in the list
                OldestGame.Add(GamesForSale[0]);
                //now look at the other games in the list
                for (int i = 1; i < GamesForSale.Count; i++)
                {
                    if (GamesForSale[i].IsOlderThan(OldestGame[0]))
                    {
                        // This game is the new oldest game
                        OldestGame = new List<Game>();
                        //New list object to hold new oldest
                        OldestGame.Add(GamesForSale[i]);
                    }
                    else if (GamesForSale[i].IsSameAs(OldestGame[0]))
                    {
                        // we have more than one oldest game at this point
                        OldestGame.Add(GamesForSale[i]);
                    }

                }
                //convert the value to string
                result = ConvertListToString(OldestGame);
                //for neatness we add the age to a string on a new line
                result = result + Environment.NewLine + "Released on:" + OldestGame[0].ReleaseDate;

            }
            //return the result
            return result;
        }

        //method to find the oldest game
        public string FindNewestGame()
        {
            //variable to store the game
            //if there are no games in the list it will return an empty list
            string result = "";
            //if there is at least 1 game in the list
            if (GamesForSale.Count > 0)
            {
                //there must be a newest game
                List<Game> NewestGame = new List<Game>();
                //assume it is the first game in the list
                NewestGame.Add(GamesForSale[0]);
                //now look at the other games in the list
                for (int i = 1; i < GamesForSale.Count; i++)
                {
                    if (GamesForSale[i].IsNewerThan(NewestGame[0]))
                    {
                        // This game is the new Newest game
                        NewestGame = new List<Game>();
                        //New list object to hold new Newest
                        NewestGame.Add(GamesForSale[i]);
                    }
                    else if (GamesForSale[i].IsSameAs(NewestGame[0]))
                    {
                        // we have more than one oldest game at this point
                        NewestGame.Add(GamesForSale[i]);
                    }


                }
                //convert the value to string
                result = ConvertListToString(NewestGame);
                //for neatness we add the age to a string on a new line
                result = result + Environment.NewLine + "Released on:" + NewestGame[0].ReleaseDate;
            }
            //return the result
            return result;
        }
        //sort the list of games
        public void Sort()
        {
            GamesForSale.Sort();
        }

    }
}

