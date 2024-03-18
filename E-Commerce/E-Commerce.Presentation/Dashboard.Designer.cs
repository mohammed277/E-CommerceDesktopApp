using System.Windows.Forms;

namespace E_Commerce.Presentation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnLogOut = new Button();
            AddAdminBtn = new Button();
            OrderBtn = new Button();
            CategoryBtn = new Button();
            productBtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pageSetupDialog1 = new PageSetupDialog();
            tabControl = new TabControl();
            CategoriesPage = new TabPage();
            buttonsearchc = new Button();
            textBox1 = new TextBox();
            buttonDel = new Button();
            buttonUp = new Button();
            buttonAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            dataGridViewCategory = new DataGridView();
            ProductsPage = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAddProduct = new Button();
            label4 = new Label();
            OrdersPage = new TabPage();
            dgrViewOrders = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            FinalPrice = new DataGridViewTextBoxColumn();
            State = new DataGridViewComboBoxColumn();
            AddAdminPage = new TabPage();
            CreateAdminbtn = new Button();
            ErrorConfirmPassword = new Label();
            ConfirmPasswordTxt = new TextBox();
            ErrorPassword = new Label();
            PasswordTxt = new TextBox();
            ErrorPhoneNumber = new Label();
            PhoneNumberTxt = new TextBox();
            ErrorEmail = new Label();
            EmailTxt = new TextBox();
            ErrorFullName = new Label();
            FullNameTxt = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl.SuspendLayout();
            CategoriesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).BeginInit();
            ProductsPage.SuspendLayout();
            OrdersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrViewOrders).BeginInit();
            AddAdminPage.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(83, 66, 194);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(AddAdminBtn);
            panel1.Controls.Add(OrderBtn);
            panel1.Controls.Add(CategoryBtn);
            panel1.Controls.Add(productBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 509);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(83, 66, 194);
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(12, 416);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(213, 52);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // AddAdminBtn
            // 
            AddAdminBtn.BackColor = Color.FromArgb(83, 66, 194);
            AddAdminBtn.Cursor = Cursors.Hand;
            AddAdminBtn.FlatAppearance.BorderSize = 0;
            AddAdminBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            AddAdminBtn.FlatStyle = FlatStyle.Flat;
            AddAdminBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddAdminBtn.ForeColor = Color.White;
            AddAdminBtn.Location = new Point(22, 91);
            AddAdminBtn.Name = "AddAdminBtn";
            AddAdminBtn.Size = new Size(213, 52);
            AddAdminBtn.TabIndex = 6;
            AddAdminBtn.Text = "Add Admin";
            AddAdminBtn.UseVisualStyleBackColor = false;
            AddAdminBtn.Click += AddAdminBtn_Click;
            // 
            // OrderBtn
            // 
            OrderBtn.BackColor = Color.FromArgb(83, 66, 194);
            OrderBtn.Cursor = Cursors.Hand;
            OrderBtn.FlatAppearance.BorderSize = 0;
            OrderBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            OrderBtn.FlatStyle = FlatStyle.Flat;
            OrderBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OrderBtn.ForeColor = Color.White;
            OrderBtn.Location = new Point(12, 332);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(213, 52);
            OrderBtn.TabIndex = 5;
            OrderBtn.Text = "Orders";
            OrderBtn.UseVisualStyleBackColor = false;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // CategoryBtn
            // 
            CategoryBtn.BackColor = Color.FromArgb(83, 66, 194);
            CategoryBtn.Cursor = Cursors.Hand;
            CategoryBtn.FlatAppearance.BorderSize = 0;
            CategoryBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            CategoryBtn.FlatStyle = FlatStyle.Flat;
            CategoryBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            CategoryBtn.ForeColor = Color.White;
            CategoryBtn.Location = new Point(12, 167);
            CategoryBtn.Name = "CategoryBtn";
            CategoryBtn.Size = new Size(213, 52);
            CategoryBtn.TabIndex = 4;
            CategoryBtn.Text = "Categories";
            CategoryBtn.UseVisualStyleBackColor = false;
            CategoryBtn.Click += CategoryBtn_Click;
            // 
            // productBtn
            // 
            productBtn.BackColor = Color.FromArgb(83, 66, 194);
            productBtn.Cursor = Cursors.Hand;
            productBtn.FlatAppearance.BorderSize = 0;
            productBtn.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            productBtn.FlatStyle = FlatStyle.Flat;
            productBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            productBtn.ForeColor = Color.White;
            productBtn.Location = new Point(12, 246);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(213, 52);
            productBtn.TabIndex = 3;
            productBtn.Text = "Products";
            productBtn.UseVisualStyleBackColor = false;
            productBtn.Click += productBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(100, 27);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 2;
            label1.Text = "E-Commerce";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            tabControl.Alignment = TabAlignment.Bottom;
            tabControl.Controls.Add(CategoriesPage);
            tabControl.Controls.Add(ProductsPage);
            tabControl.Controls.Add(OrdersPage);
            tabControl.Controls.Add(AddAdminPage);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl.Location = new Point(241, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(709, 509);
            tabControl.TabIndex = 1;
            // 
            // CategoriesPage
            // 
            CategoriesPage.Controls.Add(buttonsearchc);
            CategoriesPage.Controls.Add(textBox1);
            CategoriesPage.Controls.Add(buttonDel);
            CategoriesPage.Controls.Add(buttonUp);
            CategoriesPage.Controls.Add(buttonAdd);
            CategoriesPage.Controls.Add(label3);
            CategoriesPage.Controls.Add(label2);
            CategoriesPage.Controls.Add(dataGridViewCategory);
            CategoriesPage.Location = new Point(4, 4);
            CategoriesPage.Name = "CategoriesPage";
            CategoriesPage.Padding = new Padding(3);
            CategoriesPage.Size = new Size(701, 476);
            CategoriesPage.TabIndex = 2;
            CategoriesPage.Text = "Categories";
            CategoriesPage.UseVisualStyleBackColor = true;
            // 
            // buttonsearchc
            // 
            buttonsearchc.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            buttonsearchc.Location = new Point(328, 417);
            buttonsearchc.Margin = new Padding(3, 2, 3, 2);
            buttonsearchc.Name = "buttonsearchc";
            buttonsearchc.Size = new Size(182, 40);
            buttonsearchc.TabIndex = 7;
            buttonsearchc.Text = "SearchByName";
            buttonsearchc.UseVisualStyleBackColor = true;
            buttonsearchc.Click += SClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(96, 417);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 32);
            textBox1.TabIndex = 6;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDel.Location = new Point(258, 354);
            buttonDel.Margin = new Padding(3, 2, 3, 2);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(95, 40);
            buttonDel.TabIndex = 5;
            buttonDel.Text = "Delete";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDelc_Click;
            // 
            // buttonUp
            // 
            buttonUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUp.Location = new Point(143, 354);
            buttonUp.Margin = new Padding(3, 2, 3, 2);
            buttonUp.Name = "buttonUp";
            buttonUp.Size = new Size(95, 40);
            buttonUp.TabIndex = 4;
            buttonUp.Text = "Update";
            buttonUp.UseVisualStyleBackColor = true;
            buttonUp.Click += buttonUpc_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(22, 354);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(99, 40);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAddc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 417);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(189, 9);
            label2.Name = "label2";
            label2.Size = new Size(301, 45);
            label2.TabIndex = 1;
            label2.Text = "Categories section";
            // 
            // dataGridViewCategory
            // 
            dataGridViewCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategory.Location = new Point(22, 67);
            dataGridViewCategory.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCategory.Name = "dataGridViewCategory";
            dataGridViewCategory.RowHeadersWidth = 51;
            dataGridViewCategory.RowTemplate.Height = 29;
            dataGridViewCategory.Size = new Size(630, 220);
            dataGridViewCategory.TabIndex = 0;
            dataGridViewCategory.SelectionChanged += dataGridViewSelectionChanged;
            // 
            // ProductsPage
            // 
            ProductsPage.Controls.Add(buttonAddProduct);
            ProductsPage.Controls.Add(flowLayoutPanel1);
            ProductsPage.Controls.Add(label4);
            ProductsPage.Location = new Point(4, 4);
            ProductsPage.Name = "ProductsPage";
            ProductsPage.Padding = new Padding(3);
            ProductsPage.Size = new Size(701, 476);
            ProductsPage.TabIndex = 3;
            ProductsPage.Text = "Products";
            ProductsPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(3, 74);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(695, 350);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddProduct.Location = new Point(18, 430);
            buttonAddProduct.Margin = new Padding(3, 2, 3, 2);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(140, 44);
            buttonAddProduct.TabIndex = 2;
            buttonAddProduct.Text = "Add Product";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(200, 4);
            label4.Name = "label4";
            label4.Size = new Size(265, 45);
            label4.TabIndex = 0;
            label4.Text = "Products Section";
            // 
            // OrdersPage
            // 
            OrdersPage.Controls.Add(dgrViewOrders);
            OrdersPage.Location = new Point(4, 4);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Padding = new Padding(3);
            OrdersPage.Size = new Size(701, 476);
            OrdersPage.TabIndex = 4;
            OrdersPage.Text = "Orders";
            OrdersPage.UseVisualStyleBackColor = true;
            // 
            // dgrViewOrders
            // 
            dgrViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgrViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrViewOrders.Columns.AddRange(new DataGridViewColumn[] { FullName, ID, UserID, Email, Date, FinalPrice, State });
            dgrViewOrders.Dock = DockStyle.Fill;
            dgrViewOrders.Location = new Point(3, 3);
            dgrViewOrders.Name = "dgrViewOrders";
            dgrViewOrders.RowTemplate.Height = 25;
            dgrViewOrders.Size = new Size(695, 470);
            dgrViewOrders.TabIndex = 0;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "UserName";
            FullName.Name = "FullName";
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Visible = false;
            // 
            // UserID
            // 
            UserID.DataPropertyName = "UserID";
            UserID.HeaderText = "UserID";
            UserID.Name = "UserID";
            UserID.Visible = false;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "OrderDate";
            Date.Name = "Date";
            // 
            // FinalPrice
            // 
            FinalPrice.DataPropertyName = "FinalPrice";
            FinalPrice.HeaderText = "Total Price";
            FinalPrice.Name = "FinalPrice";
            // 
            // State
            // 
            State.DataPropertyName = "State";
            State.HeaderText = "State";
            State.Name = "State";
            // 
            // AddAdminPage
            // 
            AddAdminPage.Controls.Add(CreateAdminbtn);
            AddAdminPage.Controls.Add(ErrorConfirmPassword);
            AddAdminPage.Controls.Add(ConfirmPasswordTxt);
            AddAdminPage.Controls.Add(ErrorPassword);
            AddAdminPage.Controls.Add(PasswordTxt);
            AddAdminPage.Controls.Add(ErrorPhoneNumber);
            AddAdminPage.Controls.Add(PhoneNumberTxt);
            AddAdminPage.Controls.Add(ErrorEmail);
            AddAdminPage.Controls.Add(EmailTxt);
            AddAdminPage.Controls.Add(ErrorFullName);
            AddAdminPage.Controls.Add(FullNameTxt);
            AddAdminPage.Location = new Point(4, 4);
            AddAdminPage.Name = "AddAdminPage";
            AddAdminPage.Padding = new Padding(3);
            AddAdminPage.Size = new Size(701, 476);
            AddAdminPage.TabIndex = 5;
            AddAdminPage.Text = "AddAdmin";
            AddAdminPage.UseVisualStyleBackColor = true;
            // 
            // CreateAdminbtn
            // 
            CreateAdminbtn.BackColor = Color.FromArgb(0, 192, 0);
            CreateAdminbtn.FlatAppearance.BorderSize = 0;
            CreateAdminbtn.FlatStyle = FlatStyle.Flat;
            CreateAdminbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateAdminbtn.ForeColor = Color.White;
            CreateAdminbtn.Location = new Point(207, 436);
            CreateAdminbtn.Name = "CreateAdminbtn";
            CreateAdminbtn.Size = new Size(292, 34);
            CreateAdminbtn.TabIndex = 21;
            CreateAdminbtn.Text = "Create";
            CreateAdminbtn.UseVisualStyleBackColor = false;
            CreateAdminbtn.Click += CreateAdminbtn_Click;
            // 
            // ErrorConfirmPassword
            // 
            ErrorConfirmPassword.AutoSize = true;
            ErrorConfirmPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorConfirmPassword.ForeColor = Color.Red;
            ErrorConfirmPassword.Location = new Point(209, 401);
            ErrorConfirmPassword.Name = "ErrorConfirmPassword";
            ErrorConfirmPassword.Size = new Size(54, 21);
            ErrorConfirmPassword.TabIndex = 20;
            ErrorConfirmPassword.Text = "label5";
            ErrorConfirmPassword.Visible = false;
            // 
            // ConfirmPasswordTxt
            // 
            ConfirmPasswordTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmPasswordTxt.Location = new Point(209, 350);
            ConfirmPasswordTxt.Multiline = true;
            ConfirmPasswordTxt.Name = "ConfirmPasswordTxt";
            ConfirmPasswordTxt.PasswordChar = '*';
            ConfirmPasswordTxt.PlaceholderText = "Enter Confirm Password";
            ConfirmPasswordTxt.Size = new Size(290, 39);
            ConfirmPasswordTxt.TabIndex = 19;
            ConfirmPasswordTxt.TextChanged += ConfirmPasswordTxt_TextChanged;
            // 
            // ErrorPassword
            // 
            ErrorPassword.AutoSize = true;
            ErrorPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorPassword.ForeColor = Color.Red;
            ErrorPassword.Location = new Point(209, 315);
            ErrorPassword.Name = "ErrorPassword";
            ErrorPassword.Size = new Size(54, 21);
            ErrorPassword.TabIndex = 18;
            ErrorPassword.Text = "label5";
            ErrorPassword.Visible = false;
            // 
            // PasswordTxt
            // 
            PasswordTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordTxt.Location = new Point(209, 264);
            PasswordTxt.Multiline = true;
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.PasswordChar = '*';
            PasswordTxt.PlaceholderText = "Enter Password";
            PasswordTxt.Size = new Size(290, 39);
            PasswordTxt.TabIndex = 17;
            PasswordTxt.TextChanged += PasswordTxt_TextChanged;
            // 
            // ErrorPhoneNumber
            // 
            ErrorPhoneNumber.AutoSize = true;
            ErrorPhoneNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorPhoneNumber.ForeColor = Color.Red;
            ErrorPhoneNumber.Location = new Point(209, 229);
            ErrorPhoneNumber.Name = "ErrorPhoneNumber";
            ErrorPhoneNumber.Size = new Size(54, 21);
            ErrorPhoneNumber.TabIndex = 16;
            ErrorPhoneNumber.Text = "label5";
            ErrorPhoneNumber.Visible = false;
            // 
            // PhoneNumberTxt
            // 
            PhoneNumberTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberTxt.Location = new Point(209, 178);
            PhoneNumberTxt.Multiline = true;
            PhoneNumberTxt.Name = "PhoneNumberTxt";
            PhoneNumberTxt.PlaceholderText = "Enter Phone Number";
            PhoneNumberTxt.Size = new Size(290, 39);
            PhoneNumberTxt.TabIndex = 15;
            PhoneNumberTxt.TextChanged += PhoneNumberTxt_TextChanged;
            // 
            // ErrorEmail
            // 
            ErrorEmail.AutoSize = true;
            ErrorEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorEmail.ForeColor = Color.Red;
            ErrorEmail.Location = new Point(209, 137);
            ErrorEmail.Name = "ErrorEmail";
            ErrorEmail.Size = new Size(54, 21);
            ErrorEmail.TabIndex = 14;
            ErrorEmail.Text = "label5";
            ErrorEmail.Visible = false;
            // 
            // EmailTxt
            // 
            EmailTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            EmailTxt.Location = new Point(209, 86);
            EmailTxt.Multiline = true;
            EmailTxt.Name = "EmailTxt";
            EmailTxt.PlaceholderText = "Enter Email Address";
            EmailTxt.Size = new Size(290, 39);
            EmailTxt.TabIndex = 13;
            EmailTxt.TextChanged += EmailTxt_TextChanged;
            // 
            // ErrorFullName
            // 
            ErrorFullName.AutoSize = true;
            ErrorFullName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ErrorFullName.ForeColor = Color.Red;
            ErrorFullName.Location = new Point(209, 62);
            ErrorFullName.Name = "ErrorFullName";
            ErrorFullName.Size = new Size(54, 21);
            ErrorFullName.TabIndex = 12;
            ErrorFullName.Text = "label5";
            ErrorFullName.Visible = false;
            // 
            // FullNameTxt
            // 
            FullNameTxt.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameTxt.Location = new Point(209, 11);
            FullNameTxt.Multiline = true;
            FullNameTxt.Name = "FullNameTxt";
            FullNameTxt.PlaceholderText = "Enter Full Name";
            FullNameTxt.Size = new Size(290, 39);
            FullNameTxt.TabIndex = 11;
            FullNameTxt.TextChanged += FullNameTxt_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 509);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "E-Commerce";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl.ResumeLayout(false);
            CategoriesPage.ResumeLayout(false);
            CategoriesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategory).EndInit();
            ProductsPage.ResumeLayout(false);
            ProductsPage.PerformLayout();
            OrdersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrViewOrders).EndInit();
            AddAdminPage.ResumeLayout(false);
            AddAdminPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button productBtn;
        private Button AddAdminBtn;
        private Button OrderBtn;
        private Button CategoryBtn;
        private Button btnLogOut;
        private PageSetupDialog pageSetupDialog1;
        private TabControl tabControl;
        private TabPage CategoriesPage;
        private TabPage ProductsPage;
        private TabPage OrdersPage;
        private TabPage AddAdminPage;
        private DataGridViewTextBoxColumn CName;
        private TextBox textBox1;
        private Button buttonDel;
        private Button buttonUp;
        private Button buttonAdd;
        private Label label3;
        private Label label2;
        private DataGridView dataGridViewCategory;
        private Button buttonAddProduct;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label4;
        private Button buttonsearchc;
        private Button CreateAdminbtn;
        private Label ErrorConfirmPassword;
        private TextBox ConfirmPasswordTxt;
        private Label ErrorPassword;
        private TextBox PasswordTxt;
        private Label ErrorPhoneNumber;
        private TextBox PhoneNumberTxt;
        private Label ErrorEmail;
        private TextBox EmailTxt;
        private Label ErrorFullName;
        private TextBox FullNameTxt;
        private DataGridView dgrViewOrders;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn FinalPrice;
        private DataGridViewComboBoxColumn State;
    }
}