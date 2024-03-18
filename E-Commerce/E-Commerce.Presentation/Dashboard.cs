using AutoMapper;
using E_Commerce.Applications.Contracts;
using E_Commerce.Applications.Services;
using E_Commerce.Applications.Mapper;
using E_Commerce.Domain.Dtos;
using E_Commerce.Domain.Enums;
using E_Commerce.Domain.Models;
using E_Commerce.Infrastructure.Context;
using E_Commerce.Infrastructure.Repositories;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using E_Commerce.Domain.Dtos.OrdersDto;
using Microsoft.VisualBasic.ApplicationServices;
using User = E_Commerce.Domain.Models.User;
using System.Net;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace E_Commerce.Presentation
{
    public partial class Form1 : Form
    {
        int CategoryId = 0;
        //public List<DisplayCategoryDto> Categories;
        IMapper mapper;
        CategoryService categoryService = new CategoryService(new CategoryRepository(new ApplicationDbContext()));
        ProductService productService = new ProductService(new ProductRepository(new ApplicationDbContext()));
        UserService userService = new UserService(new UserRepository(new ApplicationDbContext()));
        OrderService orderService = new OrderService(new OrderRepository(new ApplicationDbContext()));
        public Form1()
        {
            InitializeComponent();
            //Categories = GetCategories();
            BindOrders();
            BindCategories();
            BindProducts();
        }
        private List<DisplayOrderDto> GetOrders()
        {
            mapper = Mapping.MappingDisplayAllOrders();
            List<DisplayOrderDto> displayOrderDtos = mapper.Map<List<DisplayOrderDto>>(orderService.GetAllOrders().ToList());

            return displayOrderDtos;
            #region smulate orders
            //return new List<DisplayOrderDto>
            //{
            //	new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
            //	new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Confirmed},
            //	new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
            //	new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
            //	new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
            //	new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending},
            //	new DisplayOrderDto{Email="test@gmail.com",FullName="test test",FinalPrice=14.14m,OrderDate=DateTime.Now, OrderState = OrderState.Pending}
            //};
            #endregion
        }

        private List<DisplayCategoryDto> GetCategories()
        {
            mapper = Mapping.MappingDisplayCategory();
            List<DisplayCategoryDto> Categories = mapper.Map<List<DisplayCategoryDto>>(categoryService.GetCategories().ToList());
            return Categories;

        }

        private List<DisplayProductDto> GetProducts()
        {
            #region smulate products
            //return new List<DisplayProductDto>
            //{
            //	new DisplayProductDto{Name="Product1",Image=@"F:\ITI\FullStack\9-Visual C#\Project\E-Commerce\E-Commerce.Presentation\Images\avater.jpg",Price=200,CategoryName="Category1" },
            //	new DisplayProductDto{Name="Product2",Image=@"F:\ITI\FullStack\9-Visual C#\Project\E-Commerce\E-Commerce.Presentation\Images\avater.jpg",Price=500,CategoryName="Category2"},
            //	new DisplayProductDto{Name="Product3",Image=@"F:\ITI\FullStack\9-Visual C#\Project\E-Commerce\E-Commerce.Presentation\Images\avater.jpg",Price=270,CategoryName="Category3"},
            //	new DisplayProductDto{Name="Product4",Image=@"F:\ITI\FullStack\9-Visual C#\Project\E-Commerce\E-Commerce.Presentation\Images\avater.jpg",Price=300,CategoryName="Category4"},
            //	new DisplayProductDto{Name="Product5",Image=@"F:\ITI\FullStack\9-Visual C#\Project\E-Commerce\E-Commerce.Presentation\Images\avater.jpg",Price=150,CategoryName="Category5"},
            //	new DisplayProductDto{Name="Product6",Image=@"F:\ITI\FullStack\9-Visual C#\Project\E-Commerce\E-Commerce.Presentation\Images\avater.jpg",Price=250,CategoryName="Category6"}
            //};
            #endregion
            mapper = Mapping.MappingDisplayProduct();
            List<DisplayProductDto> Products = mapper.Map<List<DisplayProductDto>>(productService.GetProducts().ToList());
            return Products;
        }

        private void BindOrders()
        {
            var orders = GetOrders();
            DataGridViewComboBoxColumn comboBoxColumn = dgrViewOrders.Columns["State"] as DataGridViewComboBoxColumn;
            comboBoxColumn.DataSource = Enum.GetValues(typeof(OrderState));

            foreach (DataGridViewColumn column in dgrViewOrders.Columns)
            {
                if (column != dgrViewOrders.Columns["State"])
                    column.ReadOnly = true;
            }

            dgrViewOrders.DataSource = orders;
            dgrViewOrders.CellValueChanged += DgrViewOrders_CellValueChanged;
        }
        private void DgrViewOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgrViewOrders.Columns["State"].Index && e.RowIndex >= 0)
            {
                var changedRow = dgrViewOrders.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(changedRow.Cells["ID"].Value);
                int userId = Convert.ToInt32(changedRow.Cells["UserID"].Value);
                OrderState orderState = (OrderState)changedRow.Cells["State"].Value;
                orderService.ChangeTheStautsOfOrder(orderId, userId, orderState);
            }
        }
        private void BindCategories()
        {
            dataGridViewCategory.DataSource = GetCategories();
        }
        public void BindProducts()
        {
            flowLayoutPanel1.Controls.Clear();
            var Products = GetProducts();
            foreach (var p in Products)
            {
                ProductControl prodductControl = new ProductControl();
                prodductControl.Id = p.Id;
                prodductControl.pname = p.Name;
                prodductControl.Price = p.Price;
                prodductControl.Quantity = p.Quantity;
                prodductControl.CategoryName = p.CategoryName;
                using (WebClient webClient = new WebClient())
                {
                    byte[] data = webClient.DownloadData(p.Image);
                    using (var stream = new System.IO.MemoryStream(data))
                    {
                        prodductControl.image = Image.FromStream(stream);
                    }
                }
                //prodductControl.image = Image.FromFile(p.Image);
                prodductControl.EduitProduct += BindProducts;
                flowLayoutPanel1.Controls.Add(prodductControl);
            }
        }

        private void isRequired(Label label)
        {
            label.Visible = true;
            label.Text = "Field is Required";
        }
        private void isValid(Label label, string message)
        {
            label.Visible = true;
            label.Text = message;
        }

        private void AddAdminBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = AddAdminPage;
        }

        private void FullNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTxt.Text))
            {
                isRequired(ErrorFullName);
            }
            else if (!FullNameTxt.Text.All(char.IsLetter))
            {
                isValid(ErrorFullName, "Name is not valid!");
            }
            else
                ErrorFullName.Visible = false;
        }

        private void EmailTxt_TextChanged(object sender, EventArgs e)
        {
            bool isValidEmail = Regex.IsMatch(EmailTxt.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            if (string.IsNullOrEmpty(EmailTxt.Text))
            {
                isRequired(ErrorEmail);
            }
            else if (!isValidEmail)
            {
                isValid(ErrorEmail, "Email Address is not valid!");
            }
            else
                ErrorEmail.Visible = false;
        }

        private void PhoneNumberTxt_TextChanged(object sender, EventArgs e)
        {
            bool isValidPhoneNumber = Regex.IsMatch(PhoneNumberTxt.Text, @"^[0-9]+$");
            if (string.IsNullOrEmpty(PhoneNumberTxt.Text))
            {
                isRequired(ErrorPhoneNumber);
            }
            else if (!isValidPhoneNumber)
            {
                isValid(ErrorPhoneNumber, "Phone Number is not valid!");
            }
            else if (PhoneNumberTxt.Text.Length != 11)
            {
                isValid(ErrorPhoneNumber, "PhoneNumber Must be 11 Numbers");
            }
            else
                ErrorPhoneNumber.Visible = false;
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            bool isValidPassword = Regex.IsMatch(PasswordTxt.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
            if (string.IsNullOrEmpty(PasswordTxt.Text))
            {
                isRequired(ErrorPassword);
            }
            else if (!isValidPassword)
            {
                isValid(ErrorPassword, "Please Enter Strong Password");
            }
            else
                ErrorPassword.Visible = false;
        }

        private void ConfirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ConfirmPasswordTxt.Text))
            {
                isRequired(ErrorConfirmPassword);
            }
            else if (ConfirmPasswordTxt.Text != PasswordTxt.Text)
            {
                isValid(ErrorConfirmPassword, "Password and Confirm Password Not Match!");
            }
            else
                ErrorConfirmPassword.Visible = false;
        }

        private void CreateAdminbtn_Click(object sender, EventArgs e)
        {
            bool isInValidData = AddAdminPage.Controls.OfType<TextBox>().Any(e => e.Text == "");
            bool allLabelsNotVisible = AddAdminPage.Controls.OfType<Label>().All(label => !label.Visible);
            if (allLabelsNotVisible && !isInValidData)
            {
                AddAdminDto addAdmin = new AddAdminDto
                {
                    Email = EmailTxt.Text,
                    Name = FullNameTxt.Text,
                    Password = PasswordTxt.Text,
                    PhoneNumber = PhoneNumberTxt.Text
                };
                mapper = Mapping.MappingAddAdmin();
                User admin = mapper.Map<User>(addAdmin);
                admin = userService.UserRegister(admin);
                if (admin is not null)
                {
                    //send this dto to service to add it;
                    MessageBox.Show("Admin Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    foreach (TextBox textBox in AddAdminPage.Controls.OfType<TextBox>())
                    {
                        textBox.Text = "";
                    }
                    foreach (Label label in AddAdminPage.Controls.OfType<Label>())
                    {
                        label.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("This Email is Already Exist!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Complete Data!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = OrdersPage;
        }
        private void productBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = ProductsPage;
        }
        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = CategoriesPage;
        }


        //Category
        private void buttonAddc_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (!string.IsNullOrEmpty(name))
            {
                Category category = new Category { Name = name };
                category = categoryService.CreateCategory(category);
                if (category is not null)
                {
                    MessageBox.Show("Category Added Succesfully");
                    BindCategories();
                }
                else
                {
                    MessageBox.Show("This Category is Already Exist");
                }
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Category Name is Required!");
            }

        }


        private async void buttonUpc_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            if (!string.IsNullOrEmpty(name))
            {
                Category category = new Category { ID = CategoryId, Name = name };
                bool canDelete = categoryService.UpdateCategory(category, CategoryId);
                if (canDelete)
                {
                    MessageBox.Show("Category Updated Succesfully");
                    BindCategories();
                }
                else
                {
                    MessageBox.Show("This Category is Already Exist");
                }
                CategoryId = 0;
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Category Name is Required!");
            }


        }

        private async void buttonDelc_Click(object sender, EventArgs e)
        {
            if (CategoryId != 0)
            {
                DialogResult result = MessageBox.Show("Are you Sure you want delete this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool canDelete = categoryService.DeleteCategory(new Category { ID = CategoryId, Name = textBox1.Text }, CategoryId);
                    if (canDelete)
                    {
                        MessageBox.Show("Category is Deleted");
                        BindCategories();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong");
                    }
                    textBox1.Text = "";
                    CategoryId = 0;
                }
                else
                {
                    MessageBox.Show("Select Category To Delete");
                }
            }
        }

        private void dataGridViewSelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCategory.SelectedRows[0];
                int.TryParse(selectedRow.Cells[0].Value.ToString(), out CategoryId);
                textBox1.Text = selectedRow.Cells[1].Value.ToString();
            }
        }
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProdct formAddProdct = new FormAddProdct();
            formAddProdct.ShowDialog();
            BindProducts();
        }

        private void SClick(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (!string.IsNullOrEmpty(name))
            {
                Category categorey = categoryService.GetByName(name);
                if (categorey is null)
                {
                    MessageBox.Show("This Category Not Found");
                }
                else
                {
                    dataGridViewCategory.DataSource = new List<Category> { categorey };
                }
            }
            else
            {
                BindCategories();
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.userAuthentication = false;
            Home home = new Home();
            home.Show();
        }
    }
}