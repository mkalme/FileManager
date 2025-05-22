namespace GUI {
    partial class TextInputDialog {
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextInputDialog));
            this.MessageLabel = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.InputTextBoxPanel = new GUI.TextBoxPanel();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MessageLabel.Location = new System.Drawing.Point(8, 10);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(52, 13);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Enter text";
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 76);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = global::GUI.Properties.Resources._64pxTextBlock;
            this.IconPictureBox.Location = new System.Drawing.Point(12, 27);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(24, 24);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconPictureBox.TabIndex = 4;
            this.IconPictureBox.TabStop = false;
            // 
            // InputTextBoxPanel
            // 
            this.InputTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.InputTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.InputTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.InputTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.InputTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.InputTextBoxPanel.Location = new System.Drawing.Point(47, 27);
            this.InputTextBoxPanel.Name = "InputTextBoxPanel";
            this.InputTextBoxPanel.ReadOnly = false;
            this.InputTextBoxPanel.Size = new System.Drawing.Size(319, 24);
            this.InputTextBoxPanel.TabIndex = 6;
            this.InputTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 10F);
            this.InputTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0, -1, 0, 0);
            // 
            // TextInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(375, 111);
            this.Controls.Add(this.InputTextBoxPanel);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.MessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TextInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input";
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private TextBoxPanel InputTextBoxPanel;
    }
}