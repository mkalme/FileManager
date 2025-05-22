namespace GUI {
    partial class NewKeyDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewKeyDialog));
            this.CharacterPanel = new System.Windows.Forms.Panel();
            this.CharactersLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyPictureBox = new System.Windows.Forms.PictureBox();
            this.KeyTextBoxPanel = new System.Windows.Forms.Panel();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.GenerateKeyButon = new System.Windows.Forms.Button();
            this.PasteButton = new System.Windows.Forms.Button();
            this.CopyTextButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FormatLabel = new System.Windows.Forms.Label();
            this.CharacterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).BeginInit();
            this.KeyTextBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CharacterPanel
            // 
            this.CharacterPanel.Controls.Add(this.CharactersLabel);
            this.CharacterPanel.Location = new System.Drawing.Point(250, 59);
            this.CharacterPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CharacterPanel.Name = "CharacterPanel";
            this.CharacterPanel.Size = new System.Drawing.Size(160, 15);
            this.CharacterPanel.TabIndex = 10;
            // 
            // CharactersLabel
            // 
            this.CharactersLabel.AutoSize = true;
            this.CharactersLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CharactersLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CharactersLabel.Location = new System.Drawing.Point(94, 0);
            this.CharactersLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CharactersLabel.Name = "CharactersLabel";
            this.CharactersLabel.Size = new System.Drawing.Size(66, 13);
            this.CharactersLabel.TabIndex = 5;
            this.CharactersLabel.Text = "0 characters";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeyLabel.Location = new System.Drawing.Point(8, 10);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(93, 13);
            this.KeyLabel.TabIndex = 9;
            this.KeyLabel.Text = "Enter the new key";
            // 
            // KeyPictureBox
            // 
            this.KeyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KeyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("KeyPictureBox.Image")));
            this.KeyPictureBox.Location = new System.Drawing.Point(12, 26);
            this.KeyPictureBox.Name = "KeyPictureBox";
            this.KeyPictureBox.Size = new System.Drawing.Size(27, 27);
            this.KeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KeyPictureBox.TabIndex = 8;
            this.KeyPictureBox.TabStop = false;
            // 
            // KeyTextBoxPanel
            // 
            this.KeyTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KeyTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyTextBoxPanel.Controls.Add(this.KeyTextBox);
            this.KeyTextBoxPanel.Location = new System.Drawing.Point(45, 27);
            this.KeyTextBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.KeyTextBoxPanel.Name = "KeyTextBoxPanel";
            this.KeyTextBoxPanel.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.KeyTextBoxPanel.Size = new System.Drawing.Size(362, 27);
            this.KeyTextBoxPanel.TabIndex = 7;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.KeyTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeyTextBox.Location = new System.Drawing.Point(2, 2);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.PasswordChar = '●';
            this.KeyTextBox.Size = new System.Drawing.Size(358, 23);
            this.KeyTextBox.TabIndex = 0;
            this.KeyTextBox.TextChanged += new System.EventHandler(this.KeyTextBox_TextChanged);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(12, 116);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // GenerateKeyButon
            // 
            this.GenerateKeyButon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GenerateKeyButon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateKeyButon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GenerateKeyButon.Location = new System.Drawing.Point(45, 59);
            this.GenerateKeyButon.Name = "GenerateKeyButon";
            this.GenerateKeyButon.Size = new System.Drawing.Size(128, 23);
            this.GenerateKeyButon.TabIndex = 12;
            this.GenerateKeyButon.Text = "Generate random key";
            this.GenerateKeyButon.UseVisualStyleBackColor = false;
            this.GenerateKeyButon.Click += new System.EventHandler(this.GenerateKeyButton_Click);
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
            this.PasteButton.TabIndex = 14;
            this.PasteButton.UseVisualStyleBackColor = false;
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
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
            this.CopyTextButton.TabIndex = 15;
            this.CopyTextButton.UseVisualStyleBackColor = false;
            this.CopyTextButton.Click += new System.EventHandler(this.CopyTextButton_Click);
            // 
            // ToolTip
            // 
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ToolTip.ForeColor = System.Drawing.SystemColors.HighlightText;
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FormatLabel.ForeColor = System.Drawing.Color.LightGray;
            this.FormatLabel.Location = new System.Drawing.Point(346, 12);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(63, 12);
            this.FormatLabel.TabIndex = 16;
            this.FormatLabel.Text = "ASCII Format";
            // 
            // NewKeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(418, 152);
            this.Controls.Add(this.FormatLabel);
            this.Controls.Add(this.CopyTextButton);
            this.Controls.Add(this.PasteButton);
            this.Controls.Add(this.GenerateKeyButon);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.CharacterPanel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeyPictureBox);
            this.Controls.Add(this.KeyTextBoxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewKeyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New key";
            this.Shown += new System.EventHandler(this.NewKeyDialog_Shown);
            this.CharacterPanel.ResumeLayout(false);
            this.CharacterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).EndInit();
            this.KeyTextBoxPanel.ResumeLayout(false);
            this.KeyTextBoxPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CharacterPanel;
        private System.Windows.Forms.Label CharactersLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.PictureBox KeyPictureBox;
        private System.Windows.Forms.Panel KeyTextBoxPanel;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button GenerateKeyButon;
        private System.Windows.Forms.Button PasteButton;
        private System.Windows.Forms.Button CopyTextButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label FormatLabel;
    }
}