using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Games
{
    public partial class Form1 : Form
    {
        //contains the list of games
        Shop shop;
        //list to store the games
        //List<Game> gamesList = new List<Game>();
        
        //vatiable to store the shopName
        string shopName = "GamesFun"; 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //step to next game
            shop.StepToNextGame();
            //display the gmae 
            DisplayGame();
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //step to previous game
            shop.StepToPreviousGame();
            //display the game 
            DisplayGame();
            
        }
        private void DisplayGame()
        {
            lblCurrentGame.Text = string.Format("Viewing {0} of {1}",
            shop.CurrentlyViewedGame + 1, shop.NumberOfGames);
            txtGame.Text = shop.DescribeCurrentGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            shop = new Shop(shopName);
            /*
            //add games here
            PSGame PS1 = new PSGame("GTA 5", "Rockstar Games", 30, new DateTime(2013 , 09 , 17), Game.Condition.fair);
            PSGame PS2 = new PSGame("FIfA 22", "Electronic Arts", 35, new DateTime(2021 , 09 , 26), Game.Condition.mint);
            PSGame PS3 = new PSGame("NBA 2K22", "2K Games", 50, new DateTime(2018 , 11 , 17), Game.Condition.good);
            PSGame PS4 = new PSGame("God of War", "Santa Monica Studios", 55, new DateTime(2015, 11, 17), Game.Condition.poor);
            PSGame PS5 = new PSGame("The sims 4", "The Sims Studio", 25, new DateTime(2017, 11, 17), Game.Condition.good);
            PSGame PS6 = new PSGame("Minecraft", "Mojang Studios", 35, new DateTime(2010, 1, 17), Game.Condition.poor);
            XboxGame x1 = new XboxGame("Fallout 4", "Creation Engine", 35, new DateTime(2015, 1, 7), Game.Condition.poor);
            XboxGame x2 = new XboxGame("Plants vs Zombies", "PopCap Games", 35, new DateTime(2009, 1, 15), Game.Condition.poor);
            XboxGame x3 = new XboxGame("The Sims 2", "Maxis", 35, new DateTime(2004, 1, 17), Game.Condition.poor);
            XboxGame x4 = new XboxGame("Rise of the Tomb Raider", "Crystal Dynamics", 35, new DateTime(2010, 1, 17), Game.Condition.poor);
            XboxGame x5 = new XboxGame("Farming Simulator", "Giants Software", 35, new DateTime(2010, 1, 17), Game.Condition.poor);
            XboxGame x6 = new XboxGame("Death Scared", "SMG Studios", 35, new DateTime(2010, 1, 17), Game.Condition.poor);
            //add the games to the shop
            shop.AddGame(PS1);
            shop.AddGame(PS2);
            shop.AddGame(PS3);
            shop.AddGame(PS4);
            shop.AddGame(PS5);
            shop.AddGame(PS6);
            shop.AddGame(x1);
            shop.AddGame(x2);
            shop.AddGame(x3);
            shop.AddGame(x4);
            shop.AddGame(x5);
            shop.AddGame(x6);*/

            //display the game
            DisplayGame();
        }

        private void btnFindOldest_Click(object sender, EventArgs e)
        {
            //message will appear in the message box title bar
            string caption = "The oldest game";

            //ask the shop class for the oldest game
            string message = shop.FindOldestGame();
            // the list might be empty
            if (message == "")
            {
                message = "No games!";
            }
            // inform the user display the message in the message box
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFindNewest_Click(object sender, EventArgs e)
        {
            //message will appear in the message box title bar
            string caption = "The Newest game";

            //ask the birthday class for the oldest game
            string message = shop.FindNewestGame();
            // the list might be empty
            if (message == "")
            {
                message = "No games!";
            }
            // inform the user display the message in the message box
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //sort the list
            shop.Sort();
            //redisplay the games
            DisplayGame();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGames();
        }

       private void btnSave_Click(object sender, EventArgs e)
        {
            SaveGames();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(shop.CurrentlyViewedGame <shop.NumberOfGames)
            {
                string currentGame = shop.GamesForSale[shop.CurrentlyViewedGame].GameTitle;

                if(MessageBox.Show("Delete"+ shop.CurrentlyViewedGame+"Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                {
                    DeleteGame();
                }
            }
        }

        public void LoadGames()
        {
            string fileName = null;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.DefaultExt = "*.txt";
            openDialog.Filter = "Games list files (text)|*.txt";
            openDialog.FileName = "Games_data.txt";
            openDialog.InitialDirectory = Directory.GetCurrentDirectory();

            DialogResult dr = openDialog.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                //could fail - so we have a try catch block
                //also we load to a second copy of the game list
                //then if the load is ok we copy the data to the original list
                //
                //this means that if the load fails we won't lose any original list

                try
                {
                    fileName = openDialog.FileName;

                    System.IO.FileStream filestream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    List<Game> restoredGamesList = null;
                    restoredGamesList = (List<Game>)f.Deserialize(filestream);
                    filestream.Close();

                    // copy this across to the real one
                    shop.GamesForSale = restoredGamesList;

                    //looking at 1st animal (if it exists)
                    //currentAnimal = 0;
                    //DisplayAnimalDetails(currentAnimal);
                    //EnableValidControls();
                    DisplayGame();

                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void SaveGames()
        {
            //create the save dialog and give it sensible default values

            string saveFilename = null;
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "*.txt";
            saveDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveDialog.Filter = "Game list files (text)|*.txt";
            saveDialog.FileName = "Games_data.txt";

            DialogResult dr = saveDialog.ShowDialog();


            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // this could fail so we need a try catch block around it

                try
                {
                    saveFilename = saveDialog.FileName;

                    //this is the net recipe for saving an list of serializable objects
                    //serializable means able to be sent to a filestream

                    System.IO.FileStream s = new System.IO.FileStream(saveFilename, System.IO.FileMode.Create);
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    f.Serialize(s, shop.GamesForSale);
                    s.Close();


                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        
        public void DeleteGame()
        {
            //careful - cannot delete if no games are there

            if (shop.GamesForSale.Count > 0)
            {
                //keep the name of the game we are about to delete
                //so we can say its gone
                string name = shop.GamesForSale[shop.CurrentlyViewedGame].Description();

                //delete it
                shop.GamesForSale.RemoveAt(shop.CurrentlyViewedGame);

                //if we were looking at the last game in the list then step back 1
                //(otherwise we leave the currentGame unchanged)

                if (shop.CurrentlyViewedGame >= shop.GamesForSale.Count)
                {
                    //except of course if we deleted the only game we can't step back to -1

                    if ((shop.GamesForSale.Count > 0))
                    {
                        shop.CurrentlyViewedGame = shop.GamesForSale.Count - 1;
                    }
                    else
                    {
                        shop.CurrentlyViewedGame = 0;
                    }
                }

                //currentgame will have changed so redraw the display
                DisplayGame();
                MessageBox.Show(name + " deleted", "Delete Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            //instance of the form
            AddGames Add = new AddGames();
            //show the form
            Add.Show();
        }
    }
}
