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
    public partial class frmMedicalGroupList : Form
    {
        public frmMedicalGroupList()
        {
            InitializeComponent();
        }

        private void MedicalGroupList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalGroup' table. You can move, or remove it, as needed.
            this.p2428097_tblMedicalGroupTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalGroup);

            //disable the edit button
            btnEdit.Enabled = false;
            //disable the add button
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //declare a variable to store the result returned by the messege box

            DialogResult Response;
            // ask the user if they areally mean it
            Response = MessageBox.Show("are you really sure you want to delete the Medical centre?", "Delete Medical centre",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Response == DialogResult.Yes)
            //delete the selected record here and update the database and list
            {
                //declare a variable to store the index on the list
                int Index;
                //get the index from the list box
                Index = lstMedicalGroups.SelectedIndex;
                //delete the record
                sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalGroup.Rows[Index].Delete();
                //update the data to the database using the table adapter
                this.p2428097_tblMedicalGroupTableAdapter.Update(this.sukhman_Lidder_ConsultantsdBDataSet);
                //refresh the list by calling the activated handler
                this.frmMedicalGroupList_Activated(null, null);


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //create an instance of frmStudentEntry   
            frmMedicalGroupEntry Medical = new frmMedicalGroupEntry();
            //declare a varialbe to store the student number from the list box 
            string MedicalGroupNo;
            //check to see if a record has been selected
            if (lstMedicalGroups.SelectedIndex != 1)
            {
                MedicalGroupNo = Convert.ToString(lstMedicalGroups.SelectedValue);
                //make the form a child of the mdi parent
                Medical.MdiParent = this.MdiParent;
                //display the student entry from
                Medical.Show();
                //invoke the find student method
                Medical.FindMedicalGroup(MedicalGroupNo);
            }
            else
            {
                //if nothing is selected display error message
                MessageBox.Show("Please select a Medical group from the list", "Meidical group list", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create an instance of the frmOrderEntry
            frmMedicalGroupEntry MedicalGroups = new frmMedicalGroupEntry();
            //make the form a chind of the midi parent
            MedicalGroups.MdiParent = this.MdiParent;
            //display the order entry form
            MedicalGroups.Show();
            //invoke the add new member method (created in the F1_MedicalCentreDetailEntry)
            MedicalGroups.AddNewMedicalGroup(); //sets form ready for new order entry
        }
        
        //event to indicate that the new Medical centre is selected 
        public event EventHandler MedicalGroupSelected;
        //called to signal to parent form that Medical centre no is available
      
        private void frmMedicalGroupList_Activated(object sender, EventArgs e)
        {
            // load the data from the student table
            this.p2428097_tblMedicalGroupTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalGroup);
            //disable the edit button
            btnEdit.Enabled = false;
            //disable the add button
            btnDelete.Enabled = false;
        }

        private string MedicalGroupCode;
        private void SetMedicalGroup(String mgc)
        {
            MedicalGroupCode = mgc;
        }

        public string getMedicalGroup()
        {
            return MedicalGroupCode;
        }

        protected virtual void OnMedicalGroupSelected(EventArgs e)
        {
            EventHandler myHandler = MedicalGroupSelected;
            if (myHandler != null)
            {
                myHandler(this, e);
            }
        }

        private void lstMedicalGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable the edit button
            btnEdit.Enabled = true;
            //enable the add button
            btnDelete.Enabled = true;
            if (lstMedicalGroups.SelectedIndex != 1)
            {
                //get the selected value from the list that contains the primary key
                string mgc = Convert.ToString(lstMedicalGroups.SelectedValue);
                //invoke the local set method to store the number
                SetMedicalGroup(mgc);
                //tell the parent that the medical group is ready to fetch
                OnMedicalGroupSelected(null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
