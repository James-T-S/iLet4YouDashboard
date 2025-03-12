namespace iLet4You
{
    partial class Note
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
            this.Notes = new System.Windows.Forms.ListBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Notes
            // 
            this.Notes.FormattingEnabled = true;
            this.Notes.Location = new System.Drawing.Point(145, 112);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(366, 290);
            this.Notes.TabIndex = 0;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(291, 59);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(67, 33);
            this.ConfirmButton.TabIndex = 64;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.Notes);
            this.Name = "Note";
            this.Text = "Note";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Notes;
        private System.Windows.Forms.Button ConfirmButton;
    }
}