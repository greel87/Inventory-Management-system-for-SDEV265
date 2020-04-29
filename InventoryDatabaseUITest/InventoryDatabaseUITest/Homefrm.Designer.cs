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
            this.addStock.Location = new System.Drawing.Point(183, 277);
            this.addStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addStock.Name = "addStock";
            this.addStock.Size = new System.Drawing.Size(219, 65);
            this.addStock.TabIndex = 0;
            this.addStock.Text = "Add Stock to Inventory\r\n";
            this.addStock.UseVisualStyleBackColor = true;
            this.addStock.Click += new System.EventHandler(this.addStock_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(800, 277);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(219, 43);
            this.addCustomer.TabIndex = 1;
            this.addCustomer.Text = "Add New Customer";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click_1);
            // 
            // viewInv
            // 
            this.viewInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInv.Location = new System.Drawing.Point(183, 408);
            this.viewInv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewInv.Name = "viewInv";
            this.viewInv.Size = new System.Drawing.Size(219, 43);
            this.viewInv.TabIndex = 2;
            this.viewInv.Text = "View Inventory";
            this.viewInv.UseVisualStyleBackColor = true;
            this.viewInv.Click += new System.EventHandler(this.viewInv_Click);
            // 
            // viewCust
            // 
            this.viewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCust.Location = new System.Drawing.Point(800, 408);
            this.viewCust.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewCust.Name = "viewCust";
            this.viewCust.Size = new System.Drawing.Size(219, 43);
            this.viewCust.TabIndex = 3;
            this.viewCust.Text = "View Customers";
            this.viewCust.UseVisualStyleBackColor = true;
            this.viewCust.Click += new System.EventHandler(this.viewCust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carolina Air Inventory Management";
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(534, 580);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(180, 45);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // UPC
            // 
            this.UPC.Location = new System.Drawing.Point(534, 345);
            this.UPC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UPC.Name = "UPC";
            this.UPC.Size = new System.Drawing.Size(152, 45);
            this.UPC.TabIndex = 6;
            this.UPC.Text = "Create UPC";
            this.UPC.UseVisualStyleBackColor = true;
            // 
            // Homefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.UPC);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewCust);
            this.Controls.Add(this.viewInv);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.addStock);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

