namespace InventoryDatabaseUITest
{
    partial class UPCfrm
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.Encode_button = new System.Windows.Forms.Button();
            this.UPCcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(12, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(606, 281);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // Encode_button
            // 
            this.Encode_button.Location = new System.Drawing.Point(225, 330);
            this.Encode_button.Name = "Encode_button";
            this.Encode_button.Size = new System.Drawing.Size(127, 43);
            this.Encode_button.TabIndex = 1;
            this.Encode_button.Text = "Encode";
            this.Encode_button.UseVisualStyleBackColor = true;
            this.Encode_button.Click += new System.EventHandler(this.Encode_button_Click);
            // 
            // UPCcode
            // 
            this.UPCcode.Location = new System.Drawing.Point(108, 299);
            this.UPCcode.Name = "UPCcode";
            this.UPCcode.Size = new System.Drawing.Size(510, 26);
            this.UPCcode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "UPC Code:";
            // 
            // Print_Button
            // 
            this.Print_Button.Location = new System.Drawing.Point(358, 330);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(127, 43);
            this.Print_Button.TabIndex = 4;
            this.Print_Button.Text = "Print";
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(491, 331);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(127, 42);
            this.Back_Button.TabIndex = 5;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // UPCfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 384);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UPCcode);
            this.Controls.Add(this.Encode_button);
            this.Controls.Add(this.pic);
            this.Name = "UPCfrm";
            this.Text = "UPCfrm";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button Encode_button;
        private System.Windows.Forms.TextBox UPCcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Button Back_Button;
    }
}