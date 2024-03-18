using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace E_Commerce.Presentation
{
    public partial class CartItems : UserControl
    {
        public event Action<int> RemoveProductIdToCart;
        private int _id;
        private string? _title;
        private string? _description;
        private System.Drawing.Image _image;
        private decimal _price;
        private int _amount;
        private decimal _productTotal;
        private int _quantity;
        public CartItems()
        {
            InitializeComponent();
            _amount = 1;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public System.Drawing.Image image
        {
            get { return _image; }
            set { _image = value; pictureBox1.Image = value; }
        }


        public string? Title { get => _title; set { _title = value; CartTitlelbl.Text = value; } }
        public string? Description { get => _description; set { _description = value; CartDescriptionlbl.Text = value; } }
        public int Amount { get => _amount; set { _amount = value; } }
        public decimal ProductTotal { get => _amount * _price;  }
        public decimal Price { get => _price; set { _price = value; CartPricelbl.Text = value.ToString(); } }
        public int Quantity { get => _quantity; set { _quantity = value; Quantitylbl.Text = 1.ToString(); } }

        private void label1_Click(object sender, EventArgs e)
        {
            RemoveProductIdToCart(_id);
        }
        private void IncreaseCartbtn_Click(object sender, EventArgs e)
        {
            if (_amount < _quantity)
            {
                _amount += 1;
                Quantitylbl.Text = _amount.ToString();
            }

            _productTotal= _amount*_price;
            CartPricelbl.Text= (_productTotal).ToString();
            
        }

        private void DecreaseCartbtn_Click(object sender, EventArgs e)
        {
            if (_amount > 1)
            {
                _amount -= 1;
                Quantitylbl.Text = _amount.ToString();
            }

            _productTotal = _amount * _price;
            CartPricelbl.Text = (_productTotal).ToString();
        }

    }
}
