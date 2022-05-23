/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

namespace InventoryManagementSystem
	{
		partial class AddProduct
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
			this.titleLbl = new System.Windows.Forms.Label();
			this.associatedPartsGrpBox = new System.Windows.Forms.GroupBox();
			this.saveBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.deletePartBtn = new System.Windows.Forms.Button();
			this.associatedPartsDGV = new System.Windows.Forms.DataGridView();
			this.allPartsDGV = new System.Windows.Forms.DataGridView();
			this.searchPartTxt = new System.Windows.Forms.TextBox();
			this.searchPartBtn = new System.Windows.Forms.Button();
			this.addPartBtn = new System.Windows.Forms.Button();
			this.allPartsGrpBox = new System.Windows.Forms.GroupBox();
			this.minLbl = new System.Windows.Forms.Label();
			this.maxLbl = new System.Windows.Forms.Label();
			this.priceLbl = new System.Windows.Forms.Label();
			this.inventoryLbl = new System.Windows.Forms.Label();
			this.nameLbl = new System.Windows.Forms.Label();
			this.idLbl = new System.Windows.Forms.Label();
			this.minTxt = new System.Windows.Forms.TextBox();
			this.maxTxt = new System.Windows.Forms.TextBox();
			this.priceTxt = new System.Windows.Forms.TextBox();
			this.inventoryTxt = new System.Windows.Forms.TextBox();
			this.nameTxt = new System.Windows.Forms.TextBox();
			this.idTxt = new System.Windows.Forms.TextBox();
			this.associatedPartsGrpBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.associatedPartsDGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.allPartsDGV)).BeginInit();
			this.allPartsGrpBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.Location = new System.Drawing.Point(12, 9);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(66, 13);
			this.titleLbl.TabIndex = 34;
			this.titleLbl.Text = "Add Product";
			// 
			// associatedPartsGrpBox
			// 
			this.associatedPartsGrpBox.Controls.Add(this.saveBtn);
			this.associatedPartsGrpBox.Controls.Add(this.cancelBtn);
			this.associatedPartsGrpBox.Controls.Add(this.deletePartBtn);
			this.associatedPartsGrpBox.Controls.Add(this.associatedPartsDGV);
			this.associatedPartsGrpBox.Location = new System.Drawing.Point(226, 266);
			this.associatedPartsGrpBox.Name = "associatedPartsGrpBox";
			this.associatedPartsGrpBox.Size = new System.Drawing.Size(428, 215);
			this.associatedPartsGrpBox.TabIndex = 17;
			this.associatedPartsGrpBox.TabStop = false;
			this.associatedPartsGrpBox.Text = "Parts Associated with the Product";
			// 
			// saveBtn
			// 
			this.saveBtn.Enabled = false;
			this.saveBtn.Location = new System.Drawing.Point(266, 186);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 3;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(347, 186);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 2;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// deletePartBtn
			// 
			this.deletePartBtn.Location = new System.Drawing.Point(347, 157);
			this.deletePartBtn.Name = "deletePartBtn";
			this.deletePartBtn.Size = new System.Drawing.Size(75, 23);
			this.deletePartBtn.TabIndex = 1;
			this.deletePartBtn.Text = "Delete";
			this.deletePartBtn.UseVisualStyleBackColor = true;
			this.deletePartBtn.Click += new System.EventHandler(this.deletePartBtn_Click);
			// 
			// associatedPartsDGV
			// 
			this.associatedPartsDGV.AllowUserToAddRows = false;
			this.associatedPartsDGV.AllowUserToDeleteRows = false;
			this.associatedPartsDGV.AllowUserToResizeColumns = false;
			this.associatedPartsDGV.AllowUserToResizeRows = false;
			this.associatedPartsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.associatedPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.associatedPartsDGV.Location = new System.Drawing.Point(6, 19);
			this.associatedPartsDGV.Name = "associatedPartsDGV";
			this.associatedPartsDGV.RowHeadersVisible = false;
			this.associatedPartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.associatedPartsDGV.Size = new System.Drawing.Size(416, 132);
			this.associatedPartsDGV.TabIndex = 0;
			// 
			// allPartsDGV
			// 
			this.allPartsDGV.AllowUserToAddRows = false;
			this.allPartsDGV.AllowUserToDeleteRows = false;
			this.allPartsDGV.AllowUserToResizeColumns = false;
			this.allPartsDGV.AllowUserToResizeRows = false;
			this.allPartsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.allPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.allPartsDGV.Location = new System.Drawing.Point(6, 45);
			this.allPartsDGV.MultiSelect = false;
			this.allPartsDGV.Name = "allPartsDGV";
			this.allPartsDGV.ReadOnly = true;
			this.allPartsDGV.RowHeadersVisible = false;
			this.allPartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.allPartsDGV.Size = new System.Drawing.Size(416, 156);
			this.allPartsDGV.TabIndex = 0;
			// 
			// searchPartTxt
			// 
			this.searchPartTxt.Location = new System.Drawing.Point(282, 19);
			this.searchPartTxt.Name = "searchPartTxt";
			this.searchPartTxt.Size = new System.Drawing.Size(140, 20);
			this.searchPartTxt.TabIndex = 1;
			this.searchPartTxt.TextChanged += new System.EventHandler(this.searchPartTxt_TextChanged);
			// 
			// searchPartBtn
			// 
			this.searchPartBtn.Location = new System.Drawing.Point(201, 16);
			this.searchPartBtn.Name = "searchPartBtn";
			this.searchPartBtn.Size = new System.Drawing.Size(75, 23);
			this.searchPartBtn.TabIndex = 2;
			this.searchPartBtn.Text = "Search";
			this.searchPartBtn.UseVisualStyleBackColor = true;
			this.searchPartBtn.Click += new System.EventHandler(this.searchPartBtn_Click);
			// 
			// addPartBtn
			// 
			this.addPartBtn.Location = new System.Drawing.Point(347, 207);
			this.addPartBtn.Name = "addPartBtn";
			this.addPartBtn.Size = new System.Drawing.Size(75, 23);
			this.addPartBtn.TabIndex = 3;
			this.addPartBtn.Text = "Add";
			this.addPartBtn.UseVisualStyleBackColor = true;
			this.addPartBtn.Click += new System.EventHandler(this.addPartBtn_Click);
			// 
			// allPartsGrpBox
			// 
			this.allPartsGrpBox.Controls.Add(this.allPartsDGV);
			this.allPartsGrpBox.Controls.Add(this.searchPartTxt);
			this.allPartsGrpBox.Controls.Add(this.searchPartBtn);
			this.allPartsGrpBox.Controls.Add(this.addPartBtn);
			this.allPartsGrpBox.Location = new System.Drawing.Point(226, 19);
			this.allPartsGrpBox.Name = "allPartsGrpBox";
			this.allPartsGrpBox.Size = new System.Drawing.Size(428, 241);
			this.allPartsGrpBox.TabIndex = 16;
			this.allPartsGrpBox.TabStop = false;
			this.allPartsGrpBox.Text = "All Parts";
			// 
			// minLbl
			// 
			this.minLbl.AutoSize = true;
			this.minLbl.Location = new System.Drawing.Point(126, 328);
			this.minLbl.Name = "minLbl";
			this.minLbl.Size = new System.Drawing.Size(24, 13);
			this.minLbl.TabIndex = 46;
			this.minLbl.Text = "Min";
			// 
			// maxLbl
			// 
			this.maxLbl.AutoSize = true;
			this.maxLbl.Location = new System.Drawing.Point(4, 328);
			this.maxLbl.Name = "maxLbl";
			this.maxLbl.Size = new System.Drawing.Size(27, 13);
			this.maxLbl.TabIndex = 45;
			this.maxLbl.Text = "Max";
			// 
			// priceLbl
			// 
			this.priceLbl.AutoSize = true;
			this.priceLbl.Location = new System.Drawing.Point(4, 288);
			this.priceLbl.Name = "priceLbl";
			this.priceLbl.Size = new System.Drawing.Size(31, 13);
			this.priceLbl.TabIndex = 44;
			this.priceLbl.Text = "Price";
			// 
			// inventoryLbl
			// 
			this.inventoryLbl.AutoSize = true;
			this.inventoryLbl.Location = new System.Drawing.Point(4, 248);
			this.inventoryLbl.Name = "inventoryLbl";
			this.inventoryLbl.Size = new System.Drawing.Size(51, 13);
			this.inventoryLbl.TabIndex = 12;
			this.inventoryLbl.Text = "Inventory";
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Location = new System.Drawing.Point(4, 208);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(35, 13);
			this.nameLbl.TabIndex = 42;
			this.nameLbl.Text = "Name";
			// 
			// idLbl
			// 
			this.idLbl.AutoSize = true;
			this.idLbl.Location = new System.Drawing.Point(4, 168);
			this.idLbl.Name = "idLbl";
			this.idLbl.Size = new System.Drawing.Size(18, 13);
			this.idLbl.TabIndex = 10;
			this.idLbl.Text = "ID";
			// 
			// minTxt
			// 
			this.minTxt.BackColor = System.Drawing.Color.Salmon;
			this.minTxt.Location = new System.Drawing.Point(156, 325);
			this.minTxt.Name = "minTxt";
			this.minTxt.Size = new System.Drawing.Size(65, 20);
			this.minTxt.TabIndex = 40;
			this.minTxt.TextChanged += new System.EventHandler(this.minTxt_TextChanged);
			// 
			// maxTxt
			// 
			this.maxTxt.BackColor = System.Drawing.Color.Salmon;
			this.maxTxt.Location = new System.Drawing.Point(53, 325);
			this.maxTxt.Name = "maxTxt";
			this.maxTxt.Size = new System.Drawing.Size(65, 20);
			this.maxTxt.TabIndex = 39;
			this.maxTxt.TextChanged += new System.EventHandler(this.maxTxt_TextChanged);
			// 
			// priceTxt
			// 
			this.priceTxt.BackColor = System.Drawing.Color.Salmon;
			this.priceTxt.Location = new System.Drawing.Point(74, 285);
			this.priceTxt.Name = "priceTxt";
			this.priceTxt.Size = new System.Drawing.Size(100, 20);
			this.priceTxt.TabIndex = 38;
			this.priceTxt.TextChanged += new System.EventHandler(this.priceTxt_TextChanged);
			// 
			// inventoryTxt
			// 
			this.inventoryTxt.BackColor = System.Drawing.Color.Salmon;
			this.inventoryTxt.Location = new System.Drawing.Point(74, 245);
			this.inventoryTxt.Name = "inventoryTxt";
			this.inventoryTxt.Size = new System.Drawing.Size(100, 20);
			this.inventoryTxt.TabIndex = 37;
			this.inventoryTxt.TextChanged += new System.EventHandler(this.inventoryTxt_TextChanged);
			// 
			// nameTxt
			// 
			this.nameTxt.BackColor = System.Drawing.Color.Salmon;
			this.nameTxt.Location = new System.Drawing.Point(74, 205);
			this.nameTxt.Name = "nameTxt";
			this.nameTxt.Size = new System.Drawing.Size(100, 20);
			this.nameTxt.TabIndex = 36;
			this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
			// 
			// idTxt
			// 
			this.idTxt.Enabled = false;
			this.idTxt.Location = new System.Drawing.Point(74, 165);
			this.idTxt.Name = "idTxt";
			this.idTxt.Size = new System.Drawing.Size(100, 20);
			this.idTxt.TabIndex = 4;
			// 
			// AddProduct
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 511);
			this.Controls.Add(this.associatedPartsGrpBox);
			this.Controls.Add(this.allPartsGrpBox);
			this.Controls.Add(this.minLbl);
			this.Controls.Add(this.maxLbl);
			this.Controls.Add(this.priceLbl);
			this.Controls.Add(this.inventoryLbl);
			this.Controls.Add(this.nameLbl);
			this.Controls.Add(this.idLbl);
			this.Controls.Add(this.minTxt);
			this.Controls.Add(this.maxTxt);
			this.Controls.Add(this.priceTxt);
			this.Controls.Add(this.inventoryTxt);
			this.Controls.Add(this.nameTxt);
			this.Controls.Add(this.idTxt);
			this.Controls.Add(this.titleLbl);
			this.Name = "AddProduct";
			this.Text = "AddProductForm";
			this.Load += new System.EventHandler(this.AddProduct_Load);
			this.associatedPartsGrpBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.associatedPartsDGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.allPartsDGV)).EndInit();
			this.allPartsGrpBox.ResumeLayout(false);
			this.allPartsGrpBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion

				private System.Windows.Forms.Label titleLbl;
				private System.Windows.Forms.GroupBox associatedPartsGrpBox;
				private System.Windows.Forms.Button saveBtn;
				private System.Windows.Forms.Button cancelBtn;
				private System.Windows.Forms.Button deletePartBtn;
				private System.Windows.Forms.DataGridView associatedPartsDGV;
				private System.Windows.Forms.DataGridView allPartsDGV;
				private System.Windows.Forms.TextBox searchPartTxt;
				private System.Windows.Forms.Button searchPartBtn;
				private System.Windows.Forms.Button addPartBtn;
				private System.Windows.Forms.GroupBox allPartsGrpBox;
				private System.Windows.Forms.Label minLbl;
				private System.Windows.Forms.Label maxLbl;
				private System.Windows.Forms.Label priceLbl;
				private System.Windows.Forms.Label inventoryLbl;
				private System.Windows.Forms.Label nameLbl;
				private System.Windows.Forms.Label idLbl;
				private System.Windows.Forms.TextBox minTxt;
				private System.Windows.Forms.TextBox maxTxt;
				private System.Windows.Forms.TextBox priceTxt;
				private System.Windows.Forms.TextBox inventoryTxt;
				private System.Windows.Forms.TextBox nameTxt;
				private System.Windows.Forms.TextBox idTxt;
			}
	}