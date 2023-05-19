namespace WindowsFormsApp1
{
    partial class show_bankD
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.branchshow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customershow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(70, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(131, 369);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(303, 89);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(138, 369);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(551, 89);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(150, 369);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // branchshow
            // 
            this.branchshow.AutoSize = true;
            this.branchshow.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchshow.Location = new System.Drawing.Point(81, 43);
            this.branchshow.Name = "branchshow";
            this.branchshow.Size = new System.Drawing.Size(86, 27);
            this.branchshow.TabIndex = 3;
            this.branchshow.Text = "Branch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee";
            // 
            // customershow
            // 
            this.customershow.AutoSize = true;
            this.customershow.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customershow.Location = new System.Drawing.Point(570, 43);
            this.customershow.Name = "customershow";
            this.customershow.Size = new System.Drawing.Size(99, 24);
            this.customershow.TabIndex = 5;
            this.customershow.Text = "Employee";
            // 
            // show_bankD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 470);
            this.Controls.Add(this.customershow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.branchshow);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "show_bankD";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Label branchshow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customershow;
    }
}