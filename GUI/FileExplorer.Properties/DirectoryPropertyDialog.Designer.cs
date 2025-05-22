namespace GUI {
    partial class DirectoryPropertyDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryPropertyDialog));
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.DateSeperatorLabel = new System.Windows.Forms.Label();
            this.SeperatorNameLabel = new System.Windows.Forms.Label();
            this.DateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.ModificationTextBox = new System.Windows.Forms.TextBox();
            this.InfoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContainsLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.ContainsTextBox = new System.Windows.Forms.TextBox();
            this.InfoSeperatorLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NameTextBoxPanel = new GUI.TextBoxPanel();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.DateTableLayoutPanel.SuspendLayout();
            this.InfoTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackgroundPanel.Controls.Add(this.NameTextBoxPanel);
            this.BackgroundPanel.Controls.Add(this.IconPictureBox);
            this.BackgroundPanel.Controls.Add(this.DateSeperatorLabel);
            this.BackgroundPanel.Controls.Add(this.SeperatorNameLabel);
            this.BackgroundPanel.Controls.Add(this.DateTableLayoutPanel);
            this.BackgroundPanel.Controls.Add(this.InfoTableLayoutPanel);
            this.BackgroundPanel.Controls.Add(this.InfoSeperatorLabel);
            this.BackgroundPanel.Location = new System.Drawing.Point(8, 8);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(335, 321);
            this.BackgroundPanel.TabIndex = 12;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconPictureBox.Image = global::GUI.Properties.Resources._64pxFolder;
            this.IconPictureBox.Location = new System.Drawing.Point(13, 12);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(35, 35);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            // 
            // DateSeperatorLabel
            // 
            this.DateSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateSeperatorLabel.ForeColor = System.Drawing.Color.Silver;
            this.DateSeperatorLabel.Location = new System.Drawing.Point(15, 214);
            this.DateSeperatorLabel.Name = "DateSeperatorLabel";
            this.DateSeperatorLabel.Size = new System.Drawing.Size(306, 1);
            this.DateSeperatorLabel.TabIndex = 7;
            // 
            // SeperatorNameLabel
            // 
            this.SeperatorNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SeperatorNameLabel.ForeColor = System.Drawing.Color.Silver;
            this.SeperatorNameLabel.Location = new System.Drawing.Point(15, 53);
            this.SeperatorNameLabel.Name = "SeperatorNameLabel";
            this.SeperatorNameLabel.Size = new System.Drawing.Size(306, 1);
            this.SeperatorNameLabel.TabIndex = 2;
            // 
            // DateTableLayoutPanel
            // 
            this.DateTableLayoutPanel.ColumnCount = 2;
            this.DateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.19547F));
            this.DateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.80453F));
            this.DateTableLayoutPanel.Controls.Add(this.ModifiedLabel, 0, 1);
            this.DateTableLayoutPanel.Controls.Add(this.CreatedLabel, 0, 0);
            this.DateTableLayoutPanel.Controls.Add(this.CreatedTextBox, 1, 0);
            this.DateTableLayoutPanel.Controls.Add(this.ModificationTextBox, 1, 1);
            this.DateTableLayoutPanel.Location = new System.Drawing.Point(12, 153);
            this.DateTableLayoutPanel.Name = "DateTableLayoutPanel";
            this.DateTableLayoutPanel.RowCount = 2;
            this.DateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DateTableLayoutPanel.Size = new System.Drawing.Size(310, 54);
            this.DateTableLayoutPanel.TabIndex = 5;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ModifiedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ModifiedLabel.Location = new System.Drawing.Point(1, 34);
            this.ModifiedLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLabel.TabIndex = 6;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CreatedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreatedLabel.Location = new System.Drawing.Point(1, 7);
            this.CreatedLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 0;
            this.CreatedLabel.Text = "Created:";
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CreatedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CreatedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CreatedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CreatedTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CreatedTextBox.Location = new System.Drawing.Point(87, 7);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(220, 13);
            this.CreatedTextBox.TabIndex = 4;
            this.CreatedTextBox.WordWrap = false;
            // 
            // ModificationTextBox
            // 
            this.ModificationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ModificationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ModificationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModificationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ModificationTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ModificationTextBox.Location = new System.Drawing.Point(87, 34);
            this.ModificationTextBox.Name = "ModificationTextBox";
            this.ModificationTextBox.ReadOnly = true;
            this.ModificationTextBox.Size = new System.Drawing.Size(220, 13);
            this.ModificationTextBox.TabIndex = 5;
            this.ModificationTextBox.WordWrap = false;
            // 
            // InfoTableLayoutPanel
            // 
            this.InfoTableLayoutPanel.ColumnCount = 2;
            this.InfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.19547F));
            this.InfoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.80453F));
            this.InfoTableLayoutPanel.Controls.Add(this.ContainsLabel, 0, 2);
            this.InfoTableLayoutPanel.Controls.Add(this.TypeLabel, 0, 0);
            this.InfoTableLayoutPanel.Controls.Add(this.LocationLabel, 0, 1);
            this.InfoTableLayoutPanel.Controls.Add(this.TypeTextBox, 1, 0);
            this.InfoTableLayoutPanel.Controls.Add(this.LocationTextBox, 1, 1);
            this.InfoTableLayoutPanel.Controls.Add(this.ContainsTextBox, 1, 2);
            this.InfoTableLayoutPanel.Location = new System.Drawing.Point(12, 60);
            this.InfoTableLayoutPanel.Name = "InfoTableLayoutPanel";
            this.InfoTableLayoutPanel.RowCount = 3;
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InfoTableLayoutPanel.Size = new System.Drawing.Size(310, 81);
            this.InfoTableLayoutPanel.TabIndex = 3;
            // 
            // ContainsLabel
            // 
            this.ContainsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContainsLabel.AutoSize = true;
            this.ContainsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ContainsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ContainsLabel.Location = new System.Drawing.Point(1, 61);
            this.ContainsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.ContainsLabel.Name = "ContainsLabel";
            this.ContainsLabel.Size = new System.Drawing.Size(51, 13);
            this.ContainsLabel.TabIndex = 3;
            this.ContainsLabel.Text = "Contains:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeLabel.Location = new System.Drawing.Point(1, 7);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationLabel.Location = new System.Drawing.Point(1, 34);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(51, 13);
            this.LocationLabel.TabIndex = 1;
            this.LocationLabel.Text = "Location:";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TypeTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeTextBox.Location = new System.Drawing.Point(87, 7);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.ReadOnly = true;
            this.TypeTextBox.Size = new System.Drawing.Size(220, 13);
            this.TypeTextBox.TabIndex = 4;
            this.TypeTextBox.Text = "Directory";
            this.TypeTextBox.WordWrap = false;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LocationTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationTextBox.Location = new System.Drawing.Point(87, 34);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(220, 13);
            this.LocationTextBox.TabIndex = 5;
            this.LocationTextBox.WordWrap = false;
            // 
            // ContainsTextBox
            // 
            this.ContainsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ContainsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ContainsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContainsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ContainsTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ContainsTextBox.Location = new System.Drawing.Point(87, 61);
            this.ContainsTextBox.Name = "ContainsTextBox";
            this.ContainsTextBox.ReadOnly = true;
            this.ContainsTextBox.Size = new System.Drawing.Size(220, 13);
            this.ContainsTextBox.TabIndex = 7;
            this.ContainsTextBox.WordWrap = false;
            // 
            // InfoSeperatorLabel
            // 
            this.InfoSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoSeperatorLabel.ForeColor = System.Drawing.Color.Silver;
            this.InfoSeperatorLabel.Location = new System.Drawing.Point(15, 148);
            this.InfoSeperatorLabel.Name = "InfoSeperatorLabel";
            this.InfoSeperatorLabel.Size = new System.Drawing.Size(306, 1);
            this.InfoSeperatorLabel.TabIndex = 4;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(268, 338);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NameTextBoxPanel
            // 
            this.NameTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.NameTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.NameTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.NameTextBoxPanel.DisabledForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBoxPanel.Location = new System.Drawing.Point(97, 19);
            this.NameTextBoxPanel.Name = "NameTextBoxPanel";
            this.NameTextBoxPanel.ReadOnly = true;
            this.NameTextBoxPanel.Size = new System.Drawing.Size(225, 22);
            this.NameTextBoxPanel.TabIndex = 19;
            this.NameTextBoxPanel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NameTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            // 
            // DirectoryPropertyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(350, 369);
            this.Controls.Add(this.BackgroundPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DirectoryPropertyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Directory";
            this.BackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.DateTableLayoutPanel.ResumeLayout(false);
            this.DateTableLayoutPanel.PerformLayout();
            this.InfoTableLayoutPanel.ResumeLayout(false);
            this.InfoTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Label DateSeperatorLabel;
        private System.Windows.Forms.Label SeperatorNameLabel;
        private System.Windows.Forms.TableLayoutPanel DateTableLayoutPanel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.TableLayoutPanel InfoTableLayoutPanel;
        private System.Windows.Forms.Label ContainsLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox ContainsTextBox;
        private System.Windows.Forms.Label InfoSeperatorLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.TextBox ModificationTextBox;
        private TextBoxPanel NameTextBoxPanel;
    }
}