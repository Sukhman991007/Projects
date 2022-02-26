using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBDS
{
    public partial class frmMedicalGroupEntry : Form
    {
        public frmMedicalGroupEntry()
        {
            InitializeComponent();
        }

        private void frmMedicalGroupEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalGroup' table. You can move, or remove it, as needed.
            this.p2428097_tblMedicalGroupTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalGroup);

        }
        public void AddNewMedicalGroup()
        {
            //public add method
            //set the form in data entry form
            p2428097_tblMedicalGroupBindingSource.AddNew();

        }
        public void FindMedicalGroup(string MedicalGroupNo)
        {
            //public procedure to show the details of a particulat medical group on this form
            //filter the data based on the MeicalGroupCode passed as a paramater
            p2428097_tblMedicalGroupBindingSource.Filter = "ssl_MedicalGroupCode =" + Convert.ToString(MedicalGroupNo);
        }

        private void p2428097_tblMedicalGroupBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p2428097_tblMedicalGroupBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sukhman_Lidder_ConsultantsdBDataSet);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //end the editing
            this.p2428097_tblMedicalGroupBindingSource.EndEdit();
            //update the data in the database using the table adapter
            this.tableAdapterManager.UpdateAll(this.sukhman_Lidder_ConsultantsdBDataSet);
        }

    }
}
