namespace ChoreAssigner
{
    partial class PasswordEntryAdult
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
            this.btnPasswordAdultSubmit = new System.Windows.Forms.Button();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.txtParentPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPasswordAdultSubmit
            // 
            this.btnPasswordAdultSubmit.Location = new System.Drawing.Point(111, 146);
            this.btnPasswordAdultSubmit.Name = "btnPasswordAdultSubmit";
            this.btnPasswordAdultSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnPasswordAdultSubmit.TabIndex = 9;
            this.btnPasswordAdultSubmit.Text = "Submit";
            this.btnPasswordAdultSubmit.UseVisualStyleBackColor = true;
            this.btnPasswordAdultSubmit.Click += new System.EventHandler(this.btnPasswordAdultSubmit_Click);
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(136, 42);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(100, 20);
            this.txtParentName.TabIndex = 8;
            // 
            // txtParentPassword
            // 
            this.txtParentPassword.Location = new System.Drawing.Point(136, 95);
            this.txtParentPassword.Name = "txtParentPassword";
            this.txtParentPassword.PasswordChar = '*';
            this.txtParentPassword.Size = new System.Drawing.Size(100, 20);
            this.txtParentPassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // PasswordEntryAdult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 194);
            this.Controls.Add(this.btnPasswordAdultSubmit);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.txtParentPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PasswordEntryAdult";
            this.Text = "PasswordEntryAdult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPasswordAdultSubmit;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.TextBox txtParentPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}