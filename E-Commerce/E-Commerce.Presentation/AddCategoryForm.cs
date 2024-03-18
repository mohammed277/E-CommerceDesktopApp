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
	public partial class AddCategoryForm : Form
	{
		CategoryService categoryService = new CategoryService(new CategoryRepository(new ApplicationDbContext()));
		public event Action<int> CategoryAdded;
		string _state;
		int _categoryId;
		public AddCategoryForm()
		{
			InitializeComponent();
		}
		public AddCategoryForm(string state,int categoryId=0)
		{
			_state = state;
			_categoryId = categoryId;
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			string name = categorynameTxt.Text;
			if (_state == "Add")
			{
				if (!string.IsNullOrEmpty(name))
				{
					Category category = new Category { Name = name };
					category = categoryService.CreateCategory(category);
					if (category is not null)
					{
						MessageBox.Show("Category Added Succesfully");
						CategoryAdded.Invoke(1);
						this.Hide();
					}
					else
					{
						MessageBox.Show("This Category is Already Exist");
					}
					categorynameTxt.Text = "";
				}
				else
				{
					MessageBox.Show("Category Name is Required!");
				}
			}
			else
			{
				if (!string.IsNullOrEmpty(name))
				{
					Category category = new Category { ID = _categoryId, Name = name };
					bool canUpdate = categoryService.UpdateCategory(category, _categoryId);
					if (canUpdate)
					{
						MessageBox.Show("Category Updated Succesfully");
						CategoryAdded.Invoke(1);
						this.Hide();
					}
					else
					{
						MessageBox.Show("This Category is Already Exist");
					}
				}
				else
				{
					MessageBox.Show("Category Name is Required!");
				}
			}
		}
	}
}
