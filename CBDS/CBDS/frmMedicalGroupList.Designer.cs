namespace CBDS
{
    partial class frmMedicalGroupList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalGroupList));
            this.lstMedicalGroups = new System.Windows.Forms.ListBox();
            this.p2428097tblMedicalGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sukhman_Lidder_ConsultantsdBDataSet = new CBDS.Sukhman_Lidder_ConsultantsdBDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p2428097_tblMedicalGroupTableAdapter = new CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.P2428097_tblMedicalGroupTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p2428097tblMedicalGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sukhman_Lidder_ConsultantsdBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMedicalGroups
            // 
            this.lstMedicalGroups.DataSource = this.p2428097tblMedicalGroupBindingSource;
            this.lstMedicalGroups.DisplayMember = "ssl_Name";
            this.lstMedicalGroups.FormattingEnabled = true;
            this.lstMedicalGroups.ItemHeight = 20;
            this.lstMedicalGroups.Location = new System.Drawing.Point(94, 122);
            this.lstMedicalGroups.Name = "lstMedicalGroups";
            this.lstMedicalGroups.Size = new System.Drawing.Size(402, 364);
            this.lstMedicalGroups.TabIndex = 0;
            this.lstMedicalGroups.ValueMember = "ssl_MedicalGroupCode";
            this.lstMedicalGroups.SelectedIndexChanged += new System.EventHandler(this.lstMedicalGroups_SelectedIndexChanged);
            // 
            // p2428097tblMedicalGroupBindingSource
            // 
            this.p2428097tblMedicalGroupBindingSource.DataMember = "P2428097_tblMedicalGroup";
            this.p2428097tblMedicalGroupBindingSource.DataSource = this.sukhman_Lidder_ConsultantsdBDataSet;
            // 
            // sukhman_Lidder_ConsultantsdBDataSet
            // 
            this.sukhman_Lidder_ConsultantsdBDataSet.DataSetName = "Sukhman_Lidder_ConsultantsdBDataSet";
            this.sukhman_Lidder_ConsultantsdBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(621, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 46);
            this.label1.TabIndex = 62;
            this.label1.Text = "Medical group details list";
            // 
            // p2428097_tblMedicalGroupTableAdapter
            // 
            this.p2428097_tblMedicalGroupTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(701, 565);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 64);
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(348, 491);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 47);
            this.btnDelete.TabIndex = 66;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(240)))));
            this.btnEdit.Location = new System.Drawing.Point(238, 492);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(104, 46);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(240)))));
            this.btnAdd.Location = new System.Drawing.Point(130, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 47);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMedicalGroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 641);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMedicalGroups);
            this.Name = "frmMedicalGroupList";
            this.Text = "MedicalGroupList";
            this.Activated += new System.EventHandler(this.frmMedicalGroupList_Activated);
            this.Load += new System.EventHandler(this.MedicalGroupList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p2428097tblMedicalGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sukhman_Lidder_ConsultantsdBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMedicalGroups;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Sukhman_Lidder_ConsultantsdBDataSet sukhman_Lidder_ConsultantsdBDataSet;
        private System.Windows.Forms.BindingSource p2428097tblMedicalGroupBindingSource;
        private Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.P2428097_tblMedicalGroupTableAdapter p2428097_tblMedicalGroupTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}