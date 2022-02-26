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
    public partial class F1_MedicalCentreDetailsEntry : Form
    {
        public F1_MedicalCentreDetailsEntry()
        {
            InitializeComponent();
        }

        private void p2428097_tblMedicalCentreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p2428097_tblMedicalCentreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sukhman_Lidder_ConsultantsdBDataSet);

        }

        private void F1_MedicalCentrerDetailsEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblPracticeGP' table. You can move, or remove it, as needed.
            this.p2428097_tblPracticeGPTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblPracticeGP);
            // TODO: This line of code loads data into the 'sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalCentre' table. You can move, or remove it, as needed.
            this.p2428097_tblMedicalCentreTableAdapter.Fill(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblMedicalCentre);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //end the editing
            this.p2428097_tblMedicalCentreBindingSource.EndEdit();
            //update the data in the database using the table adapter
            this.tableAdapterManager.UpdateAll(this.sukhman_Lidder_ConsultantsdBDataSet);
        }
        public void AddNewMedicalCentre()
        {
            //public add method
            //set the form in data entry form
            p2428097_tblMedicalCentreBindingSource.AddNew();
            txtMedicalCentreNumber.Text = Convert.ToString(GetNextmedicalCentreNubmer());
            this.medicalCentreNumberToolStripTextBox.PerformClick();
            this.fillBy1ToolStripButton.PerformClick();

        }
        public void FindMedicalCentre(string MedicalCentreNo)
        {
            //public procedure to show the details of a particulat Medical centre on this form
            //filter the data based on the MeicalCentreNo passed as a paramater
            p2428097_tblMedicalCentreBindingSource.Filter = "ssl_MedicalCentreNo =" + Convert.ToString(MedicalCentreNo);
            this.btnTotal.PerformClick();
            this.medicalCentreNumberToolStripTextBox.PerformClick();
            this.fillBy1ToolStripButton.PerformClick();
        }
        private int GetNextmedicalCentreNubmer()
        {
            //using the next available medical centre number
            using (var dBase = new CBDSDataClassDataContext())
            {
                int PreviousNumber = 0; //assume numbers start at 1
                int CurrentNumber;
                //from the stored procedure via the LINQ assume that the numbers are in order
                var numbers = dBase.Sproc_FindNextMedicalCentreNo();
                foreach (var CurrentCentreNumber in numbers)
                {
                    CurrentNumber = Convert.ToInt32(CurrentCentreNumber.ssl_MedicalCentreNo);
                    //debug: message.show(Convert.ToString(CurrentorderNumber))
                    var difference = CurrentNumber - PreviousNumber;
                    if (difference > 1) break;
                    PreviousNumber = CurrentNumber;
                }
                return PreviousNumber + 1;

            }
        }


        private string GetMedicalGroupName(string ssl_MedicalGroupNo)
        {
            //LINQ to get the name from the stored procedure
            using (var dBase = new CBDSDataClassDataContext())
            {
                string GroupName;
                var MedicalGroups = dBase.Sproc_FindMedicalGroup(ssl_MedicalGroupNo);
                foreach (var MedicalGroup in MedicalGroups)
                {
                    GroupName = Convert.ToString(MedicalGroup.ssl_Name);
                    return GroupName;
                }
                return null;
            }
        }

        private void lblMedicalGroupName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this shows the form to get the medical group code
            frmMedicalGroupList MedicalGroup = new frmMedicalGroupList();
            MedicalGroup.MdiParent = this.MdiParent;
            MedicalGroup.MedicalGroupSelected += new EventHandler(get_MedicalGroupSelected);
            MedicalGroup.Show();
        }
        private void get_MedicalGroupSelected(Object sender, EventArgs e)
        {
            //get  the medical group code
            string MedicalGroupCode;
            frmMedicalGroupList ChildForm = sender as frmMedicalGroupList;
            if (ChildForm != null)
            {
                MedicalGroupCode = ChildForm.getMedicalGroup();
                //put the medical group code in the textbox
                this.txtMedicalGroupCode.Text = MedicalGroupCode;
            }
        }

        private void txtMedicalGroupCode_TextChanged(object sender, EventArgs e)
        {
            //show the medical goup name on the label from the  medical group code inputed
            string ssl_MedicalGroupCode = this.txtMedicalGroupCode.Text;
            this.lblMedicalGroupName.Text = this.GetMedicalGroupName(ssl_MedicalGroupCode);
        }

        private int GetdaysPerWeek(int ssl_PracticeGpNo)
        {
            //get the days per week of the practiceGpNo
            Int32 DaysPerWeek;

            //LINQ to get the days per week from the stored procedure
            using (var dPracticeGp = new CBDSDataClassDataContext())
            {
                var PracticeGp = dPracticeGp.sproc_P2428097_tblPracticeGpNo_GetDaysPerWeek(ssl_PracticeGpNo);
                foreach (var b in PracticeGp)//only one row is expected
                {
                    //get the daysPerWeek and Return it via function call
                    DaysPerWeek = Convert.ToInt32(b.ssl_DaysPerWeek);
                    return DaysPerWeek;
                }

            }
            return 0;
        }



        private void p2428097_tblPracticeGPDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int Days;
            int TotalDays = 0;
            int Counter = 0;
            int MedicalcentreNo;
            for (Counter = 0; (Counter < p2428097_tblPracticeGPDataGridView.Rows.Count); Counter++)
            {
                if (p2428097_tblPracticeGPDataGridView.Rows[Counter].Cells["ssl_MedicalCentreNo"].Value != null)
                {
                    //verify that the cell value its not empty
                    if (p2428097_tblPracticeGPDataGridView.Rows[Counter].Cells["ssl_MedicalCentreNo"].Value.ToString().Length != 0)
                    {
                        MedicalcentreNo = int.Parse(p2428097_tblPracticeGPDataGridView.Rows[Counter].Cells["ssl_MedicalCentreNo"].Value.ToString());

                        if (MedicalcentreNo == Convert.ToInt32(txtMedicalCentreNumber.Text))
                        {
                            Days = int.Parse(p2428097_tblPracticeGPDataGridView.Rows[Counter].Cells["ssl_DaysPerWeek"].Value.ToString());
                            TotalDays = Days + TotalDays;

                        }
                    }
                }
            }
            txtTotalDays.Text = Convert.ToString(TotalDays);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.p2428097_tblPracticeGPTableAdapter.FillBy1(this.sukhman_Lidder_ConsultantsdBDataSet.P2428097_tblPracticeGP, new System.Nullable<int>(((int)(System.Convert.ChangeType(medicalCentreNumberToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            
            }

            this.medicalCentreNumberToolStripTextBox.Text = txtMedicalCentreNumber.Text;
        }

        private void medicalCentreNumberToolStripTextBox_Click(object sender, EventArgs e)
        {
            this.medicalCentreNumberToolStripTextBox.Text = txtMedicalCentreNumber.Text;
        }
    }
}

