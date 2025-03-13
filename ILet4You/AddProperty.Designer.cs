namespace iLet4You
{
    partial class AddProperty
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
            this.IDVtxt = new System.Windows.Forms.TextBox();
            this.EPCtxt = new System.Windows.Forms.TextBox();
            this.Electriccerttxt = new System.Windows.Forms.TextBox();
            this.Gascerttxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Electric Cert Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "EPC Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "ID verifcation Due Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Add Property";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Gas Cert Due Date";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(192, 175);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(65, 13);
            this.Name.TabIndex = 36;
            this.Name.Text = "AddProperty";
            // 
            // IDVtxt
            // 
            this.IDVtxt.Location = new System.Drawing.Point(256, 268);
            this.IDVtxt.Margin = new System.Windows.Forms.Padding(2);
            this.IDVtxt.Name = "IDVtxt";
            this.IDVtxt.Size = new System.Drawing.Size(94, 20);
            this.IDVtxt.TabIndex = 35;
            // 
            // EPCtxt
            // 
            this.EPCtxt.Location = new System.Drawing.Point(256, 244);
            this.EPCtxt.Margin = new System.Windows.Forms.Padding(2);
            this.EPCtxt.Name = "EPCtxt";
            this.EPCtxt.Size = new System.Drawing.Size(94, 20);
            this.EPCtxt.TabIndex = 34;
            // 
            // Electriccerttxt
            // 
            this.Electriccerttxt.Location = new System.Drawing.Point(256, 220);
            this.Electriccerttxt.Margin = new System.Windows.Forms.Padding(2);
            this.Electriccerttxt.Name = "Electriccerttxt";
            this.Electriccerttxt.Size = new System.Drawing.Size(94, 20);
            this.Electriccerttxt.TabIndex = 33;
            // 
            // Gascerttxt
            // 
            this.Gascerttxt.Location = new System.Drawing.Point(256, 196);
            this.Gascerttxt.Margin = new System.Windows.Forms.Padding(2);
            this.Gascerttxt.Name = "Gascerttxt";
            this.Gascerttxt.Size = new System.Drawing.Size(94, 20);
            this.Gascerttxt.TabIndex = 32;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(256, 172);
            this.Addresstxt.Margin = new System.Windows.Forms.Padding(2);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(94, 20);
            this.Addresstxt.TabIndex = 31;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(270, 313);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(67, 33);
            this.ConfirmButton.TabIndex = 42;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AddProperty
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
            this.Controls.Add(this.IDVtxt);
            this.Controls.Add(this.EPCtxt);
            this.Controls.Add(this.Electriccerttxt);
            this.Controls.Add(this.Gascerttxt);
            this.Controls.Add(this.Addresstxt);
            this.Name = "AddProperty";
            this.Text = "AddProperty";
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
        private System.Windows.Forms.TextBox IDVtxt;
        private System.Windows.Forms.TextBox EPCtxt;
        private System.Windows.Forms.TextBox Electriccerttxt;
        private System.Windows.Forms.TextBox Gascerttxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.Button ConfirmButton;
    }
}