using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    partial class MainScreen
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
            AddPart = new Button();
            AddProduct = new Button();
            PartGroupBox = new GroupBox();
            SearchPartTxt = new TextBox();
            SearchPart = new Button();
            Label1 = new Label();
            PartDataGridView = new DataGridView();
            ModifyPart = new Button();
            DeletePart = new Button();
            ProductGroupBox = new GroupBox();
            ProductDataGridView = new DataGridView();
            ModifyProduct = new Button();
            DeleteProduct = new Button();
            ExitBtn = new Button();
            TitleLabel = new Label();
            PartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PartDataGridView).BeginInit();
            ProductGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddPart
            // 
            AddPart.Location = new Point(223, 302);
            AddPart.Name = "AddPart";
            AddPart.Size = new Size(75, 23);
            AddPart.TabIndex = 1;
            AddPart.Text = "Add";
            AddPart.UseVisualStyleBackColor = true;
            AddPart.Click += AddPart_Click;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(223, 302);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(75, 23);
            AddProduct.TabIndex = 5;
            AddProduct.Text = "Add";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // PartGroupBox
            // 
            PartGroupBox.Controls.Add(SearchPartTxt);
            PartGroupBox.Controls.Add(SearchPart);
            PartGroupBox.Controls.Add(Label1);
            PartGroupBox.Controls.Add(PartDataGridView);
            PartGroupBox.Controls.Add(ModifyPart);
            PartGroupBox.Controls.Add(DeletePart);
            PartGroupBox.Controls.Add(AddPart);
            PartGroupBox.Location = new Point(12, 32);
            PartGroupBox.Name = "PartGroupBox";
            PartGroupBox.Size = new Size(466, 342);
            PartGroupBox.TabIndex = 4;
            PartGroupBox.TabStop = false;
            PartGroupBox.Text = "Part";
            // 
            // SearchPartTxt
            // 
            SearchPartTxt.Location = new Point(320, 17);
            SearchPartTxt.Name = "SearchPartTxt";
            SearchPartTxt.Size = new Size(140, 20);
            SearchPartTxt.TabIndex = 5;
            SearchPartTxt.TextChanged += SearchPartTxt_TextChanged;
            // 
            // SearchPart
            // 
            SearchPart.Location = new Point(239, 15);
            SearchPart.Name = "SearchPart";
            SearchPart.Size = new Size(75, 23);
            SearchPart.TabIndex = 4;
            SearchPart.Text = "Search";
            SearchPart.UseVisualStyleBackColor = true;
            SearchPart.Click += SearchPart_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(13, 307);
            Label1.Name = "Label1";
            Label1.Size = new Size(0, 13);
            Label1.TabIndex = 3;
            // 
            // PartDataGridView
            // 
            PartDataGridView.AllowUserToAddRows = false;
            PartDataGridView.AllowUserToDeleteRows = false;
            PartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PartDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            PartDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartDataGridView.GridColor = SystemColors.ControlDark;
            PartDataGridView.Location = new Point(6, 46);
            PartDataGridView.Name = "PartDataGridView";
            PartDataGridView.ReadOnly = true;
            PartDataGridView.RowTemplate.Height = 25;
            PartDataGridView.Size = new Size(454, 250);
            PartDataGridView.TabIndex = 0;
            PartDataGridView.CellContentClick += PartDataGridView_CellContentClick;
            // 
            // ModifyPart
            // 
            ModifyPart.Location = new Point(304, 302);
            ModifyPart.Name = "ModifyPart";
            ModifyPart.Size = new Size(75, 23);
            ModifyPart.TabIndex = 2;
            ModifyPart.Text = "Modify";
            ModifyPart.UseVisualStyleBackColor = true;
            ModifyPart.Click += ModifyPart_Click;
            // 
            // DeletePart
            // 
            DeletePart.Location = new Point(385, 302);
            DeletePart.Name = "DeletePart";
            DeletePart.Size = new Size(75, 23);
            DeletePart.TabIndex = 0;
            DeletePart.Text = "Delete";
            DeletePart.UseVisualStyleBackColor = true;
            DeletePart.Click += DeletePart_Click;
            // 
            // ProductGroupBox
            // 
            ProductGroupBox.Controls.Add(ProductDataGridView);
            ProductGroupBox.Controls.Add(ModifyProduct);
            ProductGroupBox.Controls.Add(DeleteProduct);
            ProductGroupBox.Controls.Add(AddProduct);
            ProductGroupBox.Location = new Point(485, 33);
            ProductGroupBox.Name = "ProductGroupBox";
            ProductGroupBox.Size = new Size(466, 342);
            ProductGroupBox.TabIndex = 6;
            ProductGroupBox.TabStop = false;
            ProductGroupBox.Text = "Product";
            // 
            // ProductDataGridView
            // 
            ProductDataGridView.AllowUserToAddRows = false;
            ProductDataGridView.AllowUserToDeleteRows = false;
            ProductDataGridView.BackgroundColor = SystemColors.AppWorkspace;
            ProductDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataGridView.GridColor = SystemColors.ControlDark;
            ProductDataGridView.Location = new Point(6, 46);
            ProductDataGridView.Name = "ProductDataGridView";
            ProductDataGridView.ReadOnly = true;
            ProductDataGridView.RowTemplate.Height = 25;
            ProductDataGridView.Size = new Size(454, 250);
            ProductDataGridView.TabIndex = 0;
            // 
            // ModifyProduct
            // 
            ModifyProduct.Location = new Point(304, 302);
            ModifyProduct.Name = "ModifyProduct";
            ModifyProduct.Size = new Size(75, 23);
            ModifyProduct.TabIndex = 4;
            ModifyProduct.Text = "Modify";
            ModifyProduct.UseVisualStyleBackColor = true;
            ModifyProduct.Click += ModifyProduct_Click;
            // 
            // DeleteProduct
            // 
            DeleteProduct.Location = new Point(385, 302);
            DeleteProduct.Name = "DeleteProduct";
            DeleteProduct.Size = new Size(75, 23);
            DeleteProduct.TabIndex = 3;
            DeleteProduct.Text = "Delete";
            DeleteProduct.UseVisualStyleBackColor = true;
            DeleteProduct.Click += DeleteProduct_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(875, 378);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 23);
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(12, 13);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(153, 13);
            TitleLabel.TabIndex = 7;
            TitleLabel.Text = "Inventory Management System";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 413);
            Controls.Add(TitleLabel);
            Controls.Add(ExitBtn);
            Controls.Add(PartGroupBox);
            Controls.Add(ProductGroupBox);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainScreen";
            Text = "Main Screen";
            Load += MainScreen_Load;
            PartGroupBox.ResumeLayout(false);
            PartGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PartDataGridView).EndInit();
            ProductGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddPart;
        private Button AddProduct;
        private GroupBox PartGroupBox;
        private GroupBox ProductGroupBox;
        private Button DeletePart;
        private Button DeleteProduct;
        private Button ExitBtn;
        private Button ModifyPart;
        private Button ModifyProduct;
        private DataGridView PartDataGridView;
        private Label Label1;
        private DataGridView ProductDataGridView;
        private Button SearchPart;
        private TextBox SearchPartTxt;
        private Label TitleLabel;
    }
}