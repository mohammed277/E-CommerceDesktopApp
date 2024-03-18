using AutoMapper;
using E_Commerce.Applications.Mapper;
using E_Commerce.Applications.Services;
using E_Commerce.Domain.Dtos;
using E_Commerce.Domain.Models;
using E_Commerce.Infrastructure.Context;
using E_Commerce.Infrastructure.Repositories;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace E_Commerce.Presentation
{
	public partial class FormAddProdct : Form
	{
		string path2 = " ";
		ProductService productService = new ProductService(new ProductRepository(new ApplicationDbContext()));
		CategoryService categoryService = new CategoryService(new CategoryRepository(new ApplicationDbContext()));
		IMapper mapper = Mapping.MappingAddProduct();
		public FormAddProdct()
		{
			InitializeComponent();
			BindCategories();
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
		private void buttonSaveAddproduct_Click(object sender, EventArgs e)
		{
			if (checkAllInput())
			{
				Category categorySelected = (Category)comboBox1.SelectedItem;
				Product product = new Product();
				product.Name = textBoxPname.Text;
				product.Description = txtProductDescription.Text;
				product.Price = decimal.Parse(textBoxprice.Text);
				product.Quantity = (int)numericUpDown1.Value;
				product.Image = path2;
				product.CategoryId = categorySelected.ID;
				productService.CreateProduct(product);
				//categoryService.AssignProductToCatgeory(categorySelected, product);
				//Product product = mapper.Map<Product>(prod);
				// Products.Controls.Add(prod);
				path2 = " ";
				this.Hide();
			}
			else
				MessageBox.Show("Complete Data");
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
						// string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
						pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
						pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
						path2 = openFileDialog1.FileName;
						//MessageBox.Show(path2);
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
	}
}

