using Infra.Context;
using Infra.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCategoryList();
            LoadCategories();
        }

        private void InitializeCategoryList()
        {
            using (var context = new DataContext())
            {
                comboBoxCategory.DataSource = context.Categories.ToList();
                comboBoxCategory.DisplayMember = "Title";
                comboBoxCategory.ValueMember = "Id";
            }
        }
        private void LoadCategories()
        {
            using (var context = new DataContext())
            {
                var products = from prd in context.Products
                               select new
                               {
                                   prd.Id,
                                   prd.Name,
                                   Category = prd.Category.Title
                               };
                dataGridProduct.DataSource = products.ToList();
                dataGridProduct.Columns[0].Width = 30;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(labelProductId.Text);
            using (var context = new DataContext())
            {
                if (productId == 0)
                {
                    Product product = new Product
                    {
                        Name = textBoxProductName.Text,
                        CategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue)
                    };
                    context.Products.Add(product);
                }
                else
                {
                    var productToUpdate = context.Products.SingleOrDefault(prd => prd.Id == productId);
                    if (productToUpdate != null)
                    {
                        productToUpdate.Name = textBoxProductName.Text;
                        productToUpdate.CategoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);
                    }
                }
                context.SaveChanges();
            }
            MessageBox.Show(this, "Product saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategories();
        }

        private void dataGridProduct_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dataGridProduct.SelectedRows.Count > 0)
                selectedRow = dataGridProduct.SelectedRows[0];

            if (selectedRow == null)
                return;
            labelProductId.Text = selectedRow.Cells["Id"].Value.ToString();
            textBoxProductName.Text = selectedRow.Cells["Name"].Value.ToString();
            comboBoxCategory.SelectedIndex = comboBoxCategory.FindStringExact(selectedRow.Cells["Category"].Value.ToString());
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelProductId.Text = "";
            textBoxProductName.Text = string.Empty;
            comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            FormManageCategory formManageCategory = new FormManageCategory()
            {
                RefreshCategoryList = InitializeCategoryList
            };
            formManageCategory.Show(this);
        }
    }
}
