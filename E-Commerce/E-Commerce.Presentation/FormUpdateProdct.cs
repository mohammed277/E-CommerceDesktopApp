using AutoMapper;
using E_Commerce.Applications.Mapper;
using E_Commerce.Applications.Services;
using E_Commerce.Domain.Models;
using E_Commerce.Infrastructure.Context;
using E_Commerce.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Presentation
{
    public partial class FormUpdateProdct : Form
    {
        public int upId = 0;
        ProductService productService = new ProductService(new ProductRepository(new ApplicationDbContext()));

        public Product Upproduct;
        string path2 = " ";
        CategoryService categoryService = new CategoryService(new CategoryRepository(new ApplicationDbContext()));
        IMapper mapper = Mapping.MappingAddProduct();
        public FormUpdateProdct(int upId)
        {
            InitializeComponent();
            BindCategories();
            
            this.upId = upId;
        }
       
        private bool checkAllInput()
        {
            return !string.IsNullOrEmpty(textBoxPname.Text) &&
                   !string.IsNullOrEmpty(txtProductDescription.Text) &&
                   !string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()) &&
                   !string.IsNullOrEmpty(textBoxprice.Text) &&
                   !string.IsNullOrEmpty(numericUpDown1.Value.ToString());
        }
        private void BindCategories()
        {
            var categories = categoryService.GetCategories().ToList();

            comboBox1.DataSource = categories;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C://Desktop";
            openFileDialog1.Title = "Select image to be upload.";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|" +
            "*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        path2 = openFileDialog1.FileName;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkAllInput())
            {
                Category categorySelected = (Category)comboBox1.SelectedItem;
                Upproduct = productService.GetProduct(this.upId);
                Upproduct.Name = textBoxPname.Text;
                Upproduct.Description = txtProductDescription.Text;
                Upproduct.Price = decimal.Parse(textBoxprice.Text);
                Upproduct.Quantity = (int)numericUpDown1.Value;
                Upproduct.Image = path2;
                categoryService.AssignProductToCatgeory(categorySelected,Upproduct);
                //Product product = mapper.Map<Product>(prod);
                // Products.Controls.Add(prod);
                path2 = " ";
                this.Hide();
            }
            else
                MessageBox.Show("Complete Data");
        }
    }
}
