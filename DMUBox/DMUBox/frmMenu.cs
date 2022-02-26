using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMUBox
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnBox_Click(object sender, EventArgs e)
        {
            //create an instance of frmBox
            frmBox myBoxForm = new frmBox();
            //display the form
            myBoxForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
     
            //create an instance of frmBox
            frmFindStudent myStudentFindForm = new frmFindStudent();
            //display the form
            myStudentFindForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //create an instance of frmStudent
            frmStudent myStudentForm = new frmStudent();
            //display the form
            myStudentForm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmStudentReport frmStudentReport = new frmStudentReport();
            //display the report
            frmStudentReport.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //creat an instance of fmrHallStudentsReport
            frmHallStudentReport MyHallStudentForm = new frmHallStudentReport();
            //display the report
            MyHallStudentForm.Show();
        }
    }
}
