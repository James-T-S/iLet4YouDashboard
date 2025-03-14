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
            this.label6.Location = new System.Drawing.Point(267, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 66;
            this.label6.Text = "Tenant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Address";
            // 
            // Tenanttxt
            // 
            this.Tenanttxt.Location = new System.Drawing.Point(348, 84);
            this.Tenanttxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tenanttxt.Name = "Tenanttxt";
            this.Tenanttxt.Size = new System.Drawing.Size(124, 22);
            this.Tenanttxt.TabIndex = 64;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Location = new System.Drawing.Point(348, 54);
            this.Addresstxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(124, 22);
            this.Addresstxt.TabIndex = 63;
            // 
            // RentViewer
            // 
            this.RentViewer.Location = new System.Drawing.Point(236, 221);
            this.RentViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RentViewer.Name = "RentViewer";
            this.RentViewer.Size = new System.Drawing.Size(404, 274);
            this.RentViewer.TabIndex = 67;
            this.RentViewer.Text = "";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(372, 114);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(89, 41);
            this.ConfirmButton.TabIndex = 68;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(384, 503);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(89, 41);
            this.UpdateButton.TabIndex = 70;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // RentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.RentViewer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tenanttxt);
            this.Controls.Add(this.Addresstxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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