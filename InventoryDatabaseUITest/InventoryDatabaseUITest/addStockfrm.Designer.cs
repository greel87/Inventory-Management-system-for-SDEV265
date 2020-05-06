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
            this.addNewbtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockQuantnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // upcTxtbx
            // 
            this.upcTxtbx.Location = new System.Drawing.Point(71, 185);
            this.upcTxtbx.Name = "upcTxtbx";
            this.upcTxtbx.Size = new System.Drawing.Size(125, 20);
            this.upcTxtbx.TabIndex = 0;
            // 
            // stockQuantnumeric
            // 
            this.stockQuantnumeric.Location = new System.Drawing.Point(593, 185);
            this.stockQuantnumeric.Name = "stockQuantnumeric";
            this.stockQuantnumeric.Size = new System.Drawing.Size(120, 20);
            this.stockQuantnumeric.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "UPC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Stock to Inventory";
            // 
            // viewInvbtn
            // 
            this.viewInvbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInvbtn.Location = new System.Drawing.Point(71, 314);
            this.viewInvbtn.Name = "viewInvbtn";
            this.viewInvbtn.Size = new System.Drawing.Size(126, 28);
            this.viewInvbtn.TabIndex = 5;
            this.viewInvbtn.Text = "View Inventory";
            this.viewInvbtn.UseVisualStyleBackColor = true;
            this.viewInvbtn.Click += new System.EventHandler(this.viewInvbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(319, 365);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(126, 28);
            this.backbtn.TabIndex = 7;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // prodNametxtbx
            // 
            this.prodNametxtbx.Location = new System.Drawing.Point(320, 185);
            this.prodNametxtbx.Name = "prodNametxtbx";
            this.prodNametxtbx.Size = new System.Drawing.Size(125, 20);
            this.prodNametxtbx.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // addNewbtn
            // 
            this.addNewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewbtn.Location = new System.Drawing.Point(319, 314);
            this.addNewbtn.Name = "addNewbtn";
            this.addNewbtn.Size = new System.Drawing.Size(126, 28);
            this.addNewbtn.TabIndex = 12;
            this.addNewbtn.Text = "Add New";
            this.addNewbtn.UseVisualStyleBackColor = true;
            this.addNewbtn.Click += new System.EventHandler(this.addNewbtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(587, 314);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(126, 28);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update Stock";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addStockfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addNewbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodNametxtbx);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.viewInvbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockQuantnumeric);
            this.Controls.Add(this.upcTxtbx);
            this.Name = "addStockfrm";
            this.Text = "Add Stock";
            this.Load += new System.EventHandler(this.addStockfrm_Load);
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
        private System.Windows.Forms.Button addNewbtn;
        private System.Windows.Forms.Button updateBtn;
    }
}