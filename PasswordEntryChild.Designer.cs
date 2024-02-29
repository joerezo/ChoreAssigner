namespace ChoreAssigner
{
    partial class PasswordEntryChild
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
            this.txtChildPassword = new System.Windows.Forms.TextBox();
            this.txtChildName = new System.Windows.Forms.TextBox();
            this.btnPasswordChildSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtChildPassword
            // 
            this.txtChildPassword.Location = new System.Drawing.Point(134, 88);
            this.txtChildPassword.Name = "txtChildPassword";
            this.txtChildPassword.Size = new System.Drawing.Size(100, 20);
            this.txtChildPassword.TabIndex = 2;
            // 
            // txtChildName
            // 
            this.txtChildName.Location = new System.Drawing.Point(134, 47);
            this.txtChildName.Name = "txtChildName";
            this.txtChildName.Size = new System.Drawing.Size(100, 20);
            this.txtChildName.TabIndex = 3;
            // 
            // btnPasswordChildSubmit
            // 
            this.btnPasswordChildSubmit.Location = new System.Drawing.Point(146, 152);
            this.btnPasswordChildSubmit.Name = "btnPasswordChildSubmit";
            this.btnPasswordChildSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnPasswordChildSubmit.TabIndex = 4;
            this.btnPasswordChildSubmit.Text = "Submit";
            this.btnPasswordChildSubmit.UseVisualStyleBackColor = true;
            this.btnPasswordChildSubmit.Click += new System.EventHandler(this.btnPasswordChildSubmit_Click);
            // 
            // PasswordEntryChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 202);
            this.Controls.Add(this.btnPasswordChildSubmit);
            this.Controls.Add(this.txtChildName);
            this.Controls.Add(this.txtChildPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PasswordEntryChild";
            this.Text = "PasswordEntryChild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChildPassword;
        private System.Windows.Forms.TextBox txtChildName;
        private System.Windows.Forms.Button btnPasswordChildSubmit;
    }
}