namespace DMUBox
{
    partial class frmStudent
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
            System.Windows.Forms.Label studentNoLabel1;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label foreNameLabel;
            System.Windows.Forms.Label familyNameLabel;
            System.Windows.Forms.Label apartmentNoLabel;
            System.Windows.Forms.Label hallNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.dMUBoxDataSet = new DMUBox.DMUBoxDataSet1();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentTableAdapter = new DMUBox.DMUBoxDataSet1TableAdapters.tblStudentTableAdapter();
            this.tableAdapterManager = new DMUBox.DMUBoxDataSet1TableAdapters.TableAdapterManager();
            this.tblStudentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblStudentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tblHallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHallTableAdapter = new DMUBox.DMUBoxDataSet1TableAdapters.tblHallTableAdapter();
            this.tblOrderTableAdapter = new DMUBox.DMUBoxDataSet1TableAdapters.tblOrderTableAdapter();
            this.tblOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.studentNoTextBox1 = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.foreNameTextBox = new System.Windows.Forms.TextBox();
            this.familyNameTextBox = new System.Windows.Forms.TextBox();
            this.apartmentNoTextBox = new System.Windows.Forms.TextBox();
            this.tblStudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dMUBoxDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblHallBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblHallBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            studentNoLabel1 = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            foreNameLabel = new System.Windows.Forms.Label();
            familyNameLabel = new System.Windows.Forms.Label();
            apartmentNoLabel = new System.Windows.Forms.Label();
            hallNoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingNavigator)).BeginInit();
            this.tblStudentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNoLabel1
            // 
            studentNoLabel1.AutoSize = true;
            studentNoLabel1.Location = new System.Drawing.Point(60, 75);
            studentNoLabel1.Name = "studentNoLabel1";
            studentNoLabel1.Size = new System.Drawing.Size(94, 20);
            studentNoLabel1.TabIndex = 16;
            studentNoLabel1.Text = "Student No:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(112, 108);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(42, 20);
            titleLabel.TabIndex = 17;
            titleLabel.Text = "Title:";
            // 
            // foreNameLabel
            // 
            foreNameLabel.AutoSize = true;
            foreNameLabel.Location = new System.Drawing.Point(62, 138);
            foreNameLabel.Name = "foreNameLabel";
            foreNameLabel.Size = new System.Drawing.Size(92, 20);
            foreNameLabel.TabIndex = 18;
            foreNameLabel.Text = "Fore Name:";
            // 
            // familyNameLabel
            // 
            familyNameLabel.AutoSize = true;
            familyNameLabel.Location = new System.Drawing.Point(50, 171);
            familyNameLabel.Name = "familyNameLabel";
            familyNameLabel.Size = new System.Drawing.Size(104, 20);
            familyNameLabel.TabIndex = 19;
            familyNameLabel.Text = "Family Name:";
            // 
            // apartmentNoLabel
            // 
            apartmentNoLabel.AutoSize = true;
            apartmentNoLabel.Location = new System.Drawing.Point(42, 235);
            apartmentNoLabel.Name = "apartmentNoLabel";
            apartmentNoLabel.Size = new System.Drawing.Size(112, 20);
            apartmentNoLabel.TabIndex = 21;
            apartmentNoLabel.Text = "Apartment No:";
            // 
            // hallNoLabel
            // 
            hallNoLabel.AutoSize = true;
            hallNoLabel.Location = new System.Drawing.Point(112, 206);
            hallNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            hallNoLabel.Name = "hallNoLabel";
            hallNoLabel.Size = new System.Drawing.Size(40, 20);
            hallNoLabel.TabIndex = 22;
            hallNoLabel.Text = "Hall:";
            // 
            // dMUBoxDataSet
            // 
            this.dMUBoxDataSet.DataSetName = "DMUBoxDataSet";
            this.dMUBoxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentBindingSource
            // 
            this.tblStudentBindingSource.DataMember = "tblStudent";
            this.tblStudentBindingSource.DataSource = this.dMUBoxDataSet;
            // 
            // tblStudentTableAdapter
            // 
            this.tblStudentTableAdapter.ClearBeforeFill = true;
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
            // tblStudentBindingNavigator
            // 
            this.tblStudentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblStudentBindingNavigator.BindingSource = this.tblStudentBindingSource;
            this.tblStudentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblStudentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblStudentBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tblStudentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblStudentBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.tblStudentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblStudentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblStudentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblStudentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblStudentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblStudentBindingNavigator.Name = "tblStudentBindingNavigator";
            this.tblStudentBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tblStudentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblStudentBindingNavigator.Size = new System.Drawing.Size(951, 31);
            this.tblStudentBindingNavigator.TabIndex = 0;
            this.tblStudentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // tblStudentBindingNavigatorSaveItem
            // 
            this.tblStudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblStudentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblStudentBindingNavigatorSaveItem.Image")));
            this.tblStudentBindingNavigatorSaveItem.Name = "tblStudentBindingNavigatorSaveItem";
            this.tblStudentBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.tblStudentBindingNavigatorSaveItem.Text = "Save Data";
            this.tblStudentBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblStudentBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(28, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tblHallBindingSource
            // 
            this.tblHallBindingSource.DataMember = "tblHall";
            this.tblHallBindingSource.DataSource = this.dMUBoxDataSet;
            // 
            // tblHallTableAdapter
            // 
            this.tblHallTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrderTableAdapter
            // 
            this.tblOrderTableAdapter.ClearBeforeFill = true;
            // 
            // tblOrderDataGridView
            // 
            this.tblOrderDataGridView.AutoGenerateColumns = false;
            this.tblOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.tblOrderDataGridView.DataSource = this.tblOrderBindingSource;
            this.tblOrderDataGridView.Location = new System.Drawing.Point(394, 49);
            this.tblOrderDataGridView.Name = "tblOrderDataGridView";
            this.tblOrderDataGridView.RowTemplate.Height = 28;
            this.tblOrderDataGridView.Size = new System.Drawing.Size(526, 220);
            this.tblOrderDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DeliveryDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "DeliveryDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tblOrderBindingSource
            // 
            this.tblOrderBindingSource.DataMember = "FK_tblOrder_tblStudents";
            this.tblOrderBindingSource.DataSource = this.tblStudentBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentNoTextBox1
            // 
            this.studentNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "StudentNo", true));
            this.studentNoTextBox1.Location = new System.Drawing.Point(160, 72);
            this.studentNoTextBox1.Name = "studentNoTextBox1";
            this.studentNoTextBox1.Size = new System.Drawing.Size(100, 26);
            this.studentNoTextBox1.TabIndex = 17;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(160, 105);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 26);
            this.titleTextBox.TabIndex = 18;
            // 
            // foreNameTextBox
            // 
            this.foreNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "ForeName", true));
            this.foreNameTextBox.Location = new System.Drawing.Point(160, 135);
            this.foreNameTextBox.Name = "foreNameTextBox";
            this.foreNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.foreNameTextBox.TabIndex = 19;
            // 
            // familyNameTextBox
            // 
            this.familyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "FamilyName", true));
            this.familyNameTextBox.Location = new System.Drawing.Point(160, 168);
            this.familyNameTextBox.Name = "familyNameTextBox";
            this.familyNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.familyNameTextBox.TabIndex = 20;
            // 
            // apartmentNoTextBox
            // 
            this.apartmentNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblStudentBindingSource, "ApartmentNo", true));
            this.apartmentNoTextBox.Location = new System.Drawing.Point(160, 232);
            this.apartmentNoTextBox.Name = "apartmentNoTextBox";
            this.apartmentNoTextBox.Size = new System.Drawing.Size(100, 26);
            this.apartmentNoTextBox.TabIndex = 22;
            // 
            // tblStudentBindingSource1
            // 
            this.tblStudentBindingSource1.DataMember = "tblStudent";
            this.tblStudentBindingSource1.DataSource = this.dMUBoxDataSet;
            // 
            // dMUBoxDataSetBindingSource
            // 
            this.dMUBoxDataSetBindingSource.DataSource = this.dMUBoxDataSet;
            this.dMUBoxDataSetBindingSource.Position = 0;
            // 
            // tblStudentBindingSource2
            // 
            this.tblStudentBindingSource2.DataMember = "tblStudent";
            this.tblStudentBindingSource2.DataSource = this.dMUBoxDataSet;
            // 
            // tblStudentBindingSource3
            // 
            this.tblStudentBindingSource3.DataMember = "tblStudent";
            this.tblStudentBindingSource3.DataSource = this.dMUBoxDataSet;
            // 
            // tblHallBindingSource1
            // 
            this.tblHallBindingSource1.DataMember = "tblHall";
            this.tblHallBindingSource1.DataSource = this.dMUBoxDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblStudentBindingSource, "HallNo", true));
            this.comboBox1.DataSource = this.tblHallBindingSource2;
            this.comboBox1.DisplayMember = "HallName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 203);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "HallNo";
            // 
            // tblHallBindingSource2
            // 
            this.tblHallBindingSource2.DataMember = "tblHall";
            this.tblHallBindingSource2.DataSource = this.dMUBoxDataSet;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 492);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(hallNoLabel);
            this.Controls.Add(apartmentNoLabel);
            this.Controls.Add(this.apartmentNoTextBox);
            this.Controls.Add(familyNameLabel);
            this.Controls.Add(this.familyNameTextBox);
            this.Controls.Add(foreNameLabel);
            this.Controls.Add(this.foreNameTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(studentNoLabel1);
            this.Controls.Add(this.studentNoTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tblOrderDataGridView);
            this.Controls.Add(this.tblStudentBindingNavigator);
            this.Name = "frmStudent";
            this.Text = "frmStudent";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingNavigator)).EndInit();
            this.tblStudentBindingNavigator.ResumeLayout(false);
            this.tblStudentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMUBoxDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHallBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMUBoxDataSet1 dMUBoxDataSet;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private DMUBoxDataSet1TableAdapters.tblStudentTableAdapter tblStudentTableAdapter;
        private DMUBoxDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblStudentBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblStudentBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource tblHallBindingSource;
        private DMUBoxDataSet1TableAdapters.tblHallTableAdapter tblHallTableAdapter;
        private System.Windows.Forms.BindingSource tblOrderBindingSource;
        private DMUBoxDataSet1TableAdapters.tblOrderTableAdapter tblOrderTableAdapter;
        private System.Windows.Forms.DataGridView tblOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox studentNoTextBox1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox foreNameTextBox;
        private System.Windows.Forms.TextBox familyNameTextBox;
        private System.Windows.Forms.TextBox apartmentNoTextBox;
        private System.Windows.Forms.BindingSource tblStudentBindingSource1;
        private System.Windows.Forms.BindingSource tblStudentBindingSource2;
        private System.Windows.Forms.BindingSource tblStudentBindingSource3;
        private System.Windows.Forms.BindingSource dMUBoxDataSetBindingSource;
        private System.Windows.Forms.BindingSource tblHallBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tblHallBindingSource2;
    }
}