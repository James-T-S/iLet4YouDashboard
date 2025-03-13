namespace iLet4You
{
    partial class AddLandlord
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.PropertyAddresstxt = new System.Windows.Forms.TextBox();
            this.DOBtxt = new System.Windows.Forms.TextBox();
            this.Phonenumbertxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Phone Number";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "DOB";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Property Address";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Add Landlord";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(208, 179);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 24;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // PropertyAddresstxt
            // 
            this.PropertyAddresstxt.Location = new System.Drawing.Point(257, 275);
            this.PropertyAddresstxt.Margin = new System.Windows.Forms.Padding(2);
            this.PropertyAddresstxt.Name = "PropertyAddresstxt";
            this.PropertyAddresstxt.Size = new System.Drawing.Size(94, 20);
            this.PropertyAddresstxt.TabIndex = 22;
            this.PropertyAddresstxt.TextChanged += new System.EventHandler(this.RentDatetxt_TextChanged);
            // 
            // DOBtxt
            // 
            this.DOBtxt.Location = new System.Drawing.Point(257, 251);
            this.DOBtxt.Margin = new System.Windows.Forms.Padding(2);
            this.DOBtxt.Name = "DOBtxt";
            this.DOBtxt.Size = new System.Drawing.Size(94, 20);
            this.DOBtxt.TabIndex = 21;
            this.DOBtxt.TextChanged += new System.EventHandler(this.DOBtxt_TextChanged);
            // 
            // Phonenumbertxt
            // 
            this.Phonenumbertxt.Location = new System.Drawing.Point(257, 227);
            this.Phonenumbertxt.Margin = new System.Windows.Forms.Padding(2);
            this.Phonenumbertxt.Name = "Phonenumbertxt";
            this.Phonenumbertxt.Size = new System.Drawing.Size(94, 20);
            this.Phonenumbertxt.TabIndex = 20;
            this.Phonenumbertxt.TextChanged += new System.EventHandler(this.Phonenumbertxt_TextChanged);
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(257, 203);
            this.Emailtxt.Margin = new System.Windows.Forms.Padding(2);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(94, 20);
            this.Emailtxt.TabIndex = 19;
            this.Emailtxt.TextChanged += new System.EventHandler(this.Emailtxt_TextChanged);
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(257, 179);
            this.Nametxt.Margin = new System.Windows.Forms.Padding(2);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(94, 20);
            this.Nametxt.TabIndex = 18;
            this.Nametxt.TextChanged += new System.EventHandler(this.Nametxt_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(273, 330);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(67, 33);
            this.ConfirmButton.TabIndex = 32;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // AddLandlord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.PropertyAddresstxt);
            this.Controls.Add(this.DOBtxt);
            this.Controls.Add(this.Phonenumbertxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Nametxt);
            this.Name.Text = "AddLandlord";
            this.Text = "AddLandlord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox PropertyAddresstxt;
        private System.Windows.Forms.TextBox DOBtxt;
        private System.Windows.Forms.TextBox Phonenumbertxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.Button ConfirmButton;
    }
}