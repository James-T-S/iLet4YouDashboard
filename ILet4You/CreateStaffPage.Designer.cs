namespace iLet4You
{
    partial class CreateStaffPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.RetypePasswordtxt = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Staff Account";
            // 
            // Usernametxt
            // 
            this.Usernametxt.Location = new System.Drawing.Point(221, 92);
            this.Usernametxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(94, 20);
            this.Usernametxt.TabIndex = 3;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(221, 177);
            this.Passwordtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(94, 20);
            this.Passwordtxt.TabIndex = 4;
            // 
            // RetypePasswordtxt
            // 
            this.RetypePasswordtxt.Location = new System.Drawing.Point(221, 244);
            this.RetypePasswordtxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RetypePasswordtxt.Name = "RetypePasswordtxt";
            this.RetypePasswordtxt.Size = new System.Drawing.Size(94, 20);
            this.RetypePasswordtxt.TabIndex = 5;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(239, 77);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 6;
            this.Username.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Retype Password";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(227, 289);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(67, 33);
            this.ConfirmButton.TabIndex = 32;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // CreateStaffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.RetypePasswordtxt);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateStaffPage";
            this.Text = "CreateStaffPage";
            this.Load += new System.EventHandler(this.CreateStaffPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox RetypePasswordtxt;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConfirmButton;
    }
}