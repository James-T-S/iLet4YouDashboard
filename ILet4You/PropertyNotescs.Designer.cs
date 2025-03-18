namespace iLet4You
{
    partial class PropertyNotescs
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
            this.EnterText = new System.Windows.Forms.TextBox();
            this.TenantTextBox = new System.Windows.Forms.RichTextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterText
            // 
            this.EnterText.Location = new System.Drawing.Point(54, 65);
            this.EnterText.Name = "EnterText";
            this.EnterText.Size = new System.Drawing.Size(225, 22);
            this.EnterText.TabIndex = 69;
            // 
            // TenantTextBox
            // 
            this.TenantTextBox.Location = new System.Drawing.Point(186, 111);
            this.TenantTextBox.Name = "TenantTextBox";
            this.TenantTextBox.ReadOnly = true;
            this.TenantTextBox.Size = new System.Drawing.Size(560, 283);
            this.TenantTextBox.TabIndex = 68;
            this.TenantTextBox.Text = "";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(318, 56);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(89, 41);
            this.ConfirmButton.TabIndex = 67;
            this.ConfirmButton.Text = "Update";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // PropertyNotescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterText);
            this.Controls.Add(this.TenantTextBox);
            this.Controls.Add(this.ConfirmButton);
            this.Name = "PropertyNotescs";
            this.Text = "PropertyNotescs";
            this.Load += new System.EventHandler(this.PropertyNotescs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterText;
        private System.Windows.Forms.RichTextBox TenantTextBox;
        private System.Windows.Forms.Button ConfirmButton;
    }
}