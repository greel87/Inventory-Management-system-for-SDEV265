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
            this.addStockbtn = new System.Windows.Forms.Button();
            this.addCustomerbtn = new System.Windows.Forms.Button();
            this.viewInvbtn = new System.Windows.Forms.Button();
            this.viewCustbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.UPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addStockbtn
            // 
            this.addStockbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStockbtn.Location = new System.Drawing.Point(183, 277);
            this.addStockbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addStockbtn.Name = "addStockbtn";
            this.addStockbtn.Size = new System.Drawing.Size(219, 65);
            this.addStockbtn.TabIndex = 0;
            this.addStockbtn.Text = "Add Stock to Inventory\r\n";
            this.addStockbtn.UseVisualStyleBackColor = true;
            this.addStockbtn.Click += new System.EventHandler(this.addStockbtn_Click);
            // 
            // addCustomerbtn
            // 
            this.addCustomerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerbtn.Location = new System.Drawing.Point(800, 277);
            this.addCustomerbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustomerbtn.Name = "addCustomerbtn";
            this.addCustomerbtn.Size = new System.Drawing.Size(219, 43);
            this.addCustomerbtn.TabIndex = 1;
            this.addCustomerbtn.Text = "Add New Customer";
            this.addCustomerbtn.UseVisualStyleBackColor = true;
            this.addCustomerbtn.Click += new System.EventHandler(this.addCustomerbtn_Click);
            // 
            // viewInvbtn
            // 
            this.viewInvbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewInvbtn.Location = new System.Drawing.Point(183, 408);
            this.viewInvbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewInvbtn.Name = "viewInvbtn";
            this.viewInvbtn.Size = new System.Drawing.Size(219, 43);
            this.viewInvbtn.TabIndex = 2;
            this.viewInvbtn.Text = "View Inventory";
            this.viewInvbtn.UseVisualStyleBackColor = true;
            this.viewInvbtn.Click += new System.EventHandler(this.viewInvbtn_Click);
            // 
            // viewCustbtn
            // 
            this.viewCustbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCustbtn.Location = new System.Drawing.Point(800, 408);
            this.viewCustbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewCustbtn.Name = "viewCustbtn";
            this.viewCustbtn.Size = new System.Drawing.Size(219, 43);
            this.viewCustbtn.TabIndex = 3;
            this.viewCustbtn.Text = "View Customers";
            this.viewCustbtn.UseVisualStyleBackColor = true;
            this.viewCustbtn.Click += new System.EventHandler(this.viewCustbtn_Click);
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
            this.UPC.Click += new System.EventHandler(this.UPC_Click);
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
            this.Controls.Add(this.viewCustbtn);
            this.Controls.Add(this.viewInvbtn);
            this.Controls.Add(this.addCustomerbtn);
            this.Controls.Add(this.addStockbtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Homefrm";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStockbtn;
        private System.Windows.Forms.Button addCustomerbtn;
        private System.Windows.Forms.Button viewInvbtn;
        private System.Windows.Forms.Button viewCustbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button UPC;
    }
}

