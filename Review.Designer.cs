namespace ChoreAssigner
{
    partial class Review
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save_Draft = new System.Windows.Forms.Button();
            this.btn_Approve_Save = new System.Windows.Forms.Button();
            this.btnSetFileLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(85, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(646, 683);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(803, 68);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Title";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Location = new System.Drawing.Point(179, 32);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(552, 20);
            this.txtEventTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "For Work On";
            // 
            // btn_Save_Draft
            // 
            this.btn_Save_Draft.Location = new System.Drawing.Point(836, 348);
            this.btn_Save_Draft.Name = "btn_Save_Draft";
            this.btn_Save_Draft.Size = new System.Drawing.Size(208, 74);
            this.btn_Save_Draft.TabIndex = 5;
            this.btn_Save_Draft.Text = "Save Draft";
            this.btn_Save_Draft.UseVisualStyleBackColor = true;
            this.btn_Save_Draft.Click += new System.EventHandler(this.btn_Save_Draft_Click);
            // 
            // btn_Approve_Save
            // 
            this.btn_Approve_Save.Location = new System.Drawing.Point(836, 476);
            this.btn_Approve_Save.Name = "btn_Approve_Save";
            this.btn_Approve_Save.Size = new System.Drawing.Size(208, 74);
            this.btn_Approve_Save.TabIndex = 6;
            this.btn_Approve_Save.Text = "Approve and Save";
            this.btn_Approve_Save.UseVisualStyleBackColor = true;
            this.btn_Approve_Save.Click += new System.EventHandler(this.btn_Approve_Save_Click);
            // 
            // btnSetFileLocation
            // 
            this.btnSetFileLocation.Location = new System.Drawing.Point(844, 636);
            this.btnSetFileLocation.Name = "btnSetFileLocation";
            this.btnSetFileLocation.Size = new System.Drawing.Size(186, 77);
            this.btnSetFileLocation.TabIndex = 7;
            this.btnSetFileLocation.Text = "Change File Location";
            this.btnSetFileLocation.UseVisualStyleBackColor = true;
            this.btnSetFileLocation.Click += new System.EventHandler(this.btnSetFileLocation_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 791);
            this.Controls.Add(this.btnSetFileLocation);
            this.Controls.Add(this.btn_Approve_Save);
            this.Controls.Add(this.btn_Save_Draft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Review";
            this.Text = "Review Work Schedule";
            this.Load += new System.EventHandler(this.Review_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save_Draft;
        private System.Windows.Forms.Button btn_Approve_Save;
        private System.Windows.Forms.Button btnSetFileLocation;
    }
}