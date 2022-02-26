namespace CBDS
{
    partial class frmMedicalGroupEntry
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
            System.Windows.Forms.Label ssl_MedicalGroupCodeLabel;
            System.Windows.Forms.Label ssl_NameLabel;
            System.Windows.Forms.Label ssl_AddressLabel;
            System.Windows.Forms.Label ssl_TelLabel;
            System.Windows.Forms.Label ssl_TownLabel;
            System.Windows.Forms.Label ssl_PostcodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMedicalGroupEntry));
            this.sukhman_Lidder_ConsultantsdBDataSet = new CBDS.Sukhman_Lidder_ConsultantsdBDataSet();
            this.p2428097_tblMedicalGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p2428097_tblMedicalGroupTableAdapter = new CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.P2428097_tblMedicalGroupTableAdapter();
            this.tableAdapterManager = new CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.TableAdapterManager();
            this.p2428097_tblMedicalGroupBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.p2428097_tblMedicalGroupBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ssl_MedicalGroupCodeTextBox = new System.Windows.Forms.TextBox();
            this.ssl_NameTextBox = new System.Windows.Forms.TextBox();
            this.ssl_AddressTextBox = new System.Windows.Forms.TextBox();
            this.ssl_TelTextBox = new System.Windows.Forms.TextBox();
            this.ssl_TownTextBox = new System.Windows.Forms.TextBox();
            this.ssl_PostcodeTextBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ssl_MedicalGroupCodeLabel = new System.Windows.Forms.Label();
            ssl_NameLabel = new System.Windows.Forms.Label();
            ssl_AddressLabel = new System.Windows.Forms.Label();
            ssl_TelLabel = new System.Windows.Forms.Label();
            ssl_TownLabel = new System.Windows.Forms.Label();
            ssl_PostcodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sukhman_Lidder_ConsultantsdBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2428097_tblMedicalGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2428097_tblMedicalGroupBindingNavigator)).BeginInit();
            this.p2428097_tblMedicalGroupBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ssl_MedicalGroupCodeLabel
            // 
            ssl_MedicalGroupCodeLabel.AutoSize = true;
            ssl_MedicalGroupCodeLabel.Location = new System.Drawing.Point(36, 155);
            ssl_MedicalGroupCodeLabel.Name = "ssl_MedicalGroupCodeLabel";
            ssl_MedicalGroupCodeLabel.Size = new System.Drawing.Size(158, 20);
            ssl_MedicalGroupCodeLabel.TabIndex = 1;
            ssl_MedicalGroupCodeLabel.Text = "Medical Group Code:";
            // 
            // ssl_NameLabel
            // 
            ssl_NameLabel.AutoSize = true;
            ssl_NameLabel.Location = new System.Drawing.Point(139, 187);
            ssl_NameLabel.Name = "ssl_NameLabel";
            ssl_NameLabel.Size = new System.Drawing.Size(55, 20);
            ssl_NameLabel.TabIndex = 3;
            ssl_NameLabel.Text = "Name:";
            // 
            // ssl_AddressLabel
            // 
            ssl_AddressLabel.AutoSize = true;
            ssl_AddressLabel.Location = new System.Drawing.Point(122, 251);
            ssl_AddressLabel.Name = "ssl_AddressLabel";
            ssl_AddressLabel.Size = new System.Drawing.Size(72, 20);
            ssl_AddressLabel.TabIndex = 5;
            ssl_AddressLabel.Text = "Address:";
            // 
            // ssl_TelLabel
            // 
            ssl_TelLabel.AutoSize = true;
            ssl_TelLabel.Location = new System.Drawing.Point(48, 219);
            ssl_TelLabel.Name = "ssl_TelLabel";
            ssl_TelLabel.Size = new System.Drawing.Size(146, 20);
            ssl_TelLabel.TabIndex = 7;
            ssl_TelLabel.Text = "Telephone number:";
            // 
            // ssl_TownLabel
            // 
            ssl_TownLabel.AutoSize = true;
            ssl_TownLabel.Location = new System.Drawing.Point(143, 283);
            ssl_TownLabel.Name = "ssl_TownLabel";
            ssl_TownLabel.Size = new System.Drawing.Size(51, 20);
            ssl_TownLabel.TabIndex = 9;
            ssl_TownLabel.Text = "Town:";
            // 
            // ssl_PostcodeLabel
            // 
            ssl_PostcodeLabel.AutoSize = true;
            ssl_PostcodeLabel.Location = new System.Drawing.Point(114, 315);
            ssl_PostcodeLabel.Name = "ssl_PostcodeLabel";
            ssl_PostcodeLabel.Size = new System.Drawing.Size(80, 20);
            ssl_PostcodeLabel.TabIndex = 11;
            ssl_PostcodeLabel.Text = "Postcode:";
            // 
            // sukhman_Lidder_ConsultantsdBDataSet
            // 
            this.sukhman_Lidder_ConsultantsdBDataSet.DataSetName = "Sukhman_Lidder_ConsultantsdBDataSet";
            this.sukhman_Lidder_ConsultantsdBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p2428097_tblMedicalGroupBindingSource
            // 
            this.p2428097_tblMedicalGroupBindingSource.DataMember = "P2428097_tblMedicalGroup";
            this.p2428097_tblMedicalGroupBindingSource.DataSource = this.sukhman_Lidder_ConsultantsdBDataSet;
            // 
            // p2428097_tblMedicalGroupTableAdapter
            // 
            this.p2428097_tblMedicalGroupTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.P2428097_tblAppointmentTableAdapter = null;
            this.tableAdapterManager.P2428097_tblConsultantTableAdapter = null;
            this.tableAdapterManager.P2428097_tblGPTableAdapter = null;
            this.tableAdapterManager.P2428097_tblHospitalTableAdapter = null;
            this.tableAdapterManager.P2428097_tblMedicalCentreTableAdapter = null;
            this.tableAdapterManager.P2428097_tblMedicalGroupTableAdapter = this.p2428097_tblMedicalGroupTableAdapter;
            this.tableAdapterManager.P2428097_tblPatientTableAdapter = null;
            this.tableAdapterManager.P2428097_tblPracticeGPTableAdapter = null;
            this.tableAdapterManager.P2428097_tblSpecialityTableAdapter = null;
            this.tableAdapterManager.P2428097_tblStaffTableAdapter = null;
            this.tableAdapterManager.P2428097_tblTitleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CBDS.Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // p2428097_tblMedicalGroupBindingNavigator
            // 
            this.p2428097_tblMedicalGroupBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.p2428097_tblMedicalGroupBindingNavigator.BindingSource = this.p2428097_tblMedicalGroupBindingSource;
            this.p2428097_tblMedicalGroupBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.p2428097_tblMedicalGroupBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.p2428097_tblMedicalGroupBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.p2428097_tblMedicalGroupBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.p2428097_tblMedicalGroupBindingNavigatorSaveItem});
            this.p2428097_tblMedicalGroupBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.p2428097_tblMedicalGroupBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.p2428097_tblMedicalGroupBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.p2428097_tblMedicalGroupBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.p2428097_tblMedicalGroupBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.p2428097_tblMedicalGroupBindingNavigator.Name = "p2428097_tblMedicalGroupBindingNavigator";
            this.p2428097_tblMedicalGroupBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.p2428097_tblMedicalGroupBindingNavigator.Size = new System.Drawing.Size(653, 31);
            this.p2428097_tblMedicalGroupBindingNavigator.TabIndex = 0;
            this.p2428097_tblMedicalGroupBindingNavigator.Text = "bindingNavigator1";
            this.p2428097_tblMedicalGroupBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // p2428097_tblMedicalGroupBindingNavigatorSaveItem
            // 
            this.p2428097_tblMedicalGroupBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.p2428097_tblMedicalGroupBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("p2428097_tblMedicalGroupBindingNavigatorSaveItem.Image")));
            this.p2428097_tblMedicalGroupBindingNavigatorSaveItem.Name = "p2428097_tblMedicalGroupBindingNavigatorSaveItem";
            this.p2428097_tblMedicalGroupBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.p2428097_tblMedicalGroupBindingNavigatorSaveItem.Text = "Save Data";
            this.p2428097_tblMedicalGroupBindingNavigatorSaveItem.Click += new System.EventHandler(this.p2428097_tblMedicalGroupBindingNavigatorSaveItem_Click);
            // 
            // ssl_MedicalGroupCodeTextBox
            // 
            this.ssl_MedicalGroupCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2428097_tblMedicalGroupBindingSource, "ssl_MedicalGroupCode", true));
            this.ssl_MedicalGroupCodeTextBox.Location = new System.Drawing.Point(200, 152);
            this.ssl_MedicalGroupCodeTextBox.Name = "ssl_MedicalGroupCodeTextBox";
            this.ssl_MedicalGroupCodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.ssl_MedicalGroupCodeTextBox.TabIndex = 2;
            // 
            // ssl_NameTextBox
            // 
            this.ssl_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2428097_tblMedicalGroupBindingSource, "ssl_Name", true));
            this.ssl_NameTextBox.Location = new System.Drawing.Point(200, 184);
            this.ssl_NameTextBox.Name = "ssl_NameTextBox";
            this.ssl_NameTextBox.Size = new System.Drawing.Size(100, 26);
            this.ssl_NameTextBox.TabIndex = 4;
            // 
            // ssl_AddressTextBox
            // 
            this.ssl_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2428097_tblMedicalGroupBindingSource, "ssl_Address", true));
            this.ssl_AddressTextBox.Location = new System.Drawing.Point(200, 248);
            this.ssl_AddressTextBox.Name = "ssl_AddressTextBox";
            this.ssl_AddressTextBox.Size = new System.Drawing.Size(100, 26);
            this.ssl_AddressTextBox.TabIndex = 6;
            // 
            // ssl_TelTextBox
            // 
            this.ssl_TelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2428097_tblMedicalGroupBindingSource, "ssl_Tel", true));
            this.ssl_TelTextBox.Location = new System.Drawing.Point(200, 216);
            this.ssl_TelTextBox.Name = "ssl_TelTextBox";
            this.ssl_TelTextBox.Size = new System.Drawing.Size(100, 26);
            this.ssl_TelTextBox.TabIndex = 8;
            // 
            // ssl_TownTextBox
            // 
            this.ssl_TownTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2428097_tblMedicalGroupBindingSource, "ssl_Town", true));
            this.ssl_TownTextBox.Location = new System.Drawing.Point(200, 280);
            this.ssl_TownTextBox.Name = "ssl_TownTextBox";
            this.ssl_TownTextBox.Size = new System.Drawing.Size(100, 26);
            this.ssl_TownTextBox.TabIndex = 10;
            // 
            // ssl_PostcodeTextBox
            // 
            this.ssl_PostcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.p2428097_tblMedicalGroupBindingSource, "ssl_Postcode", true));
            this.ssl_PostcodeTextBox.Location = new System.Drawing.Point(200, 312);
            this.ssl_PostcodeTextBox.Name = "ssl_PostcodeTextBox";
            this.ssl_PostcodeTextBox.Size = new System.Drawing.Size(100, 26);
            this.ssl_PostcodeTextBox.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Location = new System.Drawing.Point(362, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 62);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Lime;
            this.btnClose.Location = new System.Drawing.Point(484, 381);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 62);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(412, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 46);
            this.label1.TabIndex = 63;
            this.label1.Text = "Medical Group details entry";
            // 
            // frmMedicalGroupEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 468);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(ssl_PostcodeLabel);
            this.Controls.Add(this.ssl_PostcodeTextBox);
            this.Controls.Add(ssl_TownLabel);
            this.Controls.Add(this.ssl_TownTextBox);
            this.Controls.Add(ssl_TelLabel);
            this.Controls.Add(this.ssl_TelTextBox);
            this.Controls.Add(ssl_AddressLabel);
            this.Controls.Add(this.ssl_AddressTextBox);
            this.Controls.Add(ssl_NameLabel);
            this.Controls.Add(this.ssl_NameTextBox);
            this.Controls.Add(ssl_MedicalGroupCodeLabel);
            this.Controls.Add(this.ssl_MedicalGroupCodeTextBox);
            this.Controls.Add(this.p2428097_tblMedicalGroupBindingNavigator);
            this.Name = "frmMedicalGroupEntry";
            this.Text = "frmMedicalGroupEntry";
            this.Load += new System.EventHandler(this.frmMedicalGroupEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sukhman_Lidder_ConsultantsdBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2428097_tblMedicalGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2428097_tblMedicalGroupBindingNavigator)).EndInit();
            this.p2428097_tblMedicalGroupBindingNavigator.ResumeLayout(false);
            this.p2428097_tblMedicalGroupBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sukhman_Lidder_ConsultantsdBDataSet sukhman_Lidder_ConsultantsdBDataSet;
        private System.Windows.Forms.BindingSource p2428097_tblMedicalGroupBindingSource;
        private Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.P2428097_tblMedicalGroupTableAdapter p2428097_tblMedicalGroupTableAdapter;
        private Sukhman_Lidder_ConsultantsdBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator p2428097_tblMedicalGroupBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton p2428097_tblMedicalGroupBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ssl_MedicalGroupCodeTextBox;
        private System.Windows.Forms.TextBox ssl_NameTextBox;
        private System.Windows.Forms.TextBox ssl_AddressTextBox;
        private System.Windows.Forms.TextBox ssl_TelTextBox;
        private System.Windows.Forms.TextBox ssl_TownTextBox;
        private System.Windows.Forms.TextBox ssl_PostcodeTextBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}