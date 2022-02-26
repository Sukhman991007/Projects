namespace DMUBox
{
    partial class frmStudentReport
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
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblStudentTableAdapter = new DMUBox.DMUBoxDataSet1TableAdapters.tblStudentTableAdapter();
            this.sproc_HallStudentsTableAdapter = new DMUBox.DMUBoxDataSet1TableAdapters.sproc_HallStudentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_HallStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
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
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tblStudent";
            this.tblStudentBindingSource.DataSource = this.DMUBoxDataSet1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 711);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DMUBoxDataSet";
            reportDataSource1.Value = this.tblStudentBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "DMUBox.rptStudents.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(794, 615);
            this.reportViewer2.TabIndex = 2;
            // 
            // tblStudentTableAdapter
            // 
            this.tblStudentTableAdapter.ClearBeforeFill = true;
            // 
            // sproc_HallStudentsTableAdapter
            // 
            this.sproc_HallStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // frmStudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 901);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.button1);
            this.Name = "frmStudentReport";
            this.Text = "frmStudentReport";
            this.Load += new System.EventHandler(this.frmStudentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sproc_HallStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private DMUBoxDataSet1 DMUBoxDataSet1;
        private DMUBoxDataSet1TableAdapters.tblStudentTableAdapter tblStudentTableAdapter;
        private System.Windows.Forms.BindingSource sproc_HallStudentsBindingSource;
        private DMUBoxDataSet1TableAdapters.sproc_HallStudentsTableAdapter sproc_HallStudentsTableAdapter;
    }
}