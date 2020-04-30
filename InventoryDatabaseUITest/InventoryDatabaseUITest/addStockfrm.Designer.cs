namespace InventoryDatabaseUITest
{
    partial class addStockfrm
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
            this.upcTxtbx = new System.Windows.Forms.TextBox();
            this.stockQuantnumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewInvbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.prodNametxtbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialNumbercheckbx = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockQuantnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // upcTxtbx
            // 
            this.UPC.Location = new System.Drawing.Point(106, 285);
            this.UPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UPC.Name = "UPC";
            this.UPC.Size = new System.Drawing.Size(186, 26);
            this.UPC.TabIndex = 0;

            this.upcTxtbx.Location = new System.Drawing.Point(71, 185);
            this.upcTxtbx.Name = "upcTxtbx";
            this.upcTxtbx.Size = new System.Drawing.Size(125, 20);
            this.upcTxtbx.TabIndex = 0;
            // 
            // stockQuantnumeric
            // 

            this.stockQuant.Location = new System.Drawing.Point(890, 285);
            this.stockQuant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stockQuant.Name = "stockQuant";
            this.stockQuant.Size = new System.Drawing.Size(180, 26);
            this.stockQuant.TabIndex = 1;

            this.stockQuantnumeric.Location = new System.Drawing.Point(593, 185);
            this.stockQuantnumeric.Name = "stockQuantnumeric";
            this.stockQuantnumeric.Size = new System.Drawing.Size(120, 20);
            this.stockQuantnumeric.TabIndex = 1;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "UPC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(885, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(527, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Stock to Inventory";
            // 
            // viewInvbtn
            // 

            this.viewInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInv.Location = new System.Drawing.Point(462, 446);
            this.viewInv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewInv.Name = "viewInv";
            this.viewInv.Size = new System.Drawing.Size(219, 43);
            this.viewInv.TabIndex = 5;
            this.viewInv.Text = "View Inventory";
            this.viewInv.UseVisualStyleBackColor = true;
            this.viewInv.Click += new System.EventHandler(this.viewInv_Click);

            this.viewInvbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInvbtn.Location = new System.Drawing.Point(148, 293);
            this.viewInvbtn.Name = "viewInvbtn";
            this.viewInvbtn.Size = new System.Drawing.Size(146, 28);
            this.viewInvbtn.TabIndex = 5;
            this.viewInvbtn.Text = "View Inventory";
            this.viewInvbtn.UseVisualStyleBackColor = true;
            this.viewInvbtn.Click += new System.EventHandler(this.viewInvbtn_Click);

            // 
            // backbtn
            // 

            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(488, 595);
            this.back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(180, 45);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);

            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(325, 387);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(120, 29);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);

            // 
            // prodNametxtbx
            // 

            this.prodName.Location = new System.Drawing.Point(374, 283);
            this.prodName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(186, 26);
            this.prodName.TabIndex = 8;

            this.prodNametxtbx.Location = new System.Drawing.Point(249, 184);
            this.prodNametxtbx.Name = "prodNametxtbx";
            this.prodNametxtbx.Size = new System.Drawing.Size(125, 20);
            this.prodNametxtbx.TabIndex = 8;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // serialNumbercheckbx
            //
            this.serialNumber.AutoSize = true;
            this.serialNumber.Location = new System.Drawing.Point(634, 283);
            this.serialNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(201, 24);
            this.serialNumber.TabIndex = 11;
            this.serialNumber.Text = "Requires Serial number";
            this.serialNumber.UseVisualStyleBackColor = true;

            this.serialNumbercheckbx.AutoSize = true;
            this.serialNumbercheckbx.Location = new System.Drawing.Point(423, 184);
            this.serialNumbercheckbx.Name = "serialNumbercheckbx";
            this.serialNumbercheckbx.Size = new System.Drawing.Size(135, 17);
            this.serialNumbercheckbx.TabIndex = 11;
            this.serialNumbercheckbx.Text = "Requires Serial number";
            this.serialNumbercheckbx.UseVisualStyleBackColor = true;

            // 
            // addStockfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.serialNumber);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serialNumbercheckbx);

            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodNametxtbx);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.viewInvbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);

            this.Controls.Add(this.stockQuant);
            this.Controls.Add(this.UPC);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);

            this.Controls.Add(this.stockQuantnumeric);
            this.Controls.Add(this.upcTxtbx);

            this.Name = "addStockfrm";
            this.Text = "Add Stock";
            ((System.ComponentModel.ISupportInitialize)(this.stockQuantnumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox upcTxtbx;
        private System.Windows.Forms.NumericUpDown stockQuantnumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewInvbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox prodNametxtbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox serialNumbercheckbx;
    }
}