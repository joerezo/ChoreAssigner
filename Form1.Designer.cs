namespace ChoreAssigner
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStatusParent = new System.Windows.Forms.Button();
            this.btnStatusChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStatusParent
            // 
            this.btnStatusParent.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusParent.Location = new System.Drawing.Point(38, 98);
            this.btnStatusParent.Name = "btnStatusParent";
            this.btnStatusParent.Size = new System.Drawing.Size(197, 182);
            this.btnStatusParent.TabIndex = 1;
            this.btnStatusParent.Text = "Caring and Loving Parent";
            this.btnStatusParent.UseVisualStyleBackColor = true;
            this.btnStatusParent.Click += new System.EventHandler(this.btnStatusParent_Click);
            // 
            // btnStatusChild
            // 
            this.btnStatusChild.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusChild.Location = new System.Drawing.Point(272, 98);
            this.btnStatusChild.Name = "btnStatusChild";
            this.btnStatusChild.Size = new System.Drawing.Size(197, 182);
            this.btnStatusChild.TabIndex = 2;
            this.btnStatusChild.Text = "Dutiful and Loving Child";
            this.btnStatusChild.UseVisualStyleBackColor = true;
            this.btnStatusChild.Click += new System.EventHandler(this.btnStatusChild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 326);
            this.Controls.Add(this.btnStatusChild);
            this.Controls.Add(this.btnStatusParent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Select Status";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStatusParent;
        private System.Windows.Forms.Button btnStatusChild;
    }
}

