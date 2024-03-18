using E_Commerce.Applications.Services;
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
    public partial class ProductDisplayControl : UserControl
    {
        public event Action<int> ADDProductIdToCart;
        public static int counter;
        private int _id;
        private string? _name;
        private string? _categoryName;
        private Image _image;
        private decimal _price;
        private int _quantity;
        public ProductDisplayControl()
        {
            InitializeComponent();
            counter = 0;
            //home= new Home();
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
        //[Category("CustomProps")]

        //public string? CategoryName
        //{
        //    get { return _categoryName; }
        //    set { _categoryName = value; label3.Text = value; }
        //}

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
            set { _price = value; label2.Text =value.ToString("C"); }
        }
        [Category("CustomProps")]
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Program.userAuthentication)
            {
                ADDProductIdToCart(_id);
            }
            else
            {

                MessageBox.Show("Register or Login First");
            }

        }
    }
}
