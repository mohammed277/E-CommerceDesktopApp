namespace E_Commerce.Presentation
{
    partial class CartItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            CartTitlelbl = new Label();
            CartDescriptionlbl = new Label();
            IncreaseCartbtn = new Button();
            DecreaseCartbtn = new Button();
            Quantitylbl = new Label();
            CartPricelbl = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(25, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CartTitlelbl
            // 
            CartTitlelbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CartTitlelbl.Location = new Point(190, 25);
            CartTitlelbl.Name = "CartTitlelbl";
            CartTitlelbl.Size = new Size(254, 31);
            CartTitlelbl.TabIndex = 1;
            CartTitlelbl.Text = "Title";
            CartTitlelbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CartDescriptionlbl
            // 
            CartDescriptionlbl.Location = new Point(190, 66);
            CartDescriptionlbl.Name = "CartDescriptionlbl";
            CartDescriptionlbl.Size = new Size(276, 43);
            CartDescriptionlbl.TabIndex = 2;
            CartDescriptionlbl.Text = "Description";
            // 
            // IncreaseCartbtn
            // 
            IncreaseCartbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IncreaseCartbtn.Location = new Point(472, 48);
            IncreaseCartbtn.Name = "IncreaseCartbtn";
            IncreaseCartbtn.Size = new Size(45, 35);
            IncreaseCartbtn.TabIndex = 3;
            IncreaseCartbtn.Text = "+";
            IncreaseCartbtn.UseVisualStyleBackColor = true;
            IncreaseCartbtn.Click += IncreaseCartbtn_Click;
            // 
            // DecreaseCartbtn
            // 
            DecreaseCartbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DecreaseCartbtn.Location = new Point(574, 48);
            DecreaseCartbtn.Name = "DecreaseCartbtn";
            DecreaseCartbtn.Size = new Size(45, 35);
            DecreaseCartbtn.TabIndex = 4;
            DecreaseCartbtn.Text = "-";
            DecreaseCartbtn.UseVisualStyleBackColor = true;
            DecreaseCartbtn.Click += DecreaseCartbtn_Click;
            // 
            // Quantitylbl
            // 
            Quantitylbl.Location = new Point(523, 46);
            Quantitylbl.Name = "Quantitylbl";
            Quantitylbl.Size = new Size(45, 37);
            Quantitylbl.TabIndex = 5;
            Quantitylbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CartPricelbl
            // 
            CartPricelbl.Location = new Point(655, 46);
            CartPricelbl.Name = "CartPricelbl";
            CartPricelbl.Size = new Size(87, 33);
            CartPricelbl.TabIndex = 6;
            CartPricelbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(853, 46);
            label1.Name = "label1";
            label1.Size = new Size(45, 33);
            label1.TabIndex = 7;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // CartItems
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            Controls.Add(label1);
            Controls.Add(CartPricelbl);
            Controls.Add(Quantitylbl);
            Controls.Add(DecreaseCartbtn);
            Controls.Add(IncreaseCartbtn);
            Controls.Add(CartDescriptionlbl);
            Controls.Add(CartTitlelbl);
            Controls.Add(pictureBox1);
            Name = "CartItems";
            Size = new Size(956, 126);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label CartTitlelbl;
        private Label CartDescriptionlbl;
        private Button IncreaseCartbtn;
        private Button DecreaseCartbtn;
        private Label Quantitylbl;
        private Label CartPricelbl;
        private Label label1;
    }
}
