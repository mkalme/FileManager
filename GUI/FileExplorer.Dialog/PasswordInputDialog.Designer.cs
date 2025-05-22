namespace GUI {
    partial class PasswordInputDialog {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordInputDialog));
            this.CopyTextButton = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CharacterPanel = new System.Windows.Forms.Panel();
            this.CharactersLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordPictureBox = new System.Windows.Forms.PictureBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PasswordTextBoxPanel = new GUI.TextBoxPanel();
            this.PasswordLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.CharacterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CopyTextButton
            // 
            this.CopyTextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CopyTextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CopyTextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CopyTextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.CopyTextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyTextButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CopyTextButton.Image = global::GUI.Properties.Resources._16pxCopyLongText;
            this.CopyTextButton.Location = new System.Drawing.Point(355, 116);
            this.CopyTextButton.Name = "CopyTextButton";
            this.CopyTextButton.Size = new System.Drawing.Size(23, 23);
            this.CopyTextButton.TabIndex = 23;
            this.CopyTextButton.UseVisualStyleBackColor = false;
            this.CopyTextButton.Click += new System.EventHandler(this.CopyTextButton_Click);
            // 
            // PasteButton
            // 
            this.PasteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.PasteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.PasteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PasteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasteButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasteButton.Image = global::GUI.Properties.Resources._16pxPaste;
            this.PasteButton.Location = new System.Drawing.Point(384, 116);
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(23, 23);
            this.PasteButton.TabIndex = 22;
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 116);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 20;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CharacterPanel
            // 
            this.CharacterPanel.Controls.Add(this.CharactersLabel);
            this.CharacterPanel.Location = new System.Drawing.Point(274, 59);
            this.CharacterPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CharacterPanel.Name = "CharacterPanel";
            this.CharacterPanel.Size = new System.Drawing.Size(136, 15);
            this.CharacterPanel.TabIndex = 19;
            // 
            // CharactersLabel
            // 
            this.CharactersLabel.AutoSize = true;
            this.CharactersLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CharactersLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CharactersLabel.Location = new System.Drawing.Point(70, 0);
            this.CharactersLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CharactersLabel.Name = "CharactersLabel";
            this.CharactersLabel.Size = new System.Drawing.Size(66, 13);
            this.CharactersLabel.TabIndex = 5;
            this.CharactersLabel.Text = "0 characters";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordLabel.Location = new System.Drawing.Point(8, 10);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(121, 13);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Enter the new password";
            // 
            // PasswordPictureBox
            // 
            this.PasswordPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordPictureBox.Image = global::GUI.Properties.Resources._64pxGeneratePassword;
            this.PasswordPictureBox.Location = new System.Drawing.Point(12, 26);
            this.PasswordPictureBox.Name = "PasswordPictureBox";
            this.PasswordPictureBox.Size = new System.Drawing.Size(27, 27);
            this.PasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordPictureBox.TabIndex = 17;
            this.PasswordPictureBox.TabStop = false;
            // 
            // PasswordTextBoxPanel
            // 
            this.PasswordTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasswordTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasswordTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PasswordTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.PasswordTextBoxPanel.Location = new System.Drawing.Point(45, 27);
            this.PasswordTextBoxPanel.Name = "PasswordTextBoxPanel";
            this.PasswordTextBoxPanel.ReadOnly = false;
            this.PasswordTextBoxPanel.Size = new System.Drawing.Size(362, 27);
            this.PasswordTextBoxPanel.TabIndex = 25;
            this.PasswordTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PasswordTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            this.PasswordTextBoxPanel.TextChange += new System.EventHandler(this.PasswordTextBoxPanel_TextChange);
            // 
            // PasswordLengthUpDown
            // 
            this.PasswordLengthUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasswordLengthUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PasswordLengthUpDown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordLengthUpDown.Location = new System.Drawing.Point(221, 59);
            this.PasswordLengthUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PasswordLengthUpDown.Name = "PasswordLengthUpDown";
            this.PasswordLengthUpDown.Size = new System.Drawing.Size(45, 23);
            this.PasswordLengthUpDown.TabIndex = 28;
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GeneratePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneratePasswordButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GeneratePasswordButton.Image = global::GUI.Properties.Resources._16pxGeneratePassword;
            this.GeneratePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GeneratePasswordButton.Location = new System.Drawing.Point(45, 59);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(167, 23);
            this.GeneratePasswordButton.TabIndex = 26;
            this.GeneratePasswordButton.Text = "Generate random password";
            this.GeneratePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneratePasswordButton.UseVisualStyleBackColor = false;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // PasswordInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(418, 152);
            this.Controls.Add(this.PasswordLengthUpDown);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Controls.Add(this.PasswordTextBoxPanel);
            this.Controls.Add(this.CopyTextButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.CharacterPanel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.PasswordPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PasswordInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New password";
            this.Shown += new System.EventHandler(this.PasswordInputDialog_Shown);
            this.CharacterPanel.ResumeLayout(false);
            this.CharacterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CopyTextButton;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Panel CharacterPanel;
        private System.Windows.Forms.Label CharactersLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.PictureBox PasswordPictureBox;
        private TextBoxPanel PasswordTextBoxPanel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.NumericUpDown PasswordLengthUpDown;
        private System.Windows.Forms.Button GeneratePasswordButton;
    }
}