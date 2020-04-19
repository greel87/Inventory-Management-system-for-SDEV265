namespace InventoryDatabaseUITest
{
    partial class Homefrm
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
            this.addStock = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.viewInv = new System.Windows.Forms.Button();
            this.viewCust = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.UPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStock
            // 
            this.addStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStock.Location = new System.Drawing.Point(122, 180);
            this.addStock.Name = "addStock";
            this.addStock.Size = new System.Drawing.Size(146, 42);
            this.addStock.TabIndex = 0;
            this.addStock.Text = "Add Stock to Inventory\r\n";
            this.addStock.UseVisualStyleBackColor = true;
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(533, 180);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(146, 28);
            this.addCustomer.TabIndex = 1;
            this.addCustomer.Text = "Add New Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            // 
            // viewInv
            // 
            this.viewInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInv.Location = new System.Drawing.Point(122, 265);
            this.viewInv.Name = "viewInv";
            this.viewInv.Size = new System.Drawing.Size(146, 28);
            this.viewInv.TabIndex = 2;
            this.viewInv.Text = "View Inventory";
            this.viewInv.UseVisualStyleBackColor = true;
            // 
            // viewCust
            // 
            this.viewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCust.Location = new System.Drawing.Point(533, 265);
            this.viewCust.Name = "viewCust";
            this.viewCust.Size = new System.Drawing.Size(146, 28);
            this.viewCust.TabIndex = 3;
            this.viewCust.Text = "View Customers";
            this.viewCust.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(552, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carolina Air Inventory Management";
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(356, 377);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(120, 29);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // UPC
            // 
            this.UPC.Location = new System.Drawing.Point(356, 224);
            this.UPC.Name = "UPC";
            this.UPC.Size = new System.Drawing.Size(101, 29);
            this.UPC.TabIndex = 6;
            this.UPC.Text = "Create UPC";
            this.UPC.UseVisualStyleBackColor = true;
            // 
            // Homefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UPC);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewCust);
            this.Controls.Add(this.viewInv);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.addStock);
            this.Name = "Homefrm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStock;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button viewInv;
        private System.Windows.Forms.Button viewCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button UPC;
    }
}

