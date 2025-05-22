namespace GUI {
    partial class DocumentPropertyDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentPropertyDialog));
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
            this.StyleTextBox = new System.Windows.Forms.TextBox();
            this.FontStyleLabel = new System.Windows.Forms.Label();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.FontFamilyLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.FontTextBox = new System.Windows.Forms.TextBox();
            this.ColorContainer = new System.Windows.Forms.Panel();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.ForeColorLabel = new System.Windows.Forms.Label();
            this.InfoSeperatorLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NameTextBoxPanel = new GUI.TextBoxPanel();
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.DateTableLayoutPanel.SuspendLayout();
            this.InfoTableLayoutPanel.SuspendLayout();
            this.ColorContainer.SuspendLayout();
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
            this.BackgroundPanel.TabIndex = 14;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconPictureBox.Image = global::GUI.Properties.Resources._64pxDocument;
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
            this.DateSeperatorLabel.Location = new System.Drawing.Point(15, 295);
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
            this.DateTableLayoutPanel.Location = new System.Drawing.Point(12, 234);
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
            this.InfoTableLayoutPanel.Controls.Add(this.StyleTextBox, 1, 4);
            this.InfoTableLayoutPanel.Controls.Add(this.FontStyleLabel, 0, 4);
            this.InfoTableLayoutPanel.Controls.Add(this.SizeTextBox, 1, 3);
            this.InfoTableLayoutPanel.Controls.Add(this.FontSizeLabel, 0, 3);
            this.InfoTableLayoutPanel.Controls.Add(this.FontFamilyLabel, 0, 2);
            this.InfoTableLayoutPanel.Controls.Add(this.TypeLabel, 0, 0);
            this.InfoTableLayoutPanel.Controls.Add(this.LocationLabel, 0, 1);
            this.InfoTableLayoutPanel.Controls.Add(this.TypeTextBox, 1, 0);
            this.InfoTableLayoutPanel.Controls.Add(this.LocationTextBox, 1, 1);
            this.InfoTableLayoutPanel.Controls.Add(this.FontTextBox, 1, 2);
            this.InfoTableLayoutPanel.Controls.Add(this.ColorContainer, 1, 5);
            this.InfoTableLayoutPanel.Controls.Add(this.ForeColorLabel, 0, 5);
            this.InfoTableLayoutPanel.Location = new System.Drawing.Point(12, 60);
            this.InfoTableLayoutPanel.Name = "InfoTableLayoutPanel";
            this.InfoTableLayoutPanel.RowCount = 6;
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.InfoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.InfoTableLayoutPanel.Size = new System.Drawing.Size(310, 162);
            this.InfoTableLayoutPanel.TabIndex = 3;
            // 
            // StyleTextBox
            // 
            this.StyleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StyleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.StyleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StyleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.StyleTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StyleTextBox.Location = new System.Drawing.Point(87, 110);
            this.StyleTextBox.Name = "StyleTextBox";
            this.StyleTextBox.ReadOnly = true;
            this.StyleTextBox.Size = new System.Drawing.Size(220, 13);
            this.StyleTextBox.TabIndex = 14;
            this.StyleTextBox.WordWrap = false;
            // 
            // FontStyleLabel
            // 
            this.FontStyleLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FontStyleLabel.AutoSize = true;
            this.FontStyleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FontStyleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FontStyleLabel.Location = new System.Drawing.Point(1, 110);
            this.FontStyleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.FontStyleLabel.Name = "FontStyleLabel";
            this.FontStyleLabel.Size = new System.Drawing.Size(55, 13);
            this.FontStyleLabel.TabIndex = 13;
            this.FontStyleLabel.Text = "Font style:";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SizeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SizeTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SizeTextBox.Location = new System.Drawing.Point(87, 84);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.ReadOnly = true;
            this.SizeTextBox.Size = new System.Drawing.Size(220, 13);
            this.SizeTextBox.TabIndex = 11;
            this.SizeTextBox.WordWrap = false;
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FontSizeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FontSizeLabel.Location = new System.Drawing.Point(1, 84);
            this.FontSizeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(52, 13);
            this.FontSizeLabel.TabIndex = 10;
            this.FontSizeLabel.Text = "Font size:";
            // 
            // FontFamilyLabel
            // 
            this.FontFamilyLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FontFamilyLabel.AutoSize = true;
            this.FontFamilyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FontFamilyLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FontFamilyLabel.Location = new System.Drawing.Point(1, 58);
            this.FontFamilyLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.FontFamilyLabel.Name = "FontFamilyLabel";
            this.FontFamilyLabel.Size = new System.Drawing.Size(60, 13);
            this.FontFamilyLabel.TabIndex = 3;
            this.FontFamilyLabel.Text = "Font family:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TypeLabel.Location = new System.Drawing.Point(1, 6);
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
            this.LocationLabel.Location = new System.Drawing.Point(1, 32);
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
            this.TypeTextBox.Location = new System.Drawing.Point(87, 6);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.ReadOnly = true;
            this.TypeTextBox.Size = new System.Drawing.Size(220, 13);
            this.TypeTextBox.TabIndex = 4;
            this.TypeTextBox.Text = "Document";
            this.TypeTextBox.WordWrap = false;
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LocationTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocationTextBox.Location = new System.Drawing.Point(87, 32);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(220, 13);
            this.LocationTextBox.TabIndex = 5;
            this.LocationTextBox.WordWrap = false;
            // 
            // FontTextBox
            // 
            this.FontTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FontTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.FontTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FontTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FontTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FontTextBox.Location = new System.Drawing.Point(87, 58);
            this.FontTextBox.Name = "FontTextBox";
            this.FontTextBox.ReadOnly = true;
            this.FontTextBox.Size = new System.Drawing.Size(220, 13);
            this.FontTextBox.TabIndex = 7;
            this.FontTextBox.WordWrap = false;
            // 
            // ColorContainer
            // 
            this.ColorContainer.Controls.Add(this.ColorTextBox);
            this.ColorContainer.Controls.Add(this.ColorPanel);
            this.ColorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorContainer.Location = new System.Drawing.Point(84, 130);
            this.ColorContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ColorContainer.Name = "ColorContainer";
            this.ColorContainer.Size = new System.Drawing.Size(226, 32);
            this.ColorContainer.TabIndex = 9;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ColorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ColorTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ColorTextBox.Location = new System.Drawing.Point(32, 9);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.ReadOnly = true;
            this.ColorTextBox.Size = new System.Drawing.Size(191, 13);
            this.ColorTextBox.TabIndex = 12;
            this.ColorTextBox.WordWrap = false;
            // 
            // ColorPanel
            // 
            this.ColorPanel.Location = new System.Drawing.Point(3, 6);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(20, 20);
            this.ColorPanel.TabIndex = 0;
            // 
            // ForeColorLabel
            // 
            this.ForeColorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ForeColorLabel.AutoSize = true;
            this.ForeColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ForeColorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ForeColorLabel.Location = new System.Drawing.Point(1, 139);
            this.ForeColorLabel.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.ForeColorLabel.Name = "ForeColorLabel";
            this.ForeColorLabel.Size = new System.Drawing.Size(57, 13);
            this.ForeColorLabel.TabIndex = 8;
            this.ForeColorLabel.Text = "Fore color:";
            // 
            // InfoSeperatorLabel
            // 
            this.InfoSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoSeperatorLabel.ForeColor = System.Drawing.Color.Silver;
            this.InfoSeperatorLabel.Location = new System.Drawing.Point(15, 229);
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
            this.CloseButton.TabIndex = 13;
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
            this.NameTextBoxPanel.TabIndex = 18;
            this.NameTextBoxPanel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.NameTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0, -2, 0, 0);
            // 
            // DocumentPropertyDialog
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
            this.Name = "DocumentPropertyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document";
            this.BackgroundPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.DateTableLayoutPanel.ResumeLayout(false);
            this.DateTableLayoutPanel.PerformLayout();
            this.InfoTableLayoutPanel.ResumeLayout(false);
            this.InfoTableLayoutPanel.PerformLayout();
            this.ColorContainer.ResumeLayout(false);
            this.ColorContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Label DateSeperatorLabel;
        private System.Windows.Forms.Label SeperatorNameLabel;
        private System.Windows.Forms.TableLayoutPanel DateTableLayoutPanel;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.TextBox ModificationTextBox;
        private System.Windows.Forms.TableLayoutPanel InfoTableLayoutPanel;
        private System.Windows.Forms.Label FontFamilyLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.TextBox FontTextBox;
        private System.Windows.Forms.Label InfoSeperatorLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label ForeColorLabel;
        private System.Windows.Forms.Panel ColorContainer;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.TextBox StyleTextBox;
        private System.Windows.Forms.Label FontStyleLabel;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private TextBoxPanel NameTextBoxPanel;
    }
}