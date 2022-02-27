using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    
    public partial class AddGames : Form
    {
        private Game game;
        public AddGames()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            game.GameTitle = txtGame.Text;
            game.GameDev = txtDeveloper.Text;
            game.Originalprice = Convert.ToInt32(txtPrice.Text);
            game.ReleaseDate = dateTimePicker1.Value;
            //if its a ps game
            if (cbkPS.Checked == true)
            {
                //this adds the game to the list
                //PSGame PS1 = new PSGame(txtGame.Text, txtDeveloper.Text, Convert.ToInt32(txtPrice.Text), dateTimePicker1.Value, Game.Condition.p(lstCondition.SelectedItem);
                //add the game to the shop
                //shop.AddGame(PS1);
                

            }
            //if its a xbox game
            else
            {

            }
        }
    }
}
