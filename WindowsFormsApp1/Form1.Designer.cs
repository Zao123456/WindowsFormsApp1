namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fruitDataSet = new WindowsFormsApp1.FruitDataSet();
            this.fruitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fruitDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.select_btn = new System.Windows.Forms.Button();
            this.select_btr = new System.Windows.Forms.Button();
            this.fruitDataSet1 = new WindowsFormsApp1.FruitDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fruitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "item";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(211, 50);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(174, 22);
            this.txtItem.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(211, 136);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(174, 22);
            this.txtQuantity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "quantity";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(211, 227);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(174, 22);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "price";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "first";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 319);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 32);
            this.button3.TabIndex = 8;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(490, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 32);
            this.button4.TabIndex = 9;
            this.button4.Text = "last";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fruitDataSet
            // 
            this.fruitDataSet.DataSetName = "FruitDataSet";
            this.fruitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fruitDataSetBindingSource
            // 
            this.fruitDataSetBindingSource.DataSource = this.fruitDataSet;
            this.fruitDataSetBindingSource.Position = 0;
            // 
            // fruitDataSetBindingSource1
            // 
            this.fruitDataSetBindingSource1.DataSource = this.fruitDataSet;
            this.fruitDataSetBindingSource1.Position = 0;
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(490, 319);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(108, 32);
            this.select_btn.TabIndex = 12;
            this.select_btn.Text = "Go to form";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // select_btr
            // 
            this.select_btr.Location = new System.Drawing.Point(490, 381);
            this.select_btr.Name = "select_btr";
            this.select_btr.Size = new System.Drawing.Size(108, 32);
            this.select_btr.TabIndex = 13;
            this.select_btr.Text = "select";
            this.select_btr.UseVisualStyleBackColor = true;
            this.select_btr.Click += new System.EventHandler(this.select_btr_Click);
            // 
            // fruitDataSet1
            // 
            this.fruitDataSet1.DataSetName = "FruitDataSet";
            this.fruitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(441, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.select_btr);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fruitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource fruitDataSetBindingSource;
        private FruitDataSet fruitDataSet;
        private System.Windows.Forms.BindingSource fruitDataSetBindingSource1;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Button select_btr;
        private FruitDataSet fruitDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

