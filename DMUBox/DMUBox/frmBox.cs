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
    public partial class frmBox : Form
    {
        public frmBox()
        {
            InitializeComponent();
        }

        private void tblBoxBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblBoxBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dMUBoxDataSet);

        }

        private void frmBox_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dMUBoxDataSet.tblBox' table. You can move, or remove it, as needed.
            this.tblBoxTableAdapter.Fill(this.dMUBoxDataSet.tblBox);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
    }
}
