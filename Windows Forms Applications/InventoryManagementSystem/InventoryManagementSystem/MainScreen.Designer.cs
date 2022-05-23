/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

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
			this.partGrpBox = new System.Windows.Forms.GroupBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.SearchPartTxt = new System.Windows.Forms.TextBox();
			this.SearchPartBtn = new System.Windows.Forms.Button();
			this.PartDGV = new System.Windows.Forms.DataGridView();
			this.deletePart = new System.Windows.Forms.Button();
			this.addPart = new System.Windows.Forms.Button();
			this.modifyPart = new System.Windows.Forms.Button();
			this.productGrpBox = new System.Windows.Forms.GroupBox();
			this.addProduct = new System.Windows.Forms.Button();
			this.modifyProduct = new System.Windows.Forms.Button();
			this.deleteProduct = new System.Windows.Forms.Button();
			this.SearchProductBtn = new System.Windows.Forms.Button();
			this.SearchProductTxt = new System.Windows.Forms.TextBox();
			this.ProductDGV = new System.Windows.Forms.DataGridView();
			this.exitBtn = new System.Windows.Forms.Button();
			this.titleLbl = new System.Windows.Forms.Label();
			this.partGrpBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PartDGV)).BeginInit();
			this.productGrpBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).BeginInit();
			this.SuspendLayout();
			// 
			// partGrpBox
			// 
			this.partGrpBox.Controls.Add(this.Label1);
			this.partGrpBox.Controls.Add(this.SearchPartTxt);
			this.partGrpBox.Controls.Add(this.SearchPartBtn);
			this.partGrpBox.Controls.Add(this.PartDGV);
			this.partGrpBox.Controls.Add(this.deletePart);
			this.partGrpBox.Controls.Add(this.addPart);
			this.partGrpBox.Controls.Add(this.modifyPart);
			this.partGrpBox.Location = new System.Drawing.Point(12, 32);
			this.partGrpBox.Name = "partGrpBox";
			this.partGrpBox.Size = new System.Drawing.Size(466, 342);
			this.partGrpBox.TabIndex = 4;
			this.partGrpBox.TabStop = false;
			this.partGrpBox.Text = "Part";
			// 
			// label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(13, 307);
			this.Label1.Name = "label1";
			this.Label1.Size = new System.Drawing.Size(0, 13);
			this.Label1.TabIndex = 6;
			// 
			// searchPartTxt
			// 
			this.SearchPartTxt.Location = new System.Drawing.Point(320, 17);
			this.SearchPartTxt.Name = "searchPartTxt";
			this.SearchPartTxt.Size = new System.Drawing.Size(140, 20);
			this.SearchPartTxt.TabIndex = 5;
			this.SearchPartTxt.TextChanged += new System.EventHandler(this.SearchPartTxt_TextChanged);
			// 
			// searchPartBtn
			// 
			this.SearchPartBtn.Location = new System.Drawing.Point(239, 15);
			this.SearchPartBtn.Name = "searchPartBtn";
			this.SearchPartBtn.Size = new System.Drawing.Size(75, 23);
			this.SearchPartBtn.TabIndex = 4;
			this.SearchPartBtn.Text = "Search";
			this.SearchPartBtn.UseVisualStyleBackColor = true;
			this.SearchPartBtn.Click += new System.EventHandler(this.SearchPartBtn_Click);
			// 
			// partDGV
			// 
			this.PartDGV.AllowUserToAddRows = false;
			this.PartDGV.AllowUserToDeleteRows = false;
			this.PartDGV.AllowUserToResizeColumns = false;
			this.PartDGV.AllowUserToResizeRows = false;
			this.PartDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.PartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.PartDGV.Location = new System.Drawing.Point(6, 46);
			this.PartDGV.MultiSelect = false;
			this.PartDGV.Name = "partDGV";
			this.PartDGV.ReadOnly = true;
			this.PartDGV.RowHeadersVisible = false;
			this.PartDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.PartDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.PartDGV.Size = new System.Drawing.Size(454, 250);
			this.PartDGV.StandardTab = true;
			this.PartDGV.TabIndex = 0;
			this.PartDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartDGV_CellContentClick);
			// 
			// deletePart
			// 
			this.deletePart.Location = new System.Drawing.Point(385, 302);
			this.deletePart.Name = "deletePart";
			this.deletePart.Size = new System.Drawing.Size(75, 23);
			this.deletePart.TabIndex = 3;
			this.deletePart.Text = "Delete";
			this.deletePart.UseVisualStyleBackColor = true;
			this.deletePart.Click += new System.EventHandler(this.DeletePart_Click);
			// 
			// addPart
			// 
			this.addPart.Location = new System.Drawing.Point(223, 302);
			this.addPart.Name = "addPart";
			this.addPart.Size = new System.Drawing.Size(75, 23);
			this.addPart.TabIndex = 1;
			this.addPart.Text = "Add";
			this.addPart.UseVisualStyleBackColor = true;
			this.addPart.Click += new System.EventHandler(this.AddPart_Click);
			// 
			// modifyPart
			// 
			this.modifyPart.Location = new System.Drawing.Point(304, 302);
			this.modifyPart.Name = "modifyPart";
			this.modifyPart.Size = new System.Drawing.Size(75, 23);
			this.modifyPart.TabIndex = 2;
			this.modifyPart.Text = "Modify";
			this.modifyPart.UseVisualStyleBackColor = true;
			this.modifyPart.Click += new System.EventHandler(this.ModifyPart_Click);
			// 
			// productGrpBox
			// 
			this.productGrpBox.Controls.Add(this.addProduct);
			this.productGrpBox.Controls.Add(this.modifyProduct);
			this.productGrpBox.Controls.Add(this.deleteProduct);
			this.productGrpBox.Controls.Add(this.SearchProductBtn);
			this.productGrpBox.Controls.Add(this.SearchProductTxt);
			this.productGrpBox.Controls.Add(this.ProductDGV);
			this.productGrpBox.Location = new System.Drawing.Point(484, 32);
			this.productGrpBox.Name = "productGrpBox";
			this.productGrpBox.Size = new System.Drawing.Size(466, 342);
			this.productGrpBox.TabIndex = 6;
			this.productGrpBox.TabStop = false;
			this.productGrpBox.Text = "Product";
			// 
			// addProduct
			// 
			this.addProduct.Location = new System.Drawing.Point(223, 302);
			this.addProduct.Name = "addProduct";
			this.addProduct.Size = new System.Drawing.Size(75, 23);
			this.addProduct.TabIndex = 5;
			this.addProduct.Text = "Add";
			this.addProduct.UseVisualStyleBackColor = true;
			this.addProduct.Click += new System.EventHandler(this.AddProduct_Click);
			// 
			// modifyProduct
			// 
			this.modifyProduct.Location = new System.Drawing.Point(304, 302);
			this.modifyProduct.Name = "modifyProduct";
			this.modifyProduct.Size = new System.Drawing.Size(75, 23);
			this.modifyProduct.TabIndex = 4;
			this.modifyProduct.Text = "Modify";
			this.modifyProduct.UseVisualStyleBackColor = true;
			this.modifyProduct.Click += new System.EventHandler(this.ModifyProduct_Click);
			// 
			// deleteProduct
			// 
			this.deleteProduct.Location = new System.Drawing.Point(385, 302);
			this.deleteProduct.Name = "deleteProduct";
			this.deleteProduct.Size = new System.Drawing.Size(75, 23);
			this.deleteProduct.TabIndex = 3;
			this.deleteProduct.Text = "Delete";
			this.deleteProduct.UseVisualStyleBackColor = true;
			this.deleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
			// 
			// searchProductBtn
			// 
			this.SearchProductBtn.Location = new System.Drawing.Point(239, 15);
			this.SearchProductBtn.Name = "searchProductBtn";
			this.SearchProductBtn.Size = new System.Drawing.Size(75, 23);
			this.SearchProductBtn.TabIndex = 2;
			this.SearchProductBtn.Text = "Search";
			this.SearchProductBtn.UseVisualStyleBackColor = true;
			this.SearchProductBtn.Click += new System.EventHandler(this.SearchProductBtn_Click);
			// 
			// searchProductTxt
			// 
			this.SearchProductTxt.Location = new System.Drawing.Point(320, 17);
			this.SearchProductTxt.Name = "searchProductTxt";
			this.SearchProductTxt.Size = new System.Drawing.Size(140, 20);
			this.SearchProductTxt.TabIndex = 1;
			this.SearchProductTxt.TextChanged += new System.EventHandler(this.SearchProductTxt_TextChanged);
			// 
			// productDGV
			// 
			this.ProductDGV.AllowUserToAddRows = false;
			this.ProductDGV.AllowUserToDeleteRows = false;
			this.ProductDGV.AllowUserToResizeColumns = false;
			this.ProductDGV.AllowUserToResizeRows = false;
			this.ProductDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ProductDGV.Location = new System.Drawing.Point(6, 46);
			this.ProductDGV.MultiSelect = false;
			this.ProductDGV.Name = "productDGV";
			this.ProductDGV.ReadOnly = true;
			this.ProductDGV.RowHeadersVisible = false;
			this.ProductDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ProductDGV.Size = new System.Drawing.Size(454, 250);
			this.ProductDGV.TabIndex = 0;
			// 
			// exitBtn
			// 
			this.exitBtn.Location = new System.Drawing.Point(875, 378);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(75, 23);
			this.exitBtn.TabIndex = 1;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.Location = new System.Drawing.Point(12, 13);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(153, 13);
			this.titleLbl.TabIndex = 8;
			this.titleLbl.Text = "Inventory Management System";
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 413);
			this.Controls.Add(this.titleLbl);
			this.Controls.Add(this.exitBtn);
			this.Controls.Add(this.productGrpBox);
			this.Controls.Add(this.partGrpBox);
			this.Name = "MainScreen";
			this.Text = "Main Screen";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.partGrpBox.ResumeLayout(false);
			this.partGrpBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PartDGV)).EndInit();
			this.productGrpBox.ResumeLayout(false);
			this.productGrpBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProductDGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion

				private System.Windows.Forms.GroupBox partGrpBox;
				private System.Windows.Forms.Label Label1;
				private System.Windows.Forms.TextBox SearchPartTxt;
				private System.Windows.Forms.Button SearchPartBtn;
				private System.Windows.Forms.DataGridView PartDGV;
				private System.Windows.Forms.Button deletePart;
				private System.Windows.Forms.Button addPart;
				private System.Windows.Forms.Button modifyPart;
				private System.Windows.Forms.GroupBox productGrpBox;
				private System.Windows.Forms.Button addProduct;
				private System.Windows.Forms.Button modifyProduct;
				private System.Windows.Forms.Button deleteProduct;
				private System.Windows.Forms.Button SearchProductBtn;
				private System.Windows.Forms.TextBox SearchProductTxt;
				private System.Windows.Forms.DataGridView ProductDGV;
				private System.Windows.Forms.Button exitBtn;
				private System.Windows.Forms.Label titleLbl;
			}
	}