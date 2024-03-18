namespace E_Commerce.Presentation
{
	partial class AddCategoryForm
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
			saveBtn = new Button();
			categorynameTxt = new TextBox();
			SuspendLayout();
			// 
			// saveBtn
			// 
			saveBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			saveBtn.Location = new Point(393, 26);
			saveBtn.Margin = new Padding(3, 2, 3, 2);
			saveBtn.Name = "saveBtn";
			saveBtn.Size = new Size(95, 40);
			saveBtn.TabIndex = 9;
			saveBtn.Text = "Save";
			saveBtn.UseVisualStyleBackColor = true;
			saveBtn.Click += saveBtn_Click;
			// 
			// categorynameTxt
			// 
			categorynameTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
			categorynameTxt.Location = new Point(51, 31);
			categorynameTxt.Margin = new Padding(3, 2, 3, 2);
			categorynameTxt.Name = "categorynameTxt";
			categorynameTxt.Size = new Size(256, 32);
			categorynameTxt.TabIndex = 8;
			// 
			// AddCategoryForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(599, 88);
			Controls.Add(saveBtn);
			Controls.Add(categorynameTxt);
			Name = "AddCategoryForm";
			Text = "AddCategoryForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button saveBtn;
		private TextBox categorynameTxt;
	}
}