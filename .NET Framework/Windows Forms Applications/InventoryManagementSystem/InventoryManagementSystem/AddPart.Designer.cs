/* C968 Software I  -C#
   Robert Calero
   Student ID# 000998416
*/

namespace InventoryManagementSystem
	{
		partial class AddPart
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
			this.components = new System.ComponentModel.Container();
			this.nameTip = new System.Windows.Forms.ToolTip(this.components);
			this.nameTxt = new System.Windows.Forms.TextBox();
			this.priceTip = new System.Windows.Forms.ToolTip(this.components);
			this.priceTxt = new System.Windows.Forms.TextBox();
			this.minTip = new System.Windows.Forms.ToolTip(this.components);
			this.minTxt = new System.Windows.Forms.TextBox();
			this.maxTip = new System.Windows.Forms.ToolTip(this.components);
			this.maxTxt = new System.Windows.Forms.TextBox();
			this.companyNameTip = new System.Windows.Forms.ToolTip(this.components);
			this.companyNameTxt = new System.Windows.Forms.TextBox();
			this.inventoryTip = new System.Windows.Forms.ToolTip(this.components);
			this.inventoryTxt = new System.Windows.Forms.TextBox();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			this.outsourcedRadBtn = new System.Windows.Forms.RadioButton();
			this.inhouseRadBtn = new System.Windows.Forms.RadioButton();
			this.titleLbl = new System.Windows.Forms.Label();
			this.companyNameLbl = new System.Windows.Forms.Label();
			this.minLbl = new System.Windows.Forms.Label();
			this.maxLbl = new System.Windows.Forms.Label();
			this.priceLbl = new System.Windows.Forms.Label();
			this.inventoryLbl = new System.Windows.Forms.Label();
			this.nameLbl = new System.Windows.Forms.Label();
			this.idLbl = new System.Windows.Forms.Label();
			this.idTxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// nameTxt
			// 
			this.nameTxt.BackColor = System.Drawing.Color.Salmon;
			this.nameTxt.Location = new System.Drawing.Point(130, 90);
			this.nameTxt.Name = "nameTxt";
			this.nameTxt.Size = new System.Drawing.Size(100, 20);
			this.nameTxt.TabIndex = 20;
			this.nameTip.SetToolTip(this.nameTxt, "Name required");
			this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
			// 
			// priceTxt
			// 
			this.priceTxt.BackColor = System.Drawing.Color.Salmon;
			this.priceTxt.Location = new System.Drawing.Point(130, 150);
			this.priceTxt.Name = "priceTxt";
			this.priceTxt.Size = new System.Drawing.Size(100, 20);
			this.priceTxt.TabIndex = 22;
			this.priceTip.SetToolTip(this.priceTxt, "Price requires number");
			this.priceTxt.TextChanged += new System.EventHandler(this.priceTxt_TextChanged);
			// 
			// minTxt
			// 
			this.minTxt.BackColor = System.Drawing.Color.Salmon;
			this.minTxt.Location = new System.Drawing.Point(285, 180);
			this.minTxt.Name = "minTxt";
			this.minTxt.Size = new System.Drawing.Size(65, 20);
			this.minTxt.TabIndex = 24;
			this.minTip.SetToolTip(this.minTxt, "Min requires number");
			this.minTxt.TextChanged += new System.EventHandler(this.minTxt_TextChanged);
			// 
			// maxTxt
			// 
			this.maxTxt.BackColor = System.Drawing.Color.Salmon;
			this.maxTxt.Location = new System.Drawing.Point(130, 180);
			this.maxTxt.Name = "maxTxt";
			this.maxTxt.Size = new System.Drawing.Size(65, 20);
			this.maxTxt.TabIndex = 23;
			this.maxTip.SetToolTip(this.maxTxt, "Max requires number");
			this.maxTxt.TextChanged += new System.EventHandler(this.maxTxt_TextChanged);
			// 
			// companyNameTxt
			// 
			this.companyNameTxt.BackColor = System.Drawing.Color.Salmon;
			this.companyNameTxt.Location = new System.Drawing.Point(130, 210);
			this.companyNameTxt.Name = "companyNameTxt";
			this.companyNameTxt.Size = new System.Drawing.Size(100, 20);
			this.companyNameTxt.TabIndex = 25;
			this.companyNameTip.SetToolTip(this.companyNameTxt, "Machine ID requires number");
			this.companyNameTxt.TextChanged += new System.EventHandler(this.companyNameTxt_TextChanged);
			// 
			// inventoryTxt
			// 
			this.inventoryTxt.BackColor = System.Drawing.Color.Salmon;
			this.inventoryTxt.Location = new System.Drawing.Point(130, 120);
			this.inventoryTxt.Name = "inventoryTxt";
			this.inventoryTxt.Size = new System.Drawing.Size(100, 20);
			this.inventoryTxt.TabIndex = 21;
			this.inventoryTip.SetToolTip(this.inventoryTxt, "Inventory requires number");
			this.inventoryTxt.TextChanged += new System.EventHandler(this.inventoryTxt_TextChanged);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(290, 260);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(60, 30);
			this.cancelBtn.TabIndex = 37;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.Enabled = false;
			this.saveBtn.Location = new System.Drawing.Point(219, 260);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(60, 30);
			this.saveBtn.TabIndex = 36;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// outsourcedRadBtn
			// 
			this.outsourcedRadBtn.AutoSize = true;
			this.outsourcedRadBtn.Location = new System.Drawing.Point(199, 12);
			this.outsourcedRadBtn.Name = "outsourcedRadBtn";
			this.outsourcedRadBtn.Size = new System.Drawing.Size(80, 17);
			this.outsourcedRadBtn.TabIndex = 35;
			this.outsourcedRadBtn.Text = "Outsourced";
			this.outsourcedRadBtn.UseVisualStyleBackColor = true;
			this.outsourcedRadBtn.CheckedChanged += new System.EventHandler(this.outsourcedRadBtn_CheckedChanged);
			// 
			// inhouseRadBtn
			// 
			this.inhouseRadBtn.AutoSize = true;
			this.inhouseRadBtn.Checked = true;
			this.inhouseRadBtn.Location = new System.Drawing.Point(109, 12);
			this.inhouseRadBtn.Name = "inhouseRadBtn";
			this.inhouseRadBtn.Size = new System.Drawing.Size(68, 17);
			this.inhouseRadBtn.TabIndex = 34;
			this.inhouseRadBtn.TabStop = true;
			this.inhouseRadBtn.Text = "In-House";
			this.inhouseRadBtn.UseVisualStyleBackColor = true;
			this.inhouseRadBtn.CheckedChanged += new System.EventHandler(this.inhouseRadBtn_CheckedChanged);
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.Location = new System.Drawing.Point(12, 9);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(48, 13);
			this.titleLbl.TabIndex = 33;
			this.titleLbl.Text = "Add Part";
			// 
			// companyNameLbl
			// 
			this.companyNameLbl.AutoSize = true;
			this.companyNameLbl.Location = new System.Drawing.Point(51, 213);
			this.companyNameLbl.Name = "companyNameLbl";
			this.companyNameLbl.Size = new System.Drawing.Size(62, 13);
			this.companyNameLbl.TabIndex = 32;
			this.companyNameLbl.Text = "Machine ID";
			// 
			// minLbl
			// 
			this.minLbl.AutoSize = true;
			this.minLbl.Location = new System.Drawing.Point(241, 183);
			this.minLbl.Name = "minLbl";
			this.minLbl.Size = new System.Drawing.Size(24, 13);
			this.minLbl.TabIndex = 31;
			this.minLbl.Text = "Min";
			// 
			// maxLbl
			// 
			this.maxLbl.AutoSize = true;
			this.maxLbl.Location = new System.Drawing.Point(86, 183);
			this.maxLbl.Name = "maxLbl";
			this.maxLbl.Size = new System.Drawing.Size(27, 13);
			this.maxLbl.TabIndex = 30;
			this.maxLbl.Text = "Max";
			// 
			// priceLbl
			// 
			this.priceLbl.AutoSize = true;
			this.priceLbl.Location = new System.Drawing.Point(50, 153);
			this.priceLbl.Name = "priceLbl";
			this.priceLbl.Size = new System.Drawing.Size(63, 13);
			this.priceLbl.TabIndex = 29;
			this.priceLbl.Text = "Price / Cost";
			// 
			// inventoryLbl
			// 
			this.inventoryLbl.AutoSize = true;
			this.inventoryLbl.Location = new System.Drawing.Point(62, 123);
			this.inventoryLbl.Name = "inventoryLbl";
			this.inventoryLbl.Size = new System.Drawing.Size(51, 13);
			this.inventoryLbl.TabIndex = 28;
			this.inventoryLbl.Text = "Inventory";
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Location = new System.Drawing.Point(78, 93);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(35, 13);
			this.nameLbl.TabIndex = 27;
			this.nameLbl.Text = "Name";
			// 
			// idLbl
			// 
			this.idLbl.AutoSize = true;
			this.idLbl.Location = new System.Drawing.Point(95, 63);
			this.idLbl.Name = "idLbl";
			this.idLbl.Size = new System.Drawing.Size(18, 13);
			this.idLbl.TabIndex = 26;
			this.idLbl.Text = "ID";
			// 
			// idTxt
			// 
			this.idTxt.Enabled = false;
			this.idTxt.Location = new System.Drawing.Point(130, 60);
			this.idTxt.Name = "idTxt";
			this.idTxt.Size = new System.Drawing.Size(100, 20);
			this.idTxt.TabIndex = 19;
			// 
			// AddPart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 311);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.outsourcedRadBtn);
			this.Controls.Add(this.inhouseRadBtn);
			this.Controls.Add(this.titleLbl);
			this.Controls.Add(this.companyNameLbl);
			this.Controls.Add(this.minLbl);
			this.Controls.Add(this.maxLbl);
			this.Controls.Add(this.priceLbl);
			this.Controls.Add(this.inventoryLbl);
			this.Controls.Add(this.nameLbl);
			this.Controls.Add(this.idLbl);
			this.Controls.Add(this.companyNameTxt);
			this.Controls.Add(this.minTxt);
			this.Controls.Add(this.maxTxt);
			this.Controls.Add(this.priceTxt);
			this.Controls.Add(this.inventoryTxt);
			this.Controls.Add(this.nameTxt);
			this.Controls.Add(this.idTxt);
			this.Name = "AddPart";
			this.Text = "Add Part";
			this.Load += new System.EventHandler(this.AddPart_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

					}

				#endregion

				private System.Windows.Forms.ToolTip nameTip;
				private System.Windows.Forms.TextBox nameTxt;
				private System.Windows.Forms.ToolTip priceTip;
				private System.Windows.Forms.TextBox priceTxt;
				private System.Windows.Forms.ToolTip minTip;
				private System.Windows.Forms.TextBox minTxt;
				private System.Windows.Forms.ToolTip maxTip;
				private System.Windows.Forms.TextBox maxTxt;
				private System.Windows.Forms.ToolTip companyNameTip;
				private System.Windows.Forms.TextBox companyNameTxt;
				private System.Windows.Forms.ToolTip inventoryTip;
				private System.Windows.Forms.TextBox inventoryTxt;
				private System.Windows.Forms.Button cancelBtn;
				private System.Windows.Forms.Button saveBtn;
				private System.Windows.Forms.RadioButton outsourcedRadBtn;
				private System.Windows.Forms.RadioButton inhouseRadBtn;
				private System.Windows.Forms.Label titleLbl;
				private System.Windows.Forms.Label companyNameLbl;
				private System.Windows.Forms.Label minLbl;
				private System.Windows.Forms.Label maxLbl;
				private System.Windows.Forms.Label priceLbl;
				private System.Windows.Forms.Label inventoryLbl;
				private System.Windows.Forms.Label nameLbl;
				private System.Windows.Forms.Label idLbl;
				private System.Windows.Forms.TextBox idTxt;
			}
	}