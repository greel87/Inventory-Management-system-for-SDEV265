namespace InventoryDatabaseUITest
{
    partial class ViewCustomerfrm
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
            this.Lnametxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.custSearchbtn = new System.Windows.Forms.Button();
            this.custBackbtn = new System.Windows.Forms.Button();
            this.customerDatagridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerDatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Lnametxtbx
            // 
            this.Lnametxtbx.Location = new System.Drawing.Point(80, 196);
            this.Lnametxtbx.Name = "Lnametxtbx";
            this.Lnametxtbx.Size = new System.Drawing.Size(116, 20);
            this.Lnametxtbx.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Last Name";
            // 
            // custSearchbtn
            // 
            this.custSearchbtn.Location = new System.Drawing.Point(202, 196);
            this.custSearchbtn.Name = "custSearchbtn";
            this.custSearchbtn.Size = new System.Drawing.Size(75, 23);
            this.custSearchbtn.TabIndex = 5;
            this.custSearchbtn.Text = "Search";
            this.custSearchbtn.UseVisualStyleBackColor = true;
            this.custSearchbtn.Click += new System.EventHandler(this.custSearchbtn_Click);
            // 
            // custBackbtn
            // 
            this.custBackbtn.Location = new System.Drawing.Point(446, 397);
            this.custBackbtn.Name = "custBackbtn";
            this.custBackbtn.Size = new System.Drawing.Size(75, 23);
            this.custBackbtn.TabIndex = 8;
            this.custBackbtn.Text = "Back";
            this.custBackbtn.UseVisualStyleBackColor = true;
            this.custBackbtn.Click += new System.EventHandler(this.custBackbtn_Click);
            // 
            // customerDatagridView
            // 
            this.customerDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDatagridView.Location = new System.Drawing.Point(324, 80);
            this.customerDatagridView.Name = "customerDatagridView";
            this.customerDatagridView.Size = new System.Drawing.Size(464, 258);
            this.customerDatagridView.TabIndex = 29;
            // 
            // ViewCustomerfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerDatagridView);
            this.Controls.Add(this.custBackbtn);
            this.Controls.Add(this.Lnametxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.custSearchbtn);
            this.Name = "ViewCustomerfrm";
            this.Text = "Search Customer";
            ((System.ComponentModel.ISupportInitialize)(this.customerDatagridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Lnametxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button custSearchbtn;
        private System.Windows.Forms.Button custBackbtn;
        private System.Windows.Forms.DataGridView customerDatagridView;
    }
}