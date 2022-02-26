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
    public partial class F3_MedicalCentreDetailsList : Form
    {
        public F3_MedicalCentreDetailsList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create an instance of the F1_MedicalCentreDetailsEntry
            F1_MedicalCentreDetailsEntry MedicalCentres = new F1_MedicalCentreDetailsEntry();
            //make the form a chind of the midi parent
            MedicalCentres.MdiParent = this.MdiParent;
            //display the order entry form
            MedicalCentres.Show();
            //invoke the add new member method (created in the F1_MedicalCentreDetailEntry)
            MedicalCentres.AddNewMedicalCentre(); //sets form ready for new order entry
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //create an instance of F1_MedicalCentreDetailsEntry   
            F1_MedicalCentreDetailsEntry Medical = new F1_MedicalCentreDetailsEntry();
            //declare a varialbe to store the medical centre number from the list box 
            string MedicalCetreNo;
            //check to see if a record has been selected
            if (lstMedicalCentres.SelectedIndex != 1)
            {
                MedicalCetreNo = Convert.ToString(lstMedicalCentres.SelectedValue);
                //make the form a child of the mdi parent
                Medical.MdiParent = this.MdiParent;
                //display the MedicalCentre entry from
                Medical.Show();
                //invoke the find Medical Centre method
                Medical.FindMedicalCentre(MedicalCetreNo);
            }
            else
            {
                //if nothing is selected display error message
                MessageBox.Show("Please select a Medical Centre from the list", "Meidical Centre list", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
                Index = lstMedicalCentres.SelectedIndex;
                //delete the record
                sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalCentre.Rows[Index].Delete();
                //update the data to the database using the table adapter
                this.p2428097_tblMedicalCentreTableAdapter.Update(this.sukhman_Lidder_ConsultantsdBDataSet);
                //refresh the list by calling the activated handler
                this.F3_MedicalCentreDetailsList_Activated(null, null);
                

            }
        }
       

        private void F3_MedicalCentreDetailsList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblPracticeGP' table. You can move, or remove it, as needed.
            this.p2428097_tblPracticeGPTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblPracticeGP);

            // TODO: This line of code loads data into the 'sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalCentre' table. You can move, or remove it, as needed.
            this.p2428097_tblMedicalCentreTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalCentre);

            

            //disable the edit button
            btnEdit.Enabled = false;
            //disable the add button
            btnDelete.Enabled = false;
        }

        private void lstMedicalCentres_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable the edit button
            btnEdit.Enabled = true;
            //enable the add button
            btnDelete.Enabled = true;
            if(lstMedicalCentres.SelectedIndex != -1)
            {
                //messagebox.show("listbox value" + lstMedicalCentres selected value)
                //get selected value from the list box that should contain the primary key
                String mcn = Convert.ToString(lstMedicalCentres.SelectedValue);
                //invoke the local set medical centre method to store the student number
                SetMedicalCentre(mcn);
                //tell the parent form that medical centre  number is ready to fech
                OnMedicalCentreSelected(null);
            }
        }
        //store currently selected medical centre number
        private string MedicalCentreNO;
        private void SetMedicalCentre(String mcn)
        {
            MedicalCentreNO = mcn;
        }
        public string GetMedicalCentre()
        {
            return MedicalCentreNO;
        }
        //event to indicate that the new Medical centre is selected 
        public event EventHandler MedicalCentreSelected;
        //called to signal to parent form that Medical centre no is available
        protected virtual void OnMedicalCentreSelected(EventArgs e)
        {
            EventHandler myHandler = MedicalCentreSelected;
            if (myHandler != null)
            {
                myHandler(this, e);
            }
        }

        private void F3_MedicalCentreDetailsList_Activated(object sender, EventArgs e)
        {
            //load the data from the medicalCentre table
            this.p2428097_tblMedicalCentreTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalCentre);
            //disable the edit button
            btnEdit.Enabled = false;
            //disable the add button
            btnDelete.Enabled = false;
        }

        private void btnFindCentre_Click(object sender, EventArgs e)
        {
            if (txtMedicalCentreNo.Text == "" && txtAddress.Text != "")
            {
                this.listBox1.SelectedValue = txtAddress.Text;
            }
            if (txtAddress.Text == "" && txtMedicalCentreNo.Text != "")
            {
                this.lstMedicalCentres.SelectedValue = txtMedicalCentreNo.Text;
            }
            if(txtMedicalCentreNo.Text !="" && txtAddress.Text != "")
            {
                this.lstMedicalCentres.SelectedValue = txtMedicalCentreNo.Text;
                this.listBox1.SelectedValue = txtAddress.Text;
                //execure the stored procedure to load the medical centre list
                //this.sproc_FindmedicalCentresTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.Sproc_FindmedicalCentres, Convert.ToInt32(txtMedicalCentreNo.Text), txtAddress.Text, txtPostCode.Text);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.p2428097_tblMedicalCentreTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalCentre);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }


}
