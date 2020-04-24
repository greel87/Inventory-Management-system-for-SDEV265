namespace InventoryDatabaseUITest
{
    partial class inventoryQueryfrm
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
            this.inventoryQueryListBox = new System.Windows.Forms.ListBox();
            this.invSearchbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prodtxtbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inventoryQueryListBox
            // 
            this.inventoryQueryListBox.FormattingEnabled = true;
            this.inventoryQueryListBox.Location = new System.Drawing.Point(29, 138);
            this.inventoryQueryListBox.Name = "inventoryQueryListBox";
            this.inventoryQueryListBox.Size = new System.Drawing.Size(742, 290);
            this.inventoryQueryListBox.TabIndex = 0;
            // 
            // invSearchbtn
            // 
            this.invSearchbtn.Location = new System.Drawing.Point(405, 29);
            this.invSearchbtn.Name = "invSearchbtn";
            this.invSearchbtn.Size = new System.Drawing.Size(75, 23);
            this.invSearchbtn.TabIndex = 1;
            this.invSearchbtn.Text = "Search";
            this.invSearchbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name";
            // 
            // prodtxtbx
            // 
            this.prodtxtbx.Location = new System.Drawing.Point(283, 29);
            this.prodtxtbx.Name = "prodtxtbx";
            this.prodtxtbx.Size = new System.Drawing.Size(116, 20);
            this.prodtxtbx.TabIndex = 3;
            // 
            // inventoryQueryfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prodtxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invSearchbtn);
            this.Controls.Add(this.inventoryQueryListBox);
            this.Name = "inventoryQueryfrm";
            this.Text = "Search Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox inventoryQueryListBox;
        private System.Windows.Forms.Button invSearchbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prodtxtbx;
    }
}