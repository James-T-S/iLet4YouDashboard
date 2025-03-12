namespace iLet4You
{
    partial class RentHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tenanttxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.RentViewer = new System.Windows.Forms.RichTextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Tenant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Address";
            // 
            // Tenanttxt
            // 
            this.Tenanttxt.Location = new System.Drawing.Point(261, 68);
            this.Tenanttxt.Margin = new System.Windows.Forms.Padding(2);
            this.Tenanttxt.Name = "Tenanttxt";
            this.Tenanttxt.Size = new System.Drawing.Size(94, 20);
            this.Tenanttxt.TabIndex = 64;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(261, 44);
            this.Addresstxt.Margin = new System.Windows.Forms.Padding(2);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(94, 20);
            this.Addresstxt.TabIndex = 63;
            // 
            // RentViewer
            // 
            this.RentViewer.Location = new System.Drawing.Point(162, 180);
            this.RentViewer.Name = "RentViewer";
            this.RentViewer.Size = new System.Drawing.Size(304, 223);
            this.RentViewer.TabIndex = 67;
            this.RentViewer.Text = "";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(279, 93);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(67, 33);
            this.ConfirmButton.TabIndex = 68;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(288, 409);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(67, 33);
            this.UpdateButton.TabIndex = 70;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // RentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.RentViewer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tenanttxt);
            this.Controls.Add(this.Addresstxt);
            this.Name = "RentHistory";
            this.Text = "RentHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tenanttxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.RichTextBox RentViewer;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}