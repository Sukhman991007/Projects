namespace CBDS
{
    partial class F4_frmR1
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
            this.sproc_R1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sukhman_Lidder_ConsultantsdBDataSet = new CBDS.Sukhman_Lidder_ConsultantsdBDataSet();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sproc_R1TableAdapter = new CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.sproc_R1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_R1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sukhman_Lidder_ConsultantsdBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sproc_R1BindingSource
            // 
            this.sproc_R1BindingSource.DataMember = "sproc_R1";
            this.sproc_R1BindingSource.DataSource = this.Sukhman_Lidder_ConsultantsdBDataSet;
            // 
            // Sukhman_Lidder_ConsultantsdBDataSet
            // 
            this.Sukhman_Lidder_ConsultantsdBDataSet.DataSetName = "Sukhman_Lidder_ConsultantsdBDataSet";
            this.Sukhman_Lidder_ConsultantsdBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(240)))));
            this.btnRefresh.Location = new System.Drawing.Point(787, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 63);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "End date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Start date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(504, 40);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 26);
            this.dtpEndDate.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(137, 42);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 26);
            this.dtpStartDate.TabIndex = 11;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sproc_R1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CBDS.R1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(21, 95);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1792, 800);
            this.reportViewer1.TabIndex = 16;
            // 
            // sproc_R1TableAdapter
            // 
            this.sproc_R1TableAdapter.ClearBeforeFill = true;
            // 
            // F4_frmR1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "F4_frmR1";
            this.Text = "frmR1";
            this.Load += new System.EventHandler(this.frmR1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sproc_R1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sukhman_Lidder_ConsultantsdBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sproc_R1BindingSource;
        private Sukhman_Lidder_ConsultantsdBDataSet Sukhman_Lidder_ConsultantsdBDataSet;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.sproc_R1TableAdapter sproc_R1TableAdapter;
    }
}