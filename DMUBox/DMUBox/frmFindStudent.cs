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
    public partial class frmFindStudent : Form
    {
        public frmFindStudent()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sporc_tblStudent_FilterbyStudentNoTableAdapter.Fill(this.DMUBoxDataSet1.sporc_tblStudent_FilterbyStudentNo, studentNoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }

        private void frmFindStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblStudent' table. You can move, or remove it, as needed.
            this.tblStudentTableAdapter.Fill(this.DMUBoxDataSet1.tblStudent);

        }
    }
}
