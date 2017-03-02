namespace EFDemo
{
    partial class FormManageCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridCategory = new System.Windows.Forms.DataGridView();
            this.labelCategoryList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCategoryClear = new System.Windows.Forms.Button();
            this.buttonSaveCategory = new System.Windows.Forms.Button();
            this.labelCategoryId = new System.Windows.Forms.Label();
            this.textBoxCategoryTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCategory
            // 
            this.dataGridCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCategory.Location = new System.Drawing.Point(12, 171);
            this.dataGridCategory.Name = "dataGridCategory";
            this.dataGridCategory.RowTemplate.Height = 24;
            this.dataGridCategory.Size = new System.Drawing.Size(416, 215);
            this.dataGridCategory.TabIndex = 0;
            this.dataGridCategory.SelectionChanged += new System.EventHandler(this.dataGridCategory_SelectionChanged);
            // 
            // labelCategoryList
            // 
            this.labelCategoryList.AutoSize = true;
            this.labelCategoryList.Location = new System.Drawing.Point(17, 150);
            this.labelCategoryList.Name = "labelCategoryList";
            this.labelCategoryList.Size = new System.Drawing.Size(91, 17);
            this.labelCategoryList.TabIndex = 1;
            this.labelCategoryList.Text = "Category List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCategoryClear);
            this.panel1.Controls.Add(this.buttonSaveCategory);
            this.panel1.Controls.Add(this.labelCategoryId);
            this.panel1.Controls.Add(this.textBoxCategoryTitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 131);
            this.panel1.TabIndex = 2;
            // 
            // buttonCategoryClear
            // 
            this.buttonCategoryClear.Location = new System.Drawing.Point(343, 51);
            this.buttonCategoryClear.Name = "buttonCategoryClear";
            this.buttonCategoryClear.Size = new System.Drawing.Size(58, 23);
            this.buttonCategoryClear.TabIndex = 5;
            this.buttonCategoryClear.Text = "Clear";
            this.buttonCategoryClear.UseVisualStyleBackColor = true;
            this.buttonCategoryClear.Click += new System.EventHandler(this.buttonCategoryClear_Click);
            // 
            // buttonSaveCategory
            // 
            this.buttonSaveCategory.Location = new System.Drawing.Point(113, 88);
            this.buttonSaveCategory.Name = "buttonSaveCategory";
            this.buttonSaveCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveCategory.TabIndex = 4;
            this.buttonSaveCategory.Text = "Save";
            this.buttonSaveCategory.UseVisualStyleBackColor = true;
            this.buttonSaveCategory.Click += new System.EventHandler(this.buttonSaveCategory_Click);
            // 
            // labelCategoryId
            // 
            this.labelCategoryId.AutoSize = true;
            this.labelCategoryId.Location = new System.Drawing.Point(113, 17);
            this.labelCategoryId.Name = "labelCategoryId";
            this.labelCategoryId.Size = new System.Drawing.Size(16, 17);
            this.labelCategoryId.TabIndex = 3;
            this.labelCategoryId.Text = "0";
            this.labelCategoryId.Visible = false;
            // 
            // textBoxCategoryTitle
            // 
            this.textBoxCategoryTitle.Location = new System.Drawing.Point(113, 51);
            this.textBoxCategoryTitle.Name = "textBoxCategoryTitle";
            this.textBoxCategoryTitle.Size = new System.Drawing.Size(224, 22);
            this.textBoxCategoryTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Id";
            this.label1.Visible = false;
            // 
            // FormManageCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCategoryList);
            this.Controls.Add(this.dataGridCategory);
            this.Name = "FormManageCategory";
            this.Text = "Category Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageCategory_FormClosed);
            this.Load += new System.EventHandler(this.FormManageCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCategory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCategory;
        private System.Windows.Forms.Label labelCategoryList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCategoryId;
        private System.Windows.Forms.TextBox textBoxCategoryTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveCategory;
        private System.Windows.Forms.Button buttonCategoryClear;
    }
}