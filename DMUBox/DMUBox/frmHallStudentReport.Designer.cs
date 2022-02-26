namespace DMUBox
{
    partial class frmHallStudentReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sproc_HallStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DMUBoxDataSet1 = new DMUBox.DMUBoxDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentTableAdapter = new DMUBox.DMUBoxDataSet1TableAdapters.tblStudentTableAdapter();
            this.sproc_HallStudentsTableAdapter = new DMUBox.DMUBoxDataSet1TableAdapters.sproc_HallStudentsTableAdapter();
            this.tableAdapterManager = new DMUBox.DMUBoxDataSet1TableAdapters.TableAdapterManager();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dMUBoxDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprocHallStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sproc_HallStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprocHallStudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sproc_HallStudentsBindingSource
            // 
            this.sproc_HallStudentsBindingSource.DataMember = "sproc_HallStudents";
            this.sproc_HallStudentsBindingSource.DataSource = this.DMUBoxDataSet1;
            // 
            // DMUBoxDataSet1
            // 
            this.DMUBoxDataSet1.DataSetName = "DMUBoxDataSet1";
            this.DMUBoxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(866, 779);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tblStudent";
            this.tblStudentBindingSource.DataSource = this.DMUBoxDataSet1;
            // 
            // tblStudentTableAdapter
            // 
            this.tblStudentTableAdapter.ClearBeforeFill = true;
            // 
            // sproc_HallStudentsTableAdapter
            // 
            this.sproc_HallStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblBoxTableAdapter = null;
            this.tableAdapterManager.tblHallTableAdapter = null;
            this.tableAdapterManager.tblOrderLineTableAdapter = null;
            this.tableAdapterManager.tblOrderTableAdapter = null;
            this.tableAdapterManager.tblStudentTableAdapter = this.tblStudentTableAdapter;
            this.tableAdapterManager.UpdateOrder = DMUBox.DMUBoxDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "HallStudentDataSet";
            reportDataSource1.Value = this.sprocHallStudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DMUBox.rptHallStudents.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(69, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(823, 717);
            this.reportViewer1.TabIndex = 2;
            // 
            // dMUBoxDataSet1BindingSource
            // 
            this.dMUBoxDataSet1BindingSource.DataSource = this.DMUBoxDataSet1;
            this.dMUBoxDataSet1BindingSource.Position = 0;
            // 
            // sprocHallStudentsBindingSource
            // 
            this.sprocHallStudentsBindingSource.DataMember = "sproc_HallStudents";
            this.sprocHallStudentsBindingSource.DataSource = this.DMUBoxDataSet1;
            // 
            // frmHallStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 1046);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "frmHallStudentReport";
            this.Text = "frmHallStudentReport";
            this.Load += new System.EventHandler(this.frmHallStudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sproc_HallStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprocHallStudentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private DMUBoxDataSet1 DMUBoxDataSet1;
        private DMUBoxDataSet1TableAdapters.tblStudentTableAdapter tblStudentTableAdapter;
        private System.Windows.Forms.BindingSource sproc_HallStudentsBindingSource;
        private DMUBoxDataSet1TableAdapters.sproc_HallStudentsTableAdapter sproc_HallStudentsTableAdapter;
        private DMUBoxDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sprocHallStudentsBindingSource;
        private System.Windows.Forms.BindingSource dMUBoxDataSet1BindingSource;
    }
}