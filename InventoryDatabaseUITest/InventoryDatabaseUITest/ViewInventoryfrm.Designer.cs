namespace InventoryDatabaseUITest
{
    partial class ViewInventoryfrm
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
            this.backbtn = new System.Windows.Forms.Button();
            this.prodNametxtbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnViewinventory = new System.Windows.Forms.Button();
            this.stockDatagridVw = new System.Windows.Forms.DataGridView();
            this.print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stockDatagridVw)).BeginInit();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(482, 415);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // prodNametxtbx
            // 
            this.prodNametxtbx.Location = new System.Drawing.Point(101, 190);
            this.prodNametxtbx.Name = "prodNametxtbx";
            this.prodNametxtbx.Size = new System.Drawing.Size(116, 20);
            this.prodNametxtbx.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name";
            // 
            // btnViewinventory
            // 
            this.btnViewinventory.Location = new System.Drawing.Point(223, 190);
            this.btnViewinventory.Name = "btnViewinventory";
            this.btnViewinventory.Size = new System.Drawing.Size(75, 23);
            this.btnViewinventory.TabIndex = 5;
            this.btnViewinventory.Text = "Search";
            this.btnViewinventory.UseVisualStyleBackColor = true;
            this.btnViewinventory.Click += new System.EventHandler(this.btnViewinventory_Click);
            // 
            // stockDatagridVw
            // 
            this.stockDatagridVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDatagridVw.Location = new System.Drawing.Point(325, 51);
            this.stockDatagridVw.Name = "stockDatagridVw";
            this.stockDatagridVw.Size = new System.Drawing.Size(451, 291);
            this.stockDatagridVw.TabIndex = 15;
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(259, 415);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 16;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // ViewInventoryfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.print);
            this.Controls.Add(this.stockDatagridVw);
            this.Controls.Add(this.prodNametxtbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewinventory);
            this.Controls.Add(this.backbtn);
            this.Name = "ViewInventoryfrm";
            this.Text = "Search Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.stockDatagridVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox prodNametxtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnViewinventory;
        private System.Windows.Forms.DataGridView stockDatagridVw;
        private System.Windows.Forms.Button print;
    }
}