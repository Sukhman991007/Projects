namespace CBDS
{
    partial class F3_MedicalCentreDetailsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label ssl_AddressLabel;
            System.Windows.Forms.Label ssl_MedicalCentreNoLabel;
            System.Windows.Forms.Label ssl_PostCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F3_MedicalCentreDetailsList));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstMedicalCentres = new System.Windows.Forms.ListBox();
            this.p2428097tblMedicalCentreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sukhman_Lidder_ConsultantsdBDataSet = new CBDS.Sukhman_Lidder_ConsultantsdBDataSet();
            this.sprocFindmedicalCentresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFindCentre = new System.Windows.Forms.Button();
            this.p2428097_tblMedicalCentreTableAdapter = new CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.P2428097_tblMedicalCentreTableAdapter();
            this.tableAdapterManager = new CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.TableAdapterManager();
            this.sproc_FindmedicalCentresTableAdapter = new CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.Sproc_FindmedicalCentresTableAdapter();
            this.p2428097_tblPracticeGPTableAdapter = new CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.P2428097_tblPracticeGPTableAdapter();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtMedicalCentreNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ssl_AddressLabel = new System.Windows.Forms.Label();
            ssl_MedicalCentreNoLabel = new System.Windows.Forms.Label();
            ssl_PostCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p2428097tblMedicalCentreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sukhman_Lidder_ConsultantsdBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprocFindmedicalCentresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ssl_AddressLabel
            // 
            ssl_AddressLabel.AutoSize = true;
            ssl_AddressLabel.Location = new System.Drawing.Point(582, 242);
            ssl_AddressLabel.Name = "ssl_AddressLabel";
            ssl_AddressLabel.Size = new System.Drawing.Size(72, 20);
            ssl_AddressLabel.TabIndex = 63;
            ssl_AddressLabel.Text = "Address:";
            // 
            // ssl_MedicalCentreNoLabel
            // 
            ssl_MedicalCentreNoLabel.AutoSize = true;
            ssl_MedicalCentreNoLabel.Location = new System.Drawing.Point(478, 206);
            ssl_MedicalCentreNoLabel.Name = "ssl_MedicalCentreNoLabel";
            ssl_MedicalCentreNoLabel.Size = new System.Drawing.Size(179, 20);
            ssl_MedicalCentreNoLabel.TabIndex = 64;
            ssl_MedicalCentreNoLabel.Text = "Medical Centre Number:";
            // 
            // ssl_PostCodeLabel
            // 
            ssl_PostCodeLabel.AutoSize = true;
            ssl_PostCodeLabel.Location = new System.Drawing.Point(570, 277);
            ssl_PostCodeLabel.Name = "ssl_PostCodeLabel";
            ssl_PostCodeLabel.Size = new System.Drawing.Size(87, 20);
            ssl_PostCodeLabel.TabIndex = 65;
            ssl_PostCodeLabel.Text = "Post Code:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(663, 593);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 64);
            this.btnClose.TabIndex = 73;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(262, 499);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 47);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(240)))));
            this.btnEdit.Location = new System.Drawing.Point(152, 500);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 46);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(240)))));
            this.btnAdd.Location = new System.Drawing.Point(44, 500);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 47);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstMedicalCentres
            // 
            this.lstMedicalCentres.DataSource = this.p2428097tblMedicalCentreBindingSource;
            this.lstMedicalCentres.DisplayMember = "ssl_Address";
            this.lstMedicalCentres.FormattingEnabled = true;
            this.lstMedicalCentres.ItemHeight = 20;
            this.lstMedicalCentres.Location = new System.Drawing.Point(30, 145);
            this.lstMedicalCentres.Name = "lstMedicalCentres";
            this.lstMedicalCentres.Size = new System.Drawing.Size(358, 324);
            this.lstMedicalCentres.TabIndex = 131;
            this.lstMedicalCentres.ValueMember = "ssl_MedicalCentreNo";
            this.lstMedicalCentres.SelectedIndexChanged += new System.EventHandler(this.lstMedicalCentres_SelectedIndexChanged);
            // 
            // p2428097tblMedicalCentreBindingSource
            // 
            this.p2428097tblMedicalCentreBindingSource.DataMember = "P2428097_tblMedicalCentre";
            this.p2428097tblMedicalCentreBindingSource.DataSource = this.sukhman_Lidder_ConsultantsdBDataSet;
            // 
            // sukhman_Lidder_ConsultantsdBDataSet
            // 
            this.sukhman_Lidder_ConsultantsdBDataSet.DataSetName = "Sukhman_Lidder_ConsultantsdBDataSet";
            this.sukhman_Lidder_ConsultantsdBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sprocFindmedicalCentresBindingSource
            // 
            this.sprocFindmedicalCentresBindingSource.DataMember = "Sproc_FindmedicalCentres";
            this.sprocFindmedicalCentresBindingSource.DataSource = this.sukhman_Lidder_ConsultantsdBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 46);
            this.label1.TabIndex = 36;
            this.label1.Text = "Medical centres list";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(561, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "Search paramters";
            // 
            // btnFindCentre
            // 
            this.btnFindCentre.BackColor = System.Drawing.Color.Red;
            this.btnFindCentre.Location = new System.Drawing.Point(614, 334);
            this.btnFindCentre.Name = "btnFindCentre";
            this.btnFindCentre.Size = new System.Drawing.Size(113, 40);
            this.btnFindCentre.TabIndex = 72;
            this.btnFindCentre.Text = "Find centre";
            this.btnFindCentre.UseVisualStyleBackColor = false;
            this.btnFindCentre.Click += new System.EventHandler(this.btnFindCentre_Click);
            // 
            // p2428097_tblMedicalCentreTableAdapter
            // 
            this.p2428097_tblMedicalCentreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P2428097_tblAppointmentTableAdapter = null;
            this.tableAdapterManager.P2428097_tblConsultantTableAdapter = null;
            this.tableAdapterManager.P2428097_tblGPTableAdapter = null;
            this.tableAdapterManager.P2428097_tblHospitalTableAdapter = null;
            this.tableAdapterManager.P2428097_tblMedicalCentreTableAdapter = this.p2428097_tblMedicalCentreTableAdapter;
            this.tableAdapterManager.P2428097_tblMedicalGroupTableAdapter = null;
            this.tableAdapterManager.P2428097_tblPatientTableAdapter = null;
            this.tableAdapterManager.P2428097_tblPracticeGPTableAdapter = null;
            this.tableAdapterManager.P2428097_tblSpecialityTableAdapter = null;
            this.tableAdapterManager.P2428097_tblStaffTableAdapter = null;
            this.tableAdapterManager.P2428097_tblTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sproc_FindmedicalCentresTableAdapter
            // 
            this.sproc_FindmedicalCentresTableAdapter.ClearBeforeFill = true;
            // 
            // p2428097_tblPracticeGPTableAdapter
            // 
            this.p2428097_tblPracticeGPTableAdapter.ClearBeforeFill = true;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(654, 273);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(100, 26);
            this.txtPostCode.TabIndex = 71;
            // 
            // txtMedicalCentreNo
            // 
            this.txtMedicalCentreNo.Location = new System.Drawing.Point(654, 203);
            this.txtMedicalCentreNo.Name = "txtMedicalCentreNo";
            this.txtMedicalCentreNo.Size = new System.Drawing.Size(100, 26);
            this.txtMedicalCentreNo.TabIndex = 69;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(654, 239);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 26);
            this.txtAddress.TabIndex = 70;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.p2428097tblMedicalCentreBindingSource;
            this.listBox1.DisplayMember = "ssl_MedicalCentreNo";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(378, 459);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(10, 4);
            this.listBox1.TabIndex = 74;
            this.listBox1.ValueMember = "ssl_Address";
            this.listBox1.Visible = false;
            // 
            // F3_MedicalCentreDetailsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 677);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMedicalCentreNo);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.btnFindCentre);
            this.Controls.Add(ssl_PostCodeLabel);
            this.Controls.Add(ssl_MedicalCentreNoLabel);
            this.Controls.Add(ssl_AddressLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstMedicalCentres);
            this.Name = "F3_MedicalCentreDetailsList";
            this.Text = "F3_MedicalCentreDetailsList";
            this.Activated += new System.EventHandler(this.F3_MedicalCentreDetailsList_Activated);
            this.Load += new System.EventHandler(this.F3_MedicalCentreDetailsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p2428097tblMedicalCentreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sukhman_Lidder_ConsultantsdBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprocFindmedicalCentresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstMedicalCentres;
        private Sukhman_Lidder_ConsultantsdBDataSet sukhman_Lidder_ConsultantsdBDataSet;
        private System.Windows.Forms.BindingSource p2428097tblMedicalCentreBindingSource;
        private Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.P2428097_tblMedicalCentreTableAdapter p2428097_tblMedicalCentreTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.Sproc_FindmedicalCentresTableAdapter sproc_FindmedicalCentresTableAdapter;
        private System.Windows.Forms.Button btnFindCentre;
        private Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.P2428097_tblPracticeGPTableAdapter p2428097_tblPracticeGPTableAdapter;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtMedicalCentreNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.BindingSource sprocFindmedicalCentresBindingSource;
        private System.Windows.Forms.ListBox listBox1;
    }
}