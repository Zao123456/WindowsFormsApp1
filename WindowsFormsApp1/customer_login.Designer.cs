namespace WindowsFormsApp1
{
    partial class customer_login
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
            this.CAcc = new System.Windows.Forms.Button();
            this.LogToAcc = new System.Windows.Forms.Button();
            this.back_page = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CAcc
            // 
            this.CAcc.Location = new System.Drawing.Point(230, 158);
            this.CAcc.Name = "CAcc";
            this.CAcc.Size = new System.Drawing.Size(113, 58);
            this.CAcc.TabIndex = 0;
            this.CAcc.Text = "Create_Acc";
            this.CAcc.UseVisualStyleBackColor = true;
            this.CAcc.Click += new System.EventHandler(this.CAcc_Click);
            // 
            // LogToAcc
            // 
            this.LogToAcc.Location = new System.Drawing.Point(402, 161);
            this.LogToAcc.Name = "LogToAcc";
            this.LogToAcc.Size = new System.Drawing.Size(131, 54);
            this.LogToAcc.TabIndex = 1;
            this.LogToAcc.Text = "Log to acc";
            this.LogToAcc.UseVisualStyleBackColor = true;
            // 
            // back_page
            // 
            this.back_page.Location = new System.Drawing.Point(45, 13);
            this.back_page.Name = "back_page";
            this.back_page.Size = new System.Drawing.Size(75, 23);
            this.back_page.TabIndex = 2;
            this.back_page.Text = "back";
            this.back_page.UseVisualStyleBackColor = true;
            this.back_page.Click += new System.EventHandler(this.back_page_Click);
            // 
            // customer_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_page);
            this.Controls.Add(this.LogToAcc);
            this.Controls.Add(this.CAcc);
            this.Name = "customer_login";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CAcc;
        private System.Windows.Forms.Button LogToAcc;
        private System.Windows.Forms.Button back_page;
    }
}