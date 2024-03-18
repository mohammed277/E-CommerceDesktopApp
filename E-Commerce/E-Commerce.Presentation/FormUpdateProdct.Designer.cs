namespace E_Commerce.Presentation
{
    partial class FormUpdateProdct
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBoxPname = new TextBox();
            textBoxprice = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtProductDescription = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 0;
            label1.Text = "UpdateProduct form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 72);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 124);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 179);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // button1
            // 
            button1.Location = new Point(350, 437);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 5;
            button1.Text = "Upload Picture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPname
            // 
            textBoxPname.Location = new Point(145, 75);
            textBoxPname.Name = "textBoxPname";
            textBoxPname.Size = new Size(125, 27);
            textBoxPname.TabIndex = 6;
            // 
            // textBoxprice
            // 
            textBoxprice.Location = new Point(145, 128);
            textBoxprice.Name = "textBoxprice";
            textBoxprice.Size = new Size(125, 27);
            textBoxprice.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Mobile", "TV" });
            comboBox1.Location = new Point(145, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(334, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 195);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(14, 437);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 229);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 11;
            label5.Text = "Quantity ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(145, 227);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // txtProductDescription
            // 
            txtProductDescription.Location = new Point(183, 293);
            txtProductDescription.Multiline = true;
            txtProductDescription.Name = "txtProductDescription";
            txtProductDescription.Size = new Size(333, 112);
            txtProductDescription.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 297);
            label6.Name = "label6";
            label6.Size = new Size(140, 20);
            label6.TabIndex = 13;
            label6.Text = "Product Description";
            // 
            // FormUpdateProdct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 495);
            Controls.Add(txtProductDescription);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBoxprice);
            Controls.Add(textBoxPname);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUpdateProdct";
            Text = "FormUpdateProdct";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private TextBox textBoxPname;
        private TextBox textBoxprice;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private TextBox txtProductDescription;
    }
}