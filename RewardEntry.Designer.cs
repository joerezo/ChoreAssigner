namespace ChoreAssigner
{
    partial class RewardEntry
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRewardSubmission = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChildName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dGVSubmittedRewardsSubmission = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSubmittedRewardsSubmission)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rewards Entry Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answer the following question. When we are done, I would like to...";
            // 
            // txtRewardSubmission
            // 
            this.txtRewardSubmission.Location = new System.Drawing.Point(125, 131);
            this.txtRewardSubmission.Name = "txtRewardSubmission";
            this.txtRewardSubmission.Size = new System.Drawing.Size(351, 20);
            this.txtRewardSubmission.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Child\'s Name Submitting Reward";
            // 
            // txtChildName
            // 
            this.txtChildName.Location = new System.Drawing.Point(330, 185);
            this.txtChildName.Name = "txtChildName";
            this.txtChildName.Size = new System.Drawing.Size(151, 20);
            this.txtChildName.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(401, 222);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dGVSubmittedRewardsSubmission
            // 
            this.dGVSubmittedRewardsSubmission.AllowUserToOrderColumns = true;
            this.dGVSubmittedRewardsSubmission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSubmittedRewardsSubmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSubmittedRewardsSubmission.Location = new System.Drawing.Point(54, 274);
            this.dGVSubmittedRewardsSubmission.Name = "dGVSubmittedRewardsSubmission";
            this.dGVSubmittedRewardsSubmission.Size = new System.Drawing.Size(478, 137);
            this.dGVSubmittedRewardsSubmission.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Rewards Submissions";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(457, 447);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Log Out";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RewardEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 482);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dGVSubmittedRewardsSubmission);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtChildName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRewardSubmission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RewardEntry";
            this.Text = "RewardEntry";
            this.Load += new System.EventHandler(this.RewardEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSubmittedRewardsSubmission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRewardSubmission;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChildName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dGVSubmittedRewardsSubmission;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
    }
}