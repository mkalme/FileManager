namespace GUI {
    partial class FileDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileDialog));
            this.WebsiteGroupBox = new GUI.CustomGroupBox();
            this.WebsiteTextBoxPanel = new GUI.TextBoxPanel();
            this.PasswordGroupBox = new GUI.CustomGroupBox();
            this.CharacterLengthPanel = new System.Windows.Forms.Panel();
            this.CharactersLengthLabel = new System.Windows.Forms.Label();
            this.PasswordTextBoxPanel = new GUI.TextBoxPanel();
            this.CopyPasswordLink = new System.Windows.Forms.LinkLabel();
            this.EmailGroupBox = new GUI.CustomGroupBox();
            this.EmailTextBoxPanel = new GUI.TextBoxPanel();
            this.CopyEmailLink = new System.Windows.Forms.LinkLabel();
            this.NotesGroupBox = new GUI.CustomGroupBox();
            this.NotesRichTextBoxPanel = new GUI.Panel.RichTextBoxPanel();
            this.ZoomNotesButton = new System.Windows.Forms.Button();
            this.CopyNotesLink = new System.Windows.Forms.LinkLabel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.Entry1GroupBox = new GUI.CustomGroupBox();
            this.Entry1PasswordTextBoxPanel = new GUI.TextBoxPanel();
            this.Entry1NameTextBoxPanel = new GUI.TextBoxPanel();
            this.Entry1NameLink = new GUI.CustomLink();
            this.Entry1CopyPasswordLink = new System.Windows.Forms.LinkLabel();
            this.Entry1PasswordLabel = new System.Windows.Forms.Label();
            this.Entry1NameLabel = new System.Windows.Forms.Label();
            this.Entry2GroupBox = new GUI.CustomGroupBox();
            this.Entry2PasswordTextBoxPanel = new GUI.TextBoxPanel();
            this.Entry2NameTextBoxPanel = new GUI.TextBoxPanel();
            this.Entry2NameLink = new GUI.CustomLink();
            this.Entry2CopyPasswordLink = new System.Windows.Forms.LinkLabel();
            this.Entry2PasswordLabel = new System.Windows.Forms.Label();
            this.Entry2NameLabel = new System.Windows.Forms.Label();
            this.GenerateGroupBox = new GUI.CustomGroupBox();
            this.GeneratedTextBoxPanel = new GUI.TextBoxPanel();
            this.PasswordLengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.CopyGeneratedPasswordLink = new System.Windows.Forms.LinkLabel();
            this.EditableCheckBox = new System.Windows.Forms.CheckBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NameGroupBox = new GUI.CustomGroupBox();
            this.NameTextBoxPanel = new GUI.TextBoxPanel();
            this.WebsiteGroupBox.SuspendLayout();
            this.PasswordGroupBox.SuspendLayout();
            this.CharacterLengthPanel.SuspendLayout();
            this.EmailGroupBox.SuspendLayout();
            this.NotesGroupBox.SuspendLayout();
            this.Entry1GroupBox.SuspendLayout();
            this.Entry2GroupBox.SuspendLayout();
            this.GenerateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthUpDown)).BeginInit();
            this.NameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebsiteGroupBox
            // 
            this.WebsiteGroupBox.BorderColor = System.Drawing.Color.DimGray;
            this.WebsiteGroupBox.Controls.Add(this.WebsiteTextBoxPanel);
            this.WebsiteGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.WebsiteGroupBox.Location = new System.Drawing.Point(11, 70);
            this.WebsiteGroupBox.Name = "WebsiteGroupBox";
            this.WebsiteGroupBox.Size = new System.Drawing.Size(238, 47);
            this.WebsiteGroupBox.TabIndex = 1;
            this.WebsiteGroupBox.TabStop = false;
            this.WebsiteGroupBox.Text = "Website";
            // 
            // WebsiteTextBoxPanel
            // 
            this.WebsiteTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.WebsiteTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.WebsiteTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.WebsiteTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebsiteTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.WebsiteTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.WebsiteTextBoxPanel.Location = new System.Drawing.Point(6, 16);
            this.WebsiteTextBoxPanel.Name = "WebsiteTextBoxPanel";
            this.WebsiteTextBoxPanel.ReadOnly = false;
            this.WebsiteTextBoxPanel.Size = new System.Drawing.Size(226, 21);
            this.WebsiteTextBoxPanel.TabIndex = 12;
            this.WebsiteTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.WebsiteTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // PasswordGroupBox
            // 
            this.PasswordGroupBox.BorderColor = System.Drawing.Color.DimGray;
            this.PasswordGroupBox.Controls.Add(this.CharacterLengthPanel);
            this.PasswordGroupBox.Controls.Add(this.PasswordTextBoxPanel);
            this.PasswordGroupBox.Controls.Add(this.CopyPasswordLink);
            this.PasswordGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordGroupBox.Location = new System.Drawing.Point(11, 124);
            this.PasswordGroupBox.Name = "PasswordGroupBox";
            this.PasswordGroupBox.Size = new System.Drawing.Size(238, 66);
            this.PasswordGroupBox.TabIndex = 2;
            this.PasswordGroupBox.TabStop = false;
            this.PasswordGroupBox.Text = "Password";
            // 
            // CharacterLengthPanel
            // 
            this.CharacterLengthPanel.Controls.Add(this.CharactersLengthLabel);
            this.CharacterLengthPanel.Location = new System.Drawing.Point(126, 40);
            this.CharacterLengthPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CharacterLengthPanel.Name = "CharacterLengthPanel";
            this.CharacterLengthPanel.Size = new System.Drawing.Size(109, 15);
            this.CharacterLengthPanel.TabIndex = 11;
            // 
            // CharactersLengthLabel
            // 
            this.CharactersLengthLabel.AutoSize = true;
            this.CharactersLengthLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CharactersLengthLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CharactersLengthLabel.Location = new System.Drawing.Point(43, 0);
            this.CharactersLengthLabel.Margin = new System.Windows.Forms.Padding(0);
            this.CharactersLengthLabel.Name = "CharactersLengthLabel";
            this.CharactersLengthLabel.Size = new System.Drawing.Size(66, 13);
            this.CharactersLengthLabel.TabIndex = 5;
            this.CharactersLengthLabel.Text = "0 characters";
            // 
            // PasswordTextBoxPanel
            // 
            this.PasswordTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasswordTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasswordTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.PasswordTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.PasswordTextBoxPanel.Location = new System.Drawing.Point(6, 16);
            this.PasswordTextBoxPanel.Name = "PasswordTextBoxPanel";
            this.PasswordTextBoxPanel.ReadOnly = false;
            this.PasswordTextBoxPanel.Size = new System.Drawing.Size(226, 21);
            this.PasswordTextBoxPanel.TabIndex = 13;
            this.PasswordTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.PasswordTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            this.PasswordTextBoxPanel.TextChange += new System.EventHandler(this.PasswordTextBoxPanel_TextChange);
            // 
            // CopyPasswordLink
            // 
            this.CopyPasswordLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.CopyPasswordLink.AutoSize = true;
            this.CopyPasswordLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyPasswordLink.Location = new System.Drawing.Point(6, 40);
            this.CopyPasswordLink.Name = "CopyPasswordLink";
            this.CopyPasswordLink.Size = new System.Drawing.Size(89, 13);
            this.CopyPasswordLink.TabIndex = 1;
            this.CopyPasswordLink.TabStop = true;
            this.CopyPasswordLink.Text = "Copy to clipboard";
            this.CopyPasswordLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyPasswordLink_LinkClicked);
            // 
            // EmailGroupBox
            // 
            this.EmailGroupBox.BorderColor = System.Drawing.Color.DimGray;
            this.EmailGroupBox.Controls.Add(this.EmailTextBoxPanel);
            this.EmailGroupBox.Controls.Add(this.CopyEmailLink);
            this.EmailGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EmailGroupBox.Location = new System.Drawing.Point(11, 197);
            this.EmailGroupBox.Name = "EmailGroupBox";
            this.EmailGroupBox.Size = new System.Drawing.Size(238, 66);
            this.EmailGroupBox.TabIndex = 3;
            this.EmailGroupBox.TabStop = false;
            this.EmailGroupBox.Text = "E-Mail";
            // 
            // EmailTextBoxPanel
            // 
            this.EmailTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EmailTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.EmailTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EmailTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.EmailTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.EmailTextBoxPanel.Location = new System.Drawing.Point(6, 16);
            this.EmailTextBoxPanel.Name = "EmailTextBoxPanel";
            this.EmailTextBoxPanel.ReadOnly = false;
            this.EmailTextBoxPanel.Size = new System.Drawing.Size(226, 21);
            this.EmailTextBoxPanel.TabIndex = 14;
            this.EmailTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.EmailTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // CopyEmailLink
            // 
            this.CopyEmailLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.CopyEmailLink.AutoSize = true;
            this.CopyEmailLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyEmailLink.Location = new System.Drawing.Point(6, 40);
            this.CopyEmailLink.Name = "CopyEmailLink";
            this.CopyEmailLink.Size = new System.Drawing.Size(89, 13);
            this.CopyEmailLink.TabIndex = 1;
            this.CopyEmailLink.TabStop = true;
            this.CopyEmailLink.Text = "Copy to clipboard";
            this.CopyEmailLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyEmailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyEmailLink_LinkClicked);
            // 
            // NotesGroupBox
            // 
            this.NotesGroupBox.BorderColor = System.Drawing.Color.DimGray;
            this.NotesGroupBox.Controls.Add(this.NotesRichTextBoxPanel);
            this.NotesGroupBox.Controls.Add(this.ZoomNotesButton);
            this.NotesGroupBox.Controls.Add(this.CopyNotesLink);
            this.NotesGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NotesGroupBox.Location = new System.Drawing.Point(11, 270);
            this.NotesGroupBox.Name = "NotesGroupBox";
            this.NotesGroupBox.Size = new System.Drawing.Size(238, 120);
            this.NotesGroupBox.TabIndex = 4;
            this.NotesGroupBox.TabStop = false;
            this.NotesGroupBox.Text = "Notes";
            // 
            // NotesRichTextBoxPanel
            // 
            this.NotesRichTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NotesRichTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesRichTextBoxPanel.InputText = "";
            this.NotesRichTextBoxPanel.Location = new System.Drawing.Point(6, 35);
            this.NotesRichTextBoxPanel.Name = "NotesRichTextBoxPanel";
            this.NotesRichTextBoxPanel.Padding = new System.Windows.Forms.Padding(3);
            this.NotesRichTextBoxPanel.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NotesRichTextBoxPanel.ReadOnly = false;
            this.NotesRichTextBoxPanel.Size = new System.Drawing.Size(226, 77);
            this.NotesRichTextBoxPanel.TabIndex = 12;
            this.NotesRichTextBoxPanel.TextColor = System.Drawing.SystemColors.HighlightText;
            this.NotesRichTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            // 
            // ZoomNotesButton
            // 
            this.ZoomNotesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ZoomNotesButton.FlatAppearance.BorderSize = 0;
            this.ZoomNotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZoomNotesButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ZoomNotesButton.Image = global::GUI.Properties.Resources._16pxZoom;
            this.ZoomNotesButton.Location = new System.Drawing.Point(213, 13);
            this.ZoomNotesButton.Name = "ZoomNotesButton";
            this.ZoomNotesButton.Size = new System.Drawing.Size(18, 18);
            this.ZoomNotesButton.TabIndex = 11;
            this.ZoomNotesButton.UseVisualStyleBackColor = false;
            this.ZoomNotesButton.Click += new System.EventHandler(this.ZoomNotesButton_Click);
            // 
            // CopyNotesLink
            // 
            this.CopyNotesLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.CopyNotesLink.AutoSize = true;
            this.CopyNotesLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyNotesLink.Location = new System.Drawing.Point(6, 15);
            this.CopyNotesLink.Name = "CopyNotesLink";
            this.CopyNotesLink.Size = new System.Drawing.Size(89, 13);
            this.CopyNotesLink.TabIndex = 2;
            this.CopyNotesLink.TabStop = true;
            this.CopyNotesLink.Text = "Copy to clipboard";
            this.CopyNotesLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyNotesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyNotesLink_LinkClicked);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SaveButton.Location = new System.Drawing.Point(11, 410);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(95, 25);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CancelDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDialogButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelDialogButton.Location = new System.Drawing.Point(112, 410);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(95, 25);
            this.CancelDialogButton.TabIndex = 6;
            this.CancelDialogButton.Text = "Cancel";
            this.CancelDialogButton.UseVisualStyleBackColor = false;
            this.CancelDialogButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Entry1GroupBox
            // 
            this.Entry1GroupBox.BorderColor = System.Drawing.Color.DimGray;
            this.Entry1GroupBox.Controls.Add(this.Entry1PasswordTextBoxPanel);
            this.Entry1GroupBox.Controls.Add(this.Entry1NameTextBoxPanel);
            this.Entry1GroupBox.Controls.Add(this.Entry1NameLink);
            this.Entry1GroupBox.Controls.Add(this.Entry1CopyPasswordLink);
            this.Entry1GroupBox.Controls.Add(this.Entry1PasswordLabel);
            this.Entry1GroupBox.Controls.Add(this.Entry1NameLabel);
            this.Entry1GroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Entry1GroupBox.Location = new System.Drawing.Point(256, 16);
            this.Entry1GroupBox.Name = "Entry1GroupBox";
            this.Entry1GroupBox.Size = new System.Drawing.Size(238, 131);
            this.Entry1GroupBox.TabIndex = 7;
            this.Entry1GroupBox.TabStop = false;
            this.Entry1GroupBox.Text = "Entry #1";
            // 
            // Entry1PasswordTextBoxPanel
            // 
            this.Entry1PasswordTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Entry1PasswordTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.Entry1PasswordTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Entry1PasswordTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Entry1PasswordTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Entry1PasswordTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Entry1PasswordTextBoxPanel.Location = new System.Drawing.Point(6, 85);
            this.Entry1PasswordTextBoxPanel.Name = "Entry1PasswordTextBoxPanel";
            this.Entry1PasswordTextBoxPanel.ReadOnly = false;
            this.Entry1PasswordTextBoxPanel.Size = new System.Drawing.Size(226, 21);
            this.Entry1PasswordTextBoxPanel.TabIndex = 16;
            this.Entry1PasswordTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.Entry1PasswordTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // Entry1NameTextBoxPanel
            // 
            this.Entry1NameTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Entry1NameTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.Entry1NameTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Entry1NameTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Entry1NameTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Entry1NameTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Entry1NameTextBoxPanel.Location = new System.Drawing.Point(6, 39);
            this.Entry1NameTextBoxPanel.Name = "Entry1NameTextBoxPanel";
            this.Entry1NameTextBoxPanel.ReadOnly = false;
            this.Entry1NameTextBoxPanel.Size = new System.Drawing.Size(226, 21);
            this.Entry1NameTextBoxPanel.TabIndex = 15;
            this.Entry1NameTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.Entry1NameTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // Entry1NameLink
            // 
            this.Entry1NameLink.ActiveColor = System.Drawing.Color.DimGray;
            this.Entry1NameLink.AutoSize = true;
            this.Entry1NameLink.ClickEnabled = true;
            this.Entry1NameLink.Color = System.Drawing.SystemColors.HighlightText;
            this.Entry1NameLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entry1NameLink.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.Entry1NameLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Entry1NameLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Entry1NameLink.Location = new System.Drawing.Point(161, 23);
            this.Entry1NameLink.Name = "Entry1NameLink";
            this.Entry1NameLink.Size = new System.Drawing.Size(75, 13);
            this.Entry1NameLink.TabIndex = 6;
            this.Entry1NameLink.Text = "Change Name";
            this.Entry1NameLink.Click += new System.EventHandler(this.Entry1NameLink_Click);
            // 
            // Entry1CopyPasswordLink
            // 
            this.Entry1CopyPasswordLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.Entry1CopyPasswordLink.AutoSize = true;
            this.Entry1CopyPasswordLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.Entry1CopyPasswordLink.Location = new System.Drawing.Point(5, 109);
            this.Entry1CopyPasswordLink.Name = "Entry1CopyPasswordLink";
            this.Entry1CopyPasswordLink.Size = new System.Drawing.Size(89, 13);
            this.Entry1CopyPasswordLink.TabIndex = 5;
            this.Entry1CopyPasswordLink.TabStop = true;
            this.Entry1CopyPasswordLink.Text = "Copy to clipboard";
            this.Entry1CopyPasswordLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.Entry1CopyPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Entry1CopyPasswordLink_LinkClicked);
            // 
            // Entry1PasswordLabel
            // 
            this.Entry1PasswordLabel.AutoSize = true;
            this.Entry1PasswordLabel.Location = new System.Drawing.Point(5, 69);
            this.Entry1PasswordLabel.Name = "Entry1PasswordLabel";
            this.Entry1PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.Entry1PasswordLabel.TabIndex = 4;
            this.Entry1PasswordLabel.Text = "Password";
            // 
            // Entry1NameLabel
            // 
            this.Entry1NameLabel.AutoSize = true;
            this.Entry1NameLabel.Location = new System.Drawing.Point(5, 23);
            this.Entry1NameLabel.Name = "Entry1NameLabel";
            this.Entry1NameLabel.Size = new System.Drawing.Size(35, 13);
            this.Entry1NameLabel.TabIndex = 1;
            this.Entry1NameLabel.Text = "Name";
            // 
            // Entry2GroupBox
            // 
            this.Entry2GroupBox.BorderColor = System.Drawing.Color.DimGray;
            this.Entry2GroupBox.Controls.Add(this.Entry2PasswordTextBoxPanel);
            this.Entry2GroupBox.Controls.Add(this.Entry2NameTextBoxPanel);
            this.Entry2GroupBox.Controls.Add(this.Entry2NameLink);
            this.Entry2GroupBox.Controls.Add(this.Entry2CopyPasswordLink);
            this.Entry2GroupBox.Controls.Add(this.Entry2PasswordLabel);
            this.Entry2GroupBox.Controls.Add(this.Entry2NameLabel);
            this.Entry2GroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Entry2GroupBox.Location = new System.Drawing.Point(256, 152);
            this.Entry2GroupBox.Name = "Entry2GroupBox";
            this.Entry2GroupBox.Size = new System.Drawing.Size(238, 131);
            this.Entry2GroupBox.TabIndex = 8;
            this.Entry2GroupBox.TabStop = false;
            this.Entry2GroupBox.Text = "Entry #2";
            // 
            // Entry2PasswordTextBoxPanel
            // 
            this.Entry2PasswordTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Entry2PasswordTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.Entry2PasswordTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Entry2PasswordTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Entry2PasswordTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Entry2PasswordTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Entry2PasswordTextBoxPanel.Location = new System.Drawing.Point(6, 85);
            this.Entry2PasswordTextBoxPanel.Name = "Entry2PasswordTextBoxPanel";
            this.Entry2PasswordTextBoxPanel.ReadOnly = false;
            this.Entry2PasswordTextBoxPanel.Size = new System.Drawing.Size(226, 21);
            this.Entry2PasswordTextBoxPanel.TabIndex = 18;
            this.Entry2PasswordTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.Entry2PasswordTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // Entry2NameTextBoxPanel
            // 
            this.Entry2NameTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Entry2NameTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.Entry2NameTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Entry2NameTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Entry2NameTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.Entry2NameTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Entry2NameTextBoxPanel.Location = new System.Drawing.Point(6, 39);
            this.Entry2NameTextBoxPanel.Name = "Entry2NameTextBoxPanel";
            this.Entry2NameTextBoxPanel.ReadOnly = false;
            this.Entry2NameTextBoxPanel.Size = new System.Drawing.Size(226, 21);
            this.Entry2NameTextBoxPanel.TabIndex = 17;
            this.Entry2NameTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.Entry2NameTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // Entry2NameLink
            // 
            this.Entry2NameLink.ActiveColor = System.Drawing.Color.DimGray;
            this.Entry2NameLink.AutoSize = true;
            this.Entry2NameLink.ClickEnabled = true;
            this.Entry2NameLink.Color = System.Drawing.SystemColors.HighlightText;
            this.Entry2NameLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entry2NameLink.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.Entry2NameLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Entry2NameLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Entry2NameLink.Location = new System.Drawing.Point(161, 23);
            this.Entry2NameLink.Name = "Entry2NameLink";
            this.Entry2NameLink.Size = new System.Drawing.Size(75, 13);
            this.Entry2NameLink.TabIndex = 6;
            this.Entry2NameLink.Text = "Change Name";
            this.Entry2NameLink.Click += new System.EventHandler(this.Entry2NameLink_Click);
            // 
            // Entry2CopyPasswordLink
            // 
            this.Entry2CopyPasswordLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.Entry2CopyPasswordLink.AutoSize = true;
            this.Entry2CopyPasswordLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.Entry2CopyPasswordLink.Location = new System.Drawing.Point(5, 109);
            this.Entry2CopyPasswordLink.Name = "Entry2CopyPasswordLink";
            this.Entry2CopyPasswordLink.Size = new System.Drawing.Size(89, 13);
            this.Entry2CopyPasswordLink.TabIndex = 5;
            this.Entry2CopyPasswordLink.TabStop = true;
            this.Entry2CopyPasswordLink.Text = "Copy to clipboard";
            this.Entry2CopyPasswordLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.Entry2CopyPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Entry2CopyPasswordLink_LinkClicked);
            // 
            // Entry2PasswordLabel
            // 
            this.Entry2PasswordLabel.AutoSize = true;
            this.Entry2PasswordLabel.Location = new System.Drawing.Point(5, 69);
            this.Entry2PasswordLabel.Name = "Entry2PasswordLabel";
            this.Entry2PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.Entry2PasswordLabel.TabIndex = 4;
            this.Entry2PasswordLabel.Text = "Password";
            // 
            // Entry2NameLabel
            // 
            this.Entry2NameLabel.AutoSize = true;
            this.Entry2NameLabel.Location = new System.Drawing.Point(5, 23);
            this.Entry2NameLabel.Name = "Entry2NameLabel";
            this.Entry2NameLabel.Size = new System.Drawing.Size(35, 13);
            this.Entry2NameLabel.TabIndex = 1;
            this.Entry2NameLabel.Text = "Name";
            // 
            // GenerateGroupBox
            // 
            this.GenerateGroupBox.BorderColor = System.Drawing.Color.DimGray;
            this.GenerateGroupBox.Controls.Add(this.GeneratedTextBoxPanel);
            this.GenerateGroupBox.Controls.Add(this.PasswordLengthUpDown);
            this.GenerateGroupBox.Controls.Add(this.WidthLabel);
            this.GenerateGroupBox.Controls.Add(this.GeneratePasswordButton);
            this.GenerateGroupBox.Controls.Add(this.CopyGeneratedPasswordLink);
            this.GenerateGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.GenerateGroupBox.Location = new System.Drawing.Point(256, 293);
            this.GenerateGroupBox.Name = "GenerateGroupBox";
            this.GenerateGroupBox.Size = new System.Drawing.Size(238, 97);
            this.GenerateGroupBox.TabIndex = 9;
            this.GenerateGroupBox.TabStop = false;
            this.GenerateGroupBox.Text = "Password Generator";
            // 
            // GeneratedTextBoxPanel
            // 
            this.GeneratedTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GeneratedTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.GeneratedTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GeneratedTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GeneratedTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.GeneratedTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.GeneratedTextBoxPanel.Location = new System.Drawing.Point(6, 21);
            this.GeneratedTextBoxPanel.Name = "GeneratedTextBoxPanel";
            this.GeneratedTextBoxPanel.ReadOnly = false;
            this.GeneratedTextBoxPanel.Size = new System.Drawing.Size(226, 21);
            this.GeneratedTextBoxPanel.TabIndex = 19;
            this.GeneratedTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.GeneratedTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // PasswordLengthUpDown
            // 
            this.PasswordLengthUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasswordLengthUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PasswordLengthUpDown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordLengthUpDown.Location = new System.Drawing.Point(187, 67);
            this.PasswordLengthUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PasswordLengthUpDown.Name = "PasswordLengthUpDown";
            this.PasswordLengthUpDown.Size = new System.Drawing.Size(45, 23);
            this.PasswordLengthUpDown.TabIndex = 11;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(146, 48);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(91, 13);
            this.WidthLabel.TabIndex = 10;
            this.WidthLabel.Text = "Widh (characters)";
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GeneratePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneratePasswordButton.Image = global::GUI.Properties.Resources._16pxGeneratePassword;
            this.GeneratePasswordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GeneratePasswordButton.Location = new System.Drawing.Point(6, 67);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(172, 23);
            this.GeneratePasswordButton.TabIndex = 9;
            this.GeneratePasswordButton.Text = "Generate Random Password";
            this.GeneratePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneratePasswordButton.UseVisualStyleBackColor = false;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // CopyGeneratedPasswordLink
            // 
            this.CopyGeneratedPasswordLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.CopyGeneratedPasswordLink.AutoSize = true;
            this.CopyGeneratedPasswordLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyGeneratedPasswordLink.Location = new System.Drawing.Point(5, 45);
            this.CopyGeneratedPasswordLink.Name = "CopyGeneratedPasswordLink";
            this.CopyGeneratedPasswordLink.Size = new System.Drawing.Size(89, 13);
            this.CopyGeneratedPasswordLink.TabIndex = 8;
            this.CopyGeneratedPasswordLink.TabStop = true;
            this.CopyGeneratedPasswordLink.Text = "Copy to clipboard";
            this.CopyGeneratedPasswordLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyGeneratedPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyGeneratedPasswordLink_LinkClicked);
            // 
            // EditableCheckBox
            // 
            this.EditableCheckBox.AutoSize = true;
            this.EditableCheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditableCheckBox.Location = new System.Drawing.Point(403, 415);
            this.EditableCheckBox.Name = "EditableCheckBox";
            this.EditableCheckBox.Size = new System.Drawing.Size(94, 17);
            this.EditableCheckBox.TabIndex = 10;
            this.EditableCheckBox.Text = "Enable Editing";
            this.EditableCheckBox.UseVisualStyleBackColor = true;
            this.EditableCheckBox.CheckedChanged += new System.EventHandler(this.EditableCheckBox_CheckedChanged);
            // 
            // NameGroupBox
            // 
            this.NameGroupBox.BorderColor = System.Drawing.Color.DimGray;
            this.NameGroupBox.Controls.Add(this.NameTextBoxPanel);
            this.NameGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameGroupBox.Location = new System.Drawing.Point(11, 16);
            this.NameGroupBox.Name = "NameGroupBox";
            this.NameGroupBox.Size = new System.Drawing.Size(238, 47);
            this.NameGroupBox.TabIndex = 0;
            this.NameGroupBox.TabStop = false;
            this.NameGroupBox.Text = "File name";
            // 
            // NameTextBoxPanel
            // 
            this.NameTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NameTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NameTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.NameTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.NameTextBoxPanel.Location = new System.Drawing.Point(6, 16);
            this.NameTextBoxPanel.Name = "NameTextBoxPanel";
            this.NameTextBoxPanel.ReadOnly = false;
            this.NameTextBoxPanel.Size = new System.Drawing.Size(226, 21);
            this.NameTextBoxPanel.TabIndex = 11;
            this.NameTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.NameTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0);
            // 
            // FileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(507, 446);
            this.Controls.Add(this.EditableCheckBox);
            this.Controls.Add(this.GenerateGroupBox);
            this.Controls.Add(this.Entry2GroupBox);
            this.Controls.Add(this.Entry1GroupBox);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NotesGroupBox);
            this.Controls.Add(this.EmailGroupBox);
            this.Controls.Add(this.PasswordGroupBox);
            this.Controls.Add(this.WebsiteGroupBox);
            this.Controls.Add(this.NameGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileDialog_FormClosing);
            this.Shown += new System.EventHandler(this.FileDialog_Shown);
            this.WebsiteGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.ResumeLayout(false);
            this.PasswordGroupBox.PerformLayout();
            this.CharacterLengthPanel.ResumeLayout(false);
            this.CharacterLengthPanel.PerformLayout();
            this.EmailGroupBox.ResumeLayout(false);
            this.EmailGroupBox.PerformLayout();
            this.NotesGroupBox.ResumeLayout(false);
            this.NotesGroupBox.PerformLayout();
            this.Entry1GroupBox.ResumeLayout(false);
            this.Entry1GroupBox.PerformLayout();
            this.Entry2GroupBox.ResumeLayout(false);
            this.Entry2GroupBox.PerformLayout();
            this.GenerateGroupBox.ResumeLayout(false);
            this.GenerateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthUpDown)).EndInit();
            this.NameGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGroupBox NameGroupBox;
        private CustomGroupBox WebsiteGroupBox;
        private CustomGroupBox PasswordGroupBox;
        private System.Windows.Forms.LinkLabel CopyPasswordLink;
        private CustomGroupBox EmailGroupBox;
        private System.Windows.Forms.LinkLabel CopyEmailLink;
        private CustomGroupBox NotesGroupBox;
        private System.Windows.Forms.LinkLabel CopyNotesLink;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelDialogButton;
        private CustomGroupBox Entry1GroupBox;
        private System.Windows.Forms.Label Entry1NameLabel;
        private System.Windows.Forms.Label Entry1PasswordLabel;
        private System.Windows.Forms.LinkLabel Entry1CopyPasswordLink;
        private CustomGroupBox Entry2GroupBox;
        private System.Windows.Forms.LinkLabel Entry2CopyPasswordLink;
        private System.Windows.Forms.Label Entry2PasswordLabel;
        private System.Windows.Forms.Label Entry2NameLabel;
        private CustomGroupBox GenerateGroupBox;
        private System.Windows.Forms.LinkLabel CopyGeneratedPasswordLink;
        private System.Windows.Forms.Button GeneratePasswordButton;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.CheckBox EditableCheckBox;
        private System.Windows.Forms.Button ZoomNotesButton;
        private System.Windows.Forms.NumericUpDown PasswordLengthUpDown;
        private Panel.RichTextBoxPanel NotesRichTextBoxPanel;
        private CustomLink Entry1NameLink;
        private CustomLink Entry2NameLink;
        private System.Windows.Forms.ToolTip ToolTip;
        private TextBoxPanel NameTextBoxPanel;
        private TextBoxPanel WebsiteTextBoxPanel;
        private TextBoxPanel PasswordTextBoxPanel;
        private TextBoxPanel EmailTextBoxPanel;
        private TextBoxPanel Entry1PasswordTextBoxPanel;
        private TextBoxPanel Entry1NameTextBoxPanel;
        private TextBoxPanel Entry2PasswordTextBoxPanel;
        private TextBoxPanel Entry2NameTextBoxPanel;
        private TextBoxPanel GeneratedTextBoxPanel;
        private System.Windows.Forms.Panel CharacterLengthPanel;
        private System.Windows.Forms.Label CharactersLengthLabel;
    }
}