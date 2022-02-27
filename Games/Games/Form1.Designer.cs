
namespace Games
{
    partial class Form1
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
            this.txtGame = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lblCurrentGame = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnFindNewest = new System.Windows.Forms.Button();
            this.btnFindOldest = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGame
            // 
            this.txtGame.Location = new System.Drawing.Point(76, 60);
            this.txtGame.Multiline = true;
            this.txtGame.Name = "txtGame";
            this.txtGame.Size = new System.Drawing.Size(491, 342);
            this.txtGame.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(420, 408);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(147, 52);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(76, 408);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(147, 52);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblCurrentGame
            // 
            this.lblCurrentGame.AutoSize = true;
            this.lblCurrentGame.Location = new System.Drawing.Point(106, 26);
            this.lblCurrentGame.Name = "lblCurrentGame";
            this.lblCurrentGame.Size = new System.Drawing.Size(0, 20);
            this.lblCurrentGame.TabIndex = 5;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(615, 176);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(147, 52);
            this.btnSort.TabIndex = 20;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnFindNewest
            // 
            this.btnFindNewest.Location = new System.Drawing.Point(615, 118);
            this.btnFindNewest.Name = "btnFindNewest";
            this.btnFindNewest.Size = new System.Drawing.Size(147, 52);
            this.btnFindNewest.TabIndex = 19;
            this.btnFindNewest.Text = "Find Newest";
            this.btnFindNewest.UseVisualStyleBackColor = true;
            this.btnFindNewest.Click += new System.EventHandler(this.btnFindNewest_Click);
            // 
            // btnFindOldest
            // 
            this.btnFindOldest.Location = new System.Drawing.Point(615, 60);
            this.btnFindOldest.Name = "btnFindOldest";
            this.btnFindOldest.Size = new System.Drawing.Size(147, 52);
            this.btnFindOldest.TabIndex = 18;
            this.btnFindOldest.Text = "Find oldest";
            this.btnFindOldest.UseVisualStyleBackColor = true;
            this.btnFindOldest.Click += new System.EventHandler(this.btnFindOldest_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(615, 234);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(147, 52);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(615, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 52);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(615, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(147, 52);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(615, 408);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(147, 52);
            this.btnAddGame.TabIndex = 24;
            this.btnAddGame.Text = "Add game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnFindNewest);
            this.Controls.Add(this.btnFindOldest);
            this.Controls.Add(this.lblCurrentGame);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGame;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblCurrentGame;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnFindNewest;
        private System.Windows.Forms.Button btnFindOldest;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddGame;
    }
}

