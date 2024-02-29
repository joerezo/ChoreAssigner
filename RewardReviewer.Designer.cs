namespace ChoreAssigner
{
    partial class RewardReviewer
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
            this.btnApprovedRewardsRemoveSelected = new System.Windows.Forms.Button();
            this.btnSuggestRewardApproveSelected = new System.Windows.Forms.Button();
            this.dGVApprovedReward = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dGVSuggestedRewards = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveAllRewards = new System.Windows.Forms.Button();
            this.btnApproveAll = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVApprovedReward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSuggestedRewards)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApprovedRewardsRemoveSelected
            // 
            this.btnApprovedRewardsRemoveSelected.Location = new System.Drawing.Point(45, 401);
            this.btnApprovedRewardsRemoveSelected.Name = "btnApprovedRewardsRemoveSelected";
            this.btnApprovedRewardsRemoveSelected.Size = new System.Drawing.Size(122, 23);
            this.btnApprovedRewardsRemoveSelected.TabIndex = 26;
            this.btnApprovedRewardsRemoveSelected.Text = "Remove Selected";
            this.btnApprovedRewardsRemoveSelected.UseVisualStyleBackColor = true;
            this.btnApprovedRewardsRemoveSelected.Click += new System.EventHandler(this.btnApprovedRewardsRemoveSelected_Click);
            // 
            // btnSuggestRewardApproveSelected
            // 
            this.btnSuggestRewardApproveSelected.Location = new System.Drawing.Point(45, 197);
            this.btnSuggestRewardApproveSelected.Name = "btnSuggestRewardApproveSelected";
            this.btnSuggestRewardApproveSelected.Size = new System.Drawing.Size(113, 23);
            this.btnSuggestRewardApproveSelected.TabIndex = 24;
            this.btnSuggestRewardApproveSelected.Text = "Approve Selected";
            this.btnSuggestRewardApproveSelected.UseVisualStyleBackColor = true;
            this.btnSuggestRewardApproveSelected.Click += new System.EventHandler(this.btnSuggestRewardApproveSelected_Click);
            // 
            // dGVApprovedReward
            // 
            this.dGVApprovedReward.AllowUserToOrderColumns = true;
            this.dGVApprovedReward.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVApprovedReward.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVApprovedReward.Location = new System.Drawing.Point(36, 278);
            this.dGVApprovedReward.Name = "dGVApprovedReward";
            this.dGVApprovedReward.Size = new System.Drawing.Size(496, 117);
            this.dGVApprovedReward.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Suggested Rewards";
            // 
            // dGVSuggestedRewards
            // 
            this.dGVSuggestedRewards.AllowUserToOrderColumns = true;
            this.dGVSuggestedRewards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVSuggestedRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSuggestedRewards.Location = new System.Drawing.Point(36, 59);
            this.dGVSuggestedRewards.Name = "dGVSuggestedRewards";
            this.dGVSuggestedRewards.Size = new System.Drawing.Size(481, 117);
            this.dGVSuggestedRewards.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Rewards for Approval";
            // 
            // btnRemoveAllRewards
            // 
            this.btnRemoveAllRewards.Location = new System.Drawing.Point(245, 401);
            this.btnRemoveAllRewards.Name = "btnRemoveAllRewards";
            this.btnRemoveAllRewards.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveAllRewards.TabIndex = 28;
            this.btnRemoveAllRewards.Text = "Remove All";
            this.btnRemoveAllRewards.UseVisualStyleBackColor = true;
            this.btnRemoveAllRewards.Click += new System.EventHandler(this.btnRemoveAllRewards_Click);
            // 
            // btnApproveAll
            // 
            this.btnApproveAll.Location = new System.Drawing.Point(245, 197);
            this.btnApproveAll.Name = "btnApproveAll";
            this.btnApproveAll.Size = new System.Drawing.Size(113, 23);
            this.btnApproveAll.TabIndex = 30;
            this.btnApproveAll.Text = "Approve All";
            this.btnApproveAll.UseVisualStyleBackColor = true;
            this.btnApproveAll.Click += new System.EventHandler(this.btnApproveAll_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Location = new System.Drawing.Point(457, 401);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(75, 23);
            this.btnCloseWindow.TabIndex = 31;
            this.btnCloseWindow.Text = "Close Window";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // RewardReviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnApproveAll);
            this.Controls.Add(this.btnRemoveAllRewards);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApprovedRewardsRemoveSelected);
            this.Controls.Add(this.btnSuggestRewardApproveSelected);
            this.Controls.Add(this.dGVApprovedReward);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dGVSuggestedRewards);
            this.Name = "RewardReviewer";
            this.Text = "RewardReviewer";
            this.Load += new System.EventHandler(this.RewardReviewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVApprovedReward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSuggestedRewards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApprovedRewardsRemoveSelected;
        private System.Windows.Forms.Button btnSuggestRewardApproveSelected;
        private System.Windows.Forms.DataGridView dGVApprovedReward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGVSuggestedRewards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveAllRewards;
        private System.Windows.Forms.Button btnApproveAll;
        private System.Windows.Forms.Button btnCloseWindow;
    }
}