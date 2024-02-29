namespace ChoreAssigner
{
    partial class Tasker
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
            this.label1 = new System.Windows.Forms.Label();
            this.dGVDaily = new System.Windows.Forms.DataGridView();
            this.dGV_ToDo = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDailyMoveSelected = new System.Windows.Forms.Button();
            this.btnDailyMoveAll = new System.Windows.Forms.Button();
            this.btnSpecialCircumstance = new System.Windows.Forms.Button();
            this.btnToDoDeleteSelected = new System.Windows.Forms.Button();
            this.btnToDoDeleteAll = new System.Windows.Forms.Button();
            this.btnSelectChildren = new System.Windows.Forms.Button();
            this.btnReviewRewards = new System.Windows.Forms.Button();
            this.richTextBoxSpecialCircumstance = new System.Windows.Forms.RichTextBox();
            this.dGVOtherChores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnMoveSelectedOther = new System.Windows.Forms.Button();
            this.BtnMoveAllOther = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOtherChores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Routine-Daily";
            // 
            // dGVDaily
            // 
            this.dGVDaily.AllowUserToOrderColumns = true;
            this.dGVDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGVDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDaily.Location = new System.Drawing.Point(27, 68);
            this.dGVDaily.Name = "dGVDaily";
            this.dGVDaily.Size = new System.Drawing.Size(328, 315);
            this.dGVDaily.TabIndex = 4;
            // 
            // dGV_ToDo
            // 
            this.dGV_ToDo.AllowUserToOrderColumns = true;
            this.dGV_ToDo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_ToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ToDo.Location = new System.Drawing.Point(454, 68);
            this.dGV_ToDo.Name = "dGV_ToDo";
            this.dGV_ToDo.Size = new System.Drawing.Size(337, 315);
            this.dGV_ToDo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "To Do List";
            // 
            // btnDailyMoveSelected
            // 
            this.btnDailyMoveSelected.Location = new System.Drawing.Point(365, 177);
            this.btnDailyMoveSelected.Name = "btnDailyMoveSelected";
            this.btnDailyMoveSelected.Size = new System.Drawing.Size(71, 35);
            this.btnDailyMoveSelected.TabIndex = 12;
            this.btnDailyMoveSelected.Text = "Move => Selected";
            this.btnDailyMoveSelected.UseVisualStyleBackColor = true;
            this.btnDailyMoveSelected.Click += new System.EventHandler(this.btnDailyMoveSelected_Click);
            // 
            // btnDailyMoveAll
            // 
            this.btnDailyMoveAll.Location = new System.Drawing.Point(365, 229);
            this.btnDailyMoveAll.Name = "btnDailyMoveAll";
            this.btnDailyMoveAll.Size = new System.Drawing.Size(76, 35);
            this.btnDailyMoveAll.TabIndex = 14;
            this.btnDailyMoveAll.Text = "Move All";
            this.btnDailyMoveAll.UseVisualStyleBackColor = true;
            this.btnDailyMoveAll.Click += new System.EventHandler(this.btnDailyMoveAll_Click);
            // 
            // btnSpecialCircumstance
            // 
            this.btnSpecialCircumstance.Location = new System.Drawing.Point(1091, 101);
            this.btnSpecialCircumstance.Name = "btnSpecialCircumstance";
            this.btnSpecialCircumstance.Size = new System.Drawing.Size(142, 30);
            this.btnSpecialCircumstance.TabIndex = 15;
            this.btnSpecialCircumstance.Text = "Add Special Circumstance";
            this.btnSpecialCircumstance.UseVisualStyleBackColor = true;
            this.btnSpecialCircumstance.Click += new System.EventHandler(this.btnSpecialCircumstance_Click);
            // 
            // btnToDoDeleteSelected
            // 
            this.btnToDoDeleteSelected.Location = new System.Drawing.Point(519, 389);
            this.btnToDoDeleteSelected.Name = "btnToDoDeleteSelected";
            this.btnToDoDeleteSelected.Size = new System.Drawing.Size(60, 40);
            this.btnToDoDeleteSelected.TabIndex = 16;
            this.btnToDoDeleteSelected.Text = "Delete Selected";
            this.btnToDoDeleteSelected.UseVisualStyleBackColor = true;
            this.btnToDoDeleteSelected.Click += new System.EventHandler(this.btnToDoDeleteSelected_Click);
            // 
            // btnToDoDeleteAll
            // 
            this.btnToDoDeleteAll.Location = new System.Drawing.Point(689, 389);
            this.btnToDoDeleteAll.Name = "btnToDoDeleteAll";
            this.btnToDoDeleteAll.Size = new System.Drawing.Size(60, 40);
            this.btnToDoDeleteAll.TabIndex = 17;
            this.btnToDoDeleteAll.Text = "Delete All";
            this.btnToDoDeleteAll.UseVisualStyleBackColor = true;
            this.btnToDoDeleteAll.Click += new System.EventHandler(this.btnToDoDeleteAll_Click);
            // 
            // btnSelectChildren
            // 
            this.btnSelectChildren.Location = new System.Drawing.Point(698, 487);
            this.btnSelectChildren.Name = "btnSelectChildren";
            this.btnSelectChildren.Size = new System.Drawing.Size(108, 50);
            this.btnSelectChildren.TabIndex = 21;
            this.btnSelectChildren.Text = "Select Children/Review";
            this.btnSelectChildren.UseVisualStyleBackColor = true;
            this.btnSelectChildren.Click += new System.EventHandler(this.btnSelectChildren_Click);
            // 
            // btnReviewRewards
            // 
            this.btnReviewRewards.Location = new System.Drawing.Point(835, 487);
            this.btnReviewRewards.Name = "btnReviewRewards";
            this.btnReviewRewards.Size = new System.Drawing.Size(108, 50);
            this.btnReviewRewards.TabIndex = 22;
            this.btnReviewRewards.Text = "Review Submitted Rewards";
            this.btnReviewRewards.UseVisualStyleBackColor = true;
            this.btnReviewRewards.Click += new System.EventHandler(this.btnReviewRewards_Click);
            // 
            // richTextBoxSpecialCircumstance
            // 
            this.richTextBoxSpecialCircumstance.Location = new System.Drawing.Point(855, 33);
            this.richTextBoxSpecialCircumstance.Name = "richTextBoxSpecialCircumstance";
            this.richTextBoxSpecialCircumstance.Size = new System.Drawing.Size(413, 62);
            this.richTextBoxSpecialCircumstance.TabIndex = 23;
            this.richTextBoxSpecialCircumstance.Text = "";
            // 
            // dGVOtherChores
            // 
            this.dGVOtherChores.AllowUserToOrderColumns = true;
            this.dGVOtherChores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVOtherChores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVOtherChores.Location = new System.Drawing.Point(894, 141);
            this.dGVOtherChores.Name = "dGVOtherChores";
            this.dGVOtherChores.Size = new System.Drawing.Size(337, 242);
            this.dGVOtherChores.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(891, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Other Chores";
            // 
            // BtnMoveSelectedOther
            // 
            this.BtnMoveSelectedOther.Location = new System.Drawing.Point(806, 174);
            this.BtnMoveSelectedOther.Name = "BtnMoveSelectedOther";
            this.BtnMoveSelectedOther.Size = new System.Drawing.Size(71, 40);
            this.BtnMoveSelectedOther.TabIndex = 26;
            this.BtnMoveSelectedOther.Text = "<= Move Selected";
            this.BtnMoveSelectedOther.UseVisualStyleBackColor = true;
            this.BtnMoveSelectedOther.Click += new System.EventHandler(this.BtnMoveSelectedOther_Click);
            // 
            // BtnMoveAllOther
            // 
            this.BtnMoveAllOther.Location = new System.Drawing.Point(806, 229);
            this.BtnMoveAllOther.Name = "BtnMoveAllOther";
            this.BtnMoveAllOther.Size = new System.Drawing.Size(76, 35);
            this.BtnMoveAllOther.TabIndex = 27;
            this.BtnMoveAllOther.Text = "Move All";
            this.BtnMoveAllOther.UseVisualStyleBackColor = true;
            this.BtnMoveAllOther.Click += new System.EventHandler(this.BtnMoveAllOther_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1158, 501);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 28;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // Tasker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 573);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.BtnMoveAllOther);
            this.Controls.Add(this.BtnMoveSelectedOther);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVOtherChores);
            this.Controls.Add(this.richTextBoxSpecialCircumstance);
            this.Controls.Add(this.btnReviewRewards);
            this.Controls.Add(this.btnSelectChildren);
            this.Controls.Add(this.btnToDoDeleteAll);
            this.Controls.Add(this.btnToDoDeleteSelected);
            this.Controls.Add(this.btnSpecialCircumstance);
            this.Controls.Add(this.btnDailyMoveAll);
            this.Controls.Add(this.btnDailyMoveSelected);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dGV_ToDo);
            this.Controls.Add(this.dGVDaily);
            this.Controls.Add(this.label1);
            this.Name = "Tasker";
            this.Text = "Tasker";
            this.Load += new System.EventHandler(this.Tasker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOtherChores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVDaily;
        private System.Windows.Forms.DataGridView dGV_ToDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDailyMoveSelected;
        private System.Windows.Forms.Button btnDailyMoveAll;
        private System.Windows.Forms.Button btnSpecialCircumstance;
        private System.Windows.Forms.Button btnToDoDeleteSelected;
        private System.Windows.Forms.Button btnToDoDeleteAll;
        private System.Windows.Forms.Button btnSelectChildren;
        private System.Windows.Forms.Button btnReviewRewards;
        private System.Windows.Forms.RichTextBox richTextBoxSpecialCircumstance;
        private System.Windows.Forms.DataGridView dGVOtherChores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnMoveSelectedOther;
        private System.Windows.Forms.Button BtnMoveAllOther;
        private System.Windows.Forms.Button btnLogOut;
    }
}