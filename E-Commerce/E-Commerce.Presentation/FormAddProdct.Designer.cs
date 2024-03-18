namespace E_Commerce.Presentation
{
	partial class FormAddProdct
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
			label1.Location = new Point(150, 7);
			label1.Name = "label1";
			label1.Size = new Size(136, 20);
			label1.TabIndex = 0;
			label1.Text = "Add Product form";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(29, 54);
			label2.Name = "label2";
			label2.Size = new Size(84, 15);
			label2.TabIndex = 1;
			label2.Text = "Product Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(29, 93);
			label3.Name = "label3";
			label3.Size = new Size(33, 15);
			label3.TabIndex = 2;
			label3.Text = "Price";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(29, 134);
			label4.Name = "label4";
			label4.Size = new Size(55, 15);
			label4.TabIndex = 3;
			label4.Text = "Category";
			// 
			// button1
			// 
			button1.Location = new Point(306, 328);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(128, 22);
			button1.TabIndex = 5;
			button1.Text = "Upload Picture";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBoxPname
			// 
			textBoxPname.Location = new Point(127, 56);
			textBoxPname.Margin = new Padding(3, 2, 3, 2);
			textBoxPname.Name = "textBoxPname";
			textBoxPname.Size = new Size(110, 23);
			textBoxPname.TabIndex = 6;
			// 
			// textBoxprice
			// 
			textBoxprice.Location = new Point(127, 96);
			textBoxprice.Margin = new Padding(3, 2, 3, 2);
			textBoxprice.Name = "textBoxprice";
			textBoxprice.Size = new Size(110, 23);
			textBoxprice.TabIndex = 7;
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Mobile", "TV" });
			comboBox1.Location = new Point(127, 134);
			comboBox1.Margin = new Padding(3, 2, 3, 2);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(133, 23);
			comboBox1.TabIndex = 8;
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(292, 35);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(160, 146);
			pictureBox1.TabIndex = 9;
			pictureBox1.TabStop = false;
			// 
			// button2
			// 
			button2.Location = new Point(12, 328);
			button2.Margin = new Padding(3, 2, 3, 2);
			button2.Name = "button2";
			button2.Size = new Size(82, 22);
			button2.TabIndex = 10;
			button2.Text = "Save";
			button2.UseVisualStyleBackColor = true;
			button2.Click += buttonSaveAddproduct_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label5.Location = new Point(29, 172);
			label5.Name = "label5";
			label5.Size = new Size(56, 15);
			label5.TabIndex = 11;
			label5.Text = "Quantity ";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(127, 170);
			numericUpDown1.Margin = new Padding(3, 2, 3, 2);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(131, 23);
			numericUpDown1.TabIndex = 12;
			// 
			// txtProductDescription
			// 
			txtProductDescription.Location = new Point(160, 220);
			txtProductDescription.Margin = new Padding(3, 2, 3, 2);
			txtProductDescription.Multiline = true;
			txtProductDescription.Name = "txtProductDescription";
			txtProductDescription.Size = new Size(292, 85);
			txtProductDescription.TabIndex = 14;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(29, 223);
			label6.Name = "label6";
			label6.Size = new Size(112, 15);
			label6.TabIndex = 13;
			label6.Text = "Product Description";
			// 
			// FormAddProdct
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(485, 371);
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
			Margin = new Padding(3, 2, 3, 2);
			Name = "FormAddProdct";
			Text = "FormAddProdct";
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
		private TextBox textBoxPname;
		private TextBox textBoxprice;
		private ComboBox comboBox1;
		private PictureBox pictureBox1;
		private Button button2;
		private Label label5;
		private NumericUpDown numericUpDown1;
		private TextBox txtProductDescription;
		private Label label6;
	}
}