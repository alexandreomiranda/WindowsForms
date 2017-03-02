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
    public delegate void RefreshCategoryListDelegate();

    public partial class FormManageCategory : Form
    {
        public RefreshCategoryListDelegate RefreshCategoryList;

        public FormManageCategory()
        {
            InitializeComponent();
        }

        private void InitializeCategoryList()
        {
            using (var context = new DataContext())
            {
                var categories = from cat in context.Categories
                               select new
                               {
                                   cat.Id,
                                   cat.Title
                               };
                dataGridCategory.DataSource = categories.ToList();
                dataGridCategory.Columns[0].Width = 30;
            }
        }

        private void FormManageCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (RefreshCategoryList != null)
                RefreshCategoryList();
        }

        private void buttonCategoryClear_Click(object sender, EventArgs e)
        {
            labelCategoryId.Text = "0";
            textBoxCategoryTitle.Text = string.Empty;
        }

        private bool IsValid(string title)
        {
            using (var context = new DataContext())
            {
                if (context.Categories.Any(cat => cat.Title == title))
                    return false;
            }
            return true;
        }

        private void buttonSaveCategory_Click(object sender, EventArgs e)
        {
            int categoryId = Convert.ToInt32(labelCategoryId.Text);

            if (!IsValid(textBoxCategoryTitle.Text))
            {
                MessageBox.Show(this, "Category already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var context = new DataContext())
            {
                if (categoryId == 0)
                {
                    Category category = new Category
                    {
                        Title = textBoxCategoryTitle.Text
                    };
                    context.Categories.Add(category);
                }
                else
                {
                    var categoryToUpdate = context.Categories.SingleOrDefault(category => category.Id == categoryId);
                    if (categoryToUpdate != null)
                    {
                        categoryToUpdate.Title = textBoxCategoryTitle.Text;
                    }
                }
                context.SaveChanges();
            }
            MessageBox.Show(this, "Category saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitializeCategoryList();
        }

        private void dataGridCategory_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;

            if (dataGridCategory.SelectedRows.Count > 0)
                selectedRow = dataGridCategory.SelectedRows[0];

            if (selectedRow == null)
                return;
            labelCategoryId.Text = selectedRow.Cells["Id"].Value.ToString();
            textBoxCategoryTitle.Text = selectedRow.Cells["Title"].Value.ToString();
        }

        private void FormManageCategory_Load(object sender, EventArgs e)
        {
            InitializeCategoryList();
        }
    }
}
