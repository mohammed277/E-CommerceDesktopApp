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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Commerce.Presentation
{
	public partial class ProductControl : UserControl
	{
		private int _id;
		private string? _name;
		private string? _categoryName;
		private Image _image;
		private decimal _price;
		private int _quantity;
        ProductService productService = new ProductService(new ProductRepository(new ApplicationDbContext()));

        public event Action EduitProduct;
        public ProductControl()
		{
			InitializeComponent();
		}
		[Category("CustomProps")]
		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		[Category("CustomProps")]

		public string? pname
		{
			get { return _name; }
			set { _name = value; label1.Text = value; }
		}
		[Category("CustomProps")]

		public string? CategoryName
		{
			get { return _categoryName; }
			set { _categoryName = value; label4.Text = value; }
		}

		[Category("CustomProps")]
		public Image image
		{
			get { return _image; }
			set { _image = value; pictureBox1.Image = value; }
		}
		[Category("CustomProps")]
		public decimal Price
		{
			get { return _price; }
			set { _price = value; label5.Text = " " + value + " $"; }
		}
		[Category("CustomProps")]
		public int Quantity
		{
			get { return _quantity; }
			set
			{
				_quantity = value;
				label6.Text = " " + value;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
		    FormUpdateProdct formUpdateProdct = new FormUpdateProdct(_id);
            formUpdateProdct.ShowDialog();
            var x = productService.UpdateProduct(formUpdateProdct.Upproduct,formUpdateProdct.upId);
           
			if (x)
			{
				EduitProduct();
				MessageBox.Show(" product had been Updated ");
			}
			
        }

        private void button2_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you Sure you want delete this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Product p = productService.GetProduct(_id);
				var x = productService.DeleteProduct(p, _id);
				if (x)
				{
					EduitProduct();
					MessageBox.Show(" product had been Deleted ");
				}
			}

        }
    }
}
