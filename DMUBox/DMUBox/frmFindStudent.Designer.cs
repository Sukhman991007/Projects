namespace DMUBox
{
    partial class frmFindStudent
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
            System.Windows.Forms.Label titleLabel1;
            System.Windows.Forms.Label foreNameLabel1;
            System.Windows.Forms.Label familyNameLabel1;
            System.Windows.Forms.Label hallNoLabel1;
            System.Windows.Forms.Label apartmentNoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindStudent));
            this.DMUBoxDataSet1 = new DMUBox.DMUBoxDataSet1();
            this.sporc_tblStudent_FilterbyStudentNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sporc_tblStudent_FilterbyStudentNoTableAdapter = new DMUBox.DMUBoxDataSet1TableAdapters.sporc_tblStudent_FilterbyStudentNoTableAdapter();
            this.tableAdapterManager = new DMUBox.DMUBoxDataSet1TableAdapters.TableAdapterManager();
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.studentNoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.studentNoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tblStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentTableAdapter = new DMUBox.DMUBoxDataSet1TableAdapters.tblStudentTableAdapter();
            this.studentNoTextBox1 = new System.Windows.Forms.TextBox();
            this.titleTextBox1 = new System.Windows.Forms.TextBox();
            this.foreNameTextBox1 = new System.Windows.Forms.TextBox();
            this.familyNameTextBox1 = new System.Windows.Forms.TextBox();
            this.hallNoTextBox1 = new System.Windows.Forms.TextBox();
            this.apartmentNoTextBox1 = new System.Windows.Forms.TextBox();
            studentNoLabel1 = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            foreNameLabel1 = new System.Windows.Forms.Label();
            familyNameLabel1 = new System.Windows.Forms.Label();
            hallNoLabel1 = new System.Windows.Forms.Label();
            apartmentNoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporc_tblStudent_FilterbyStudentNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporc_tblStudent_FilterbyStudentNoBindingNavigator)).BeginInit();
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNoLabel1
            // 
            studentNoLabel1.AutoSize = true;
            studentNoLabel1.Location = new System.Drawing.Point(19, 107);
            studentNoLabel1.Name = "studentNoLabel1";
            studentNoLabel1.Size = new System.Drawing.Size(94, 20);
            studentNoLabel1.TabIndex = 16;
            studentNoLabel1.Text = "Student No:";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(71, 139);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(42, 20);
            titleLabel1.TabIndex = 17;
            titleLabel1.Text = "Title:";
            // 
            // foreNameLabel1
            // 
            foreNameLabel1.AutoSize = true;
            foreNameLabel1.Location = new System.Drawing.Point(21, 171);
            foreNameLabel1.Name = "foreNameLabel1";
            foreNameLabel1.Size = new System.Drawing.Size(92, 20);
            foreNameLabel1.TabIndex = 19;
            foreNameLabel1.Text = "Fore Name:";
            // 
            // familyNameLabel1
            // 
            familyNameLabel1.AutoSize = true;
            familyNameLabel1.Location = new System.Drawing.Point(9, 203);
            familyNameLabel1.Name = "familyNameLabel1";
            familyNameLabel1.Size = new System.Drawing.Size(104, 20);
            familyNameLabel1.TabIndex = 21;
            familyNameLabel1.Text = "Family Name:";
            // 
            // hallNoLabel1
            // 
            hallNoLabel1.AutoSize = true;
            hallNoLabel1.Location = new System.Drawing.Point(71, 238);
            hallNoLabel1.Name = "hallNoLabel1";
            hallNoLabel1.Size = new System.Drawing.Size(40, 20);
            hallNoLabel1.TabIndex = 23;
            hallNoLabel1.Text = "Hall:";
            // 
            // apartmentNoLabel1
            // 
            apartmentNoLabel1.AutoSize = true;
            apartmentNoLabel1.Location = new System.Drawing.Point(1, 267);
            apartmentNoLabel1.Name = "apartmentNoLabel1";
            apartmentNoLabel1.Size = new System.Drawing.Size(112, 20);
            apartmentNoLabel1.TabIndex = 25;
            apartmentNoLabel1.Text = "Apartment No:";
            // 
            // DMUBoxDataSet1
            // 
            this.DMUBoxDataSet1.DataSetName = "DMUBoxDataSet1";
            this.DMUBoxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sporc_tblStudent_FilterbyStudentNoBindingSource
            // 
            this.sporc_tblStudent_FilterbyStudentNoBindingSource.DataMember = "sporc_tblStudent_FilterbyStudentNo";
            this.sporc_tblStudent_FilterbyStudentNoBindingSource.DataSource = this.DMUBoxDataSet1;
            // 
            // sporc_tblStudent_FilterbyStudentNoTableAdapter
            // 
            this.sporc_tblStudent_FilterbyStudentNoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tblBoxTableAdapter = null;
            this.tableAdapterManager.tblHallTableAdapter = null;
            this.tableAdapterManager.tblOrderLineTableAdapter = null;
            this.tableAdapterManager.tblOrderTableAdapter = null;
            this.tableAdapterManager.tblStudentTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DMUBox.DMUBoxDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sporc_tblStudent_FilterbyStudentNoBindingNavigator
            // 
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.BindingSource = this.sporc_tblStudent_FilterbyStudentNoBindingSource;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem});
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.Name = "sporc_tblStudent_FilterbyStudentNoBindingNavigator";
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.Size = new System.Drawing.Size(889, 31);
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.TabIndex = 0;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.Text = "bindingNavigator1";
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
            // sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem
            // 
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem.Enabled = false;
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem.Image")));
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem.Name = "sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem";
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentNoToolStripLabel,
            this.studentNoToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 31);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(889, 32);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // studentNoToolStripLabel
            // 
            this.studentNoToolStripLabel.Name = "studentNoToolStripLabel";
            this.studentNoToolStripLabel.Size = new System.Drawing.Size(101, 29);
            this.studentNoToolStripLabel.Text = "StudentNo:";
            // 
            // studentNoToolStripTextBox
            // 
            this.studentNoToolStripTextBox.Name = "studentNoToolStripTextBox";
            this.studentNoToolStripTextBox.Size = new System.Drawing.Size(100, 32);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(37, 29);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 63);
            this.button1.TabIndex = 14;
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
            // studentNoTextBox1
            // 
            this.studentNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sporc_tblStudent_FilterbyStudentNoBindingSource, "StudentNo", true));
            this.studentNoTextBox1.Location = new System.Drawing.Point(119, 104);
            this.studentNoTextBox1.Name = "studentNoTextBox1";
            this.studentNoTextBox1.Size = new System.Drawing.Size(100, 26);
            this.studentNoTextBox1.TabIndex = 17;
            // 
            // titleTextBox1
            // 
            this.titleTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sporc_tblStudent_FilterbyStudentNoBindingSource, "Title", true));
            this.titleTextBox1.Location = new System.Drawing.Point(119, 136);
            this.titleTextBox1.Name = "titleTextBox1";
            this.titleTextBox1.Size = new System.Drawing.Size(100, 26);
            this.titleTextBox1.TabIndex = 18;
            // 
            // foreNameTextBox1
            // 
            this.foreNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sporc_tblStudent_FilterbyStudentNoBindingSource, "ForeName", true));
            this.foreNameTextBox1.Location = new System.Drawing.Point(119, 168);
            this.foreNameTextBox1.Name = "foreNameTextBox1";
            this.foreNameTextBox1.Size = new System.Drawing.Size(100, 26);
            this.foreNameTextBox1.TabIndex = 20;
            // 
            // familyNameTextBox1
            // 
            this.familyNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sporc_tblStudent_FilterbyStudentNoBindingSource, "FamilyName", true));
            this.familyNameTextBox1.Location = new System.Drawing.Point(119, 200);
            this.familyNameTextBox1.Name = "familyNameTextBox1";
            this.familyNameTextBox1.Size = new System.Drawing.Size(100, 26);
            this.familyNameTextBox1.TabIndex = 22;
            // 
            // hallNoTextBox1
            // 
            this.hallNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sporc_tblStudent_FilterbyStudentNoBindingSource, "HallNo", true));
            this.hallNoTextBox1.Location = new System.Drawing.Point(119, 232);
            this.hallNoTextBox1.Name = "hallNoTextBox1";
            this.hallNoTextBox1.Size = new System.Drawing.Size(100, 26);
            this.hallNoTextBox1.TabIndex = 24;
            // 
            // apartmentNoTextBox1
            // 
            this.apartmentNoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sporc_tblStudent_FilterbyStudentNoBindingSource, "ApartmentNo", true));
            this.apartmentNoTextBox1.Location = new System.Drawing.Point(119, 264);
            this.apartmentNoTextBox1.Name = "apartmentNoTextBox1";
            this.apartmentNoTextBox1.Size = new System.Drawing.Size(100, 26);
            this.apartmentNoTextBox1.TabIndex = 26;
            // 
            // frmFindStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 464);
            this.Controls.Add(apartmentNoLabel1);
            this.Controls.Add(this.apartmentNoTextBox1);
            this.Controls.Add(hallNoLabel1);
            this.Controls.Add(this.hallNoTextBox1);
            this.Controls.Add(familyNameLabel1);
            this.Controls.Add(this.familyNameTextBox1);
            this.Controls.Add(foreNameLabel1);
            this.Controls.Add(this.foreNameTextBox1);
            this.Controls.Add(titleLabel1);
            this.Controls.Add(this.titleTextBox1);
            this.Controls.Add(studentNoLabel1);
            this.Controls.Add(this.studentNoTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.sporc_tblStudent_FilterbyStudentNoBindingNavigator);
            this.Name = "frmFindStudent";
            this.Text = "frmFindStudent";
            this.Load += new System.EventHandler(this.frmFindStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DMUBoxDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporc_tblStudent_FilterbyStudentNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sporc_tblStudent_FilterbyStudentNoBindingNavigator)).EndInit();
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.ResumeLayout(false);
            this.sporc_tblStudent_FilterbyStudentNoBindingNavigator.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMUBoxDataSet1 DMUBoxDataSet1;
        private System.Windows.Forms.BindingSource sporc_tblStudent_FilterbyStudentNoBindingSource;
        private DMUBoxDataSet1TableAdapters.sporc_tblStudent_FilterbyStudentNoTableAdapter sporc_tblStudent_FilterbyStudentNoTableAdapter;
        private DMUBoxDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sporc_tblStudent_FilterbyStudentNoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sporc_tblStudent_FilterbyStudentNoBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel studentNoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox studentNoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tblStudentBindingSource;
        private DMUBoxDataSet1TableAdapters.tblStudentTableAdapter tblStudentTableAdapter;
        private System.Windows.Forms.TextBox studentNoTextBox1;
        private System.Windows.Forms.TextBox titleTextBox1;
        private System.Windows.Forms.TextBox foreNameTextBox1;
        private System.Windows.Forms.TextBox familyNameTextBox1;
        private System.Windows.Forms.TextBox hallNoTextBox1;
        private System.Windows.Forms.TextBox apartmentNoTextBox1;
    }
}
