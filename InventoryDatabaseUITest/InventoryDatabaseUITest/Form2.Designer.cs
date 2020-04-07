namespace InventoryDatabaseUITest
{
    partial class Form2
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
            this.UPC = new System.Windows.Forms.TextBox();
            this.stockQuant = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.prodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialNumber = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // UPC
            // 
            this.UPC.Location = new System.Drawing.Point(71, 185);
            this.UPC.Name = "UPC";
            this.UPC.Size = new System.Drawing.Size(125, 20);
            this.UPC.TabIndex = 0;
            // 
            // stockQuant
            // 
            this.stockQuant.Location = new System.Drawing.Point(593, 185);
            this.stockQuant.Name = "stockQuant";
            this.stockQuant.Size = new System.Drawing.Size(120, 20);
            this.stockQuant.TabIndex = 1;
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
            this.label3.Size = new System.Drawing.Size(339, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Stock to Invetory";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(308, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "View Inventory";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(325, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "HOME";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // prodName
            // 
            this.prodName.Location = new System.Drawing.Point(249, 184);
            this.prodName.Name = "prodName";
            this.prodName.Size = new System.Drawing.Size(125, 20);
            this.prodName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // serialNumber
            // 
            this.serialNumber.AutoSize = true;
            this.serialNumber.Location = new System.Drawing.Point(423, 184);
            this.serialNumber.Name = "serialNumber";
            this.serialNumber.Size = new System.Drawing.Size(135, 17);
            this.serialNumber.TabIndex = 11;
            this.serialNumber.Text = "Requires Serial number";
            this.serialNumber.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serialNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prodName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockQuant);
            this.Controls.Add(this.UPC);
            this.Name = "Form2";
            this.Text = "Add Stock";
            ((System.ComponentModel.ISupportInitialize)(this.stockQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UPC;
        private System.Windows.Forms.NumericUpDown stockQuant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox serialNumber;
    }
}