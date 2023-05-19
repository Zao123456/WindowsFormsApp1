namespace WindowsFormsApp1
{
    partial class logedin
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
            this.addbank = new System.Windows.Forms.Button();
            this.longintobank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbank
            // 
            this.addbank.Location = new System.Drawing.Point(170, 182);
            this.addbank.Name = "addbank";
            this.addbank.Size = new System.Drawing.Size(141, 77);
            this.addbank.TabIndex = 0;
            this.addbank.Text = "Add bank";
            this.addbank.UseVisualStyleBackColor = true;
            this.addbank.Click += new System.EventHandler(this.button1_Click);
            // 
            // longintobank
            // 
            this.longintobank.Location = new System.Drawing.Point(510, 182);
            this.longintobank.Name = "longintobank";
            this.longintobank.Size = new System.Drawing.Size(155, 77);
            this.longintobank.TabIndex = 1;
            this.longintobank.Text = "login To bank";
            this.longintobank.UseVisualStyleBackColor = true;
            this.longintobank.Click += new System.EventHandler(this.longintobank_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "chosse";
            // 
            // back_page
            // 
            this.back_page.Location = new System.Drawing.Point(25, 27);
            this.back_page.Name = "back_page";
            this.back_page.Size = new System.Drawing.Size(75, 23);
            this.back_page.TabIndex = 3;
            this.back_page.Text = "back";
            this.back_page.UseVisualStyleBackColor = true;
            this.back_page.Click += new System.EventHandler(this.back_page_Click);
            // 
            // logedin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 463);
            this.Controls.Add(this.back_page);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longintobank);
            this.Controls.Add(this.addbank);
            this.Name = "logedin";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbank;
        private System.Windows.Forms.Button longintobank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_page;
    }
}