namespace GUI {
    partial class InformationDialog {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationDialog));
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.PictureBoxPanel = new System.Windows.Forms.Panel();
            this.HeaderTableFlowPanel = new System.Windows.Forms.TableLayoutPanel();
            this.VersionReleasedTextBoxPanel = new GUI.TextBoxPanel();
            this.VersionTextBoxPanel = new GUI.TextBoxPanel();
            this.NameTextBoxPanel = new GUI.TextBoxPanel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionReleasedLabel = new System.Windows.Forms.Label();
            this.BuildSeperatorLabel = new System.Windows.Forms.Label();
            this.KeySeperatorLabel = new System.Windows.Forms.Label();
            this.KeyTitleLabel = new System.Windows.Forms.Label();
            this.BuildTitleLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.KeyPictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentKeyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentKeyTextBoxPanel = new GUI.TextBoxPanel();
            this.KeyLastChangeDate = new System.Windows.Forms.Label();
            this.FileManagerPictureBox = new System.Windows.Forms.PictureBox();
            this.FileManagerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FileManagerTextBoxPanel = new GUI.TextBoxPanel();
            this.ManagerCreatedLabel = new System.Windows.Forms.Label();
            this.LocatedTextBoxPanel = new GUI.TextBoxPanel();
            this.LocatedLabel = new System.Windows.Forms.Label();
            this.FileManagerTitleLabel = new System.Windows.Forms.Label();
            this.FileManagerSeperatorLabel = new System.Windows.Forms.Label();
            this.ButtonSeperatorLabel = new System.Windows.Forms.Label();
            this.KeyHistoryGrid = new System.Windows.Forms.DataGridView();
            this.DateCol = new GUI.TextAndImageColumn();
            this.KeyHistoryGridPanel = new System.Windows.Forms.Panel();
            this.KeyHistoryLabel = new System.Windows.Forms.Label();
            this.textAndImageColumn1 = new GUI.TextAndImageColumn();
            this.CopyLink = new System.Windows.Forms.LinkLabel();
            this.FileExplorerLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.PictureBoxPanel.SuspendLayout();
            this.HeaderTableFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).BeginInit();
            this.CurrentKeyTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileManagerPictureBox)).BeginInit();
            this.FileManagerTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyHistoryGrid)).BeginInit();
            this.KeyHistoryGridPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = global::GUI.Properties.Resources._256pxSafe;
            this.IconPictureBox.Location = new System.Drawing.Point(5, 5);
            this.IconPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(70, 70);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            // 
            // PictureBoxPanel
            // 
            this.PictureBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PictureBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxPanel.Controls.Add(this.IconPictureBox);
            this.PictureBoxPanel.Location = new System.Drawing.Point(14, 42);
            this.PictureBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxPanel.Name = "PictureBoxPanel";
            this.PictureBoxPanel.Size = new System.Drawing.Size(80, 80);
            this.PictureBoxPanel.TabIndex = 1;
            // 
            // HeaderTableFlowPanel
            // 
            this.HeaderTableFlowPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HeaderTableFlowPanel.ColumnCount = 2;
            this.HeaderTableFlowPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.HeaderTableFlowPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeaderTableFlowPanel.Controls.Add(this.VersionReleasedTextBoxPanel, 1, 2);
            this.HeaderTableFlowPanel.Controls.Add(this.VersionTextBoxPanel, 1, 1);
            this.HeaderTableFlowPanel.Controls.Add(this.NameTextBoxPanel, 1, 0);
            this.HeaderTableFlowPanel.Controls.Add(this.NameLabel, 0, 0);
            this.HeaderTableFlowPanel.Controls.Add(this.VersionLabel, 0, 1);
            this.HeaderTableFlowPanel.Controls.Add(this.VersionReleasedLabel, 0, 2);
            this.HeaderTableFlowPanel.Location = new System.Drawing.Point(104, 42);
            this.HeaderTableFlowPanel.Name = "HeaderTableFlowPanel";
            this.HeaderTableFlowPanel.RowCount = 3;
            this.HeaderTableFlowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.HeaderTableFlowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.HeaderTableFlowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.HeaderTableFlowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.HeaderTableFlowPanel.Size = new System.Drawing.Size(444, 80);
            this.HeaderTableFlowPanel.TabIndex = 2;
            // 
            // VersionReleasedTextBoxPanel
            // 
            this.VersionReleasedTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.VersionReleasedTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.VersionReleasedTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.VersionReleasedTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.VersionReleasedTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.VersionReleasedTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionReleasedTextBoxPanel.Location = new System.Drawing.Point(112, 53);
            this.VersionReleasedTextBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.VersionReleasedTextBoxPanel.Name = "VersionReleasedTextBoxPanel";
            this.VersionReleasedTextBoxPanel.ReadOnly = true;
            this.VersionReleasedTextBoxPanel.Size = new System.Drawing.Size(331, 26);
            this.VersionReleasedTextBoxPanel.TabIndex = 25;
            this.VersionReleasedTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.VersionReleasedTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            // 
            // VersionTextBoxPanel
            // 
            this.VersionTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.VersionTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.VersionTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.VersionTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.VersionTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.VersionTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VersionTextBoxPanel.Location = new System.Drawing.Point(112, 27);
            this.VersionTextBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.VersionTextBoxPanel.Name = "VersionTextBoxPanel";
            this.VersionTextBoxPanel.ReadOnly = true;
            this.VersionTextBoxPanel.Size = new System.Drawing.Size(331, 25);
            this.VersionTextBoxPanel.TabIndex = 24;
            this.VersionTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.VersionTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            // 
            // NameTextBoxPanel
            // 
            this.NameTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NameTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NameTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NameTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.NameTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBoxPanel.Location = new System.Drawing.Point(112, 1);
            this.NameTextBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.NameTextBoxPanel.Name = "NameTextBoxPanel";
            this.NameTextBoxPanel.ReadOnly = true;
            this.NameTextBoxPanel.Size = new System.Drawing.Size(331, 25);
            this.NameTextBoxPanel.TabIndex = 23;
            this.NameTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.NameTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(4, 6);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.VersionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VersionLabel.Location = new System.Drawing.Point(4, 32);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(51, 15);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "Version:";
            // 
            // VersionReleasedLabel
            // 
            this.VersionReleasedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VersionReleasedLabel.AutoSize = true;
            this.VersionReleasedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.VersionReleasedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.VersionReleasedLabel.Location = new System.Drawing.Point(4, 58);
            this.VersionReleasedLabel.Name = "VersionReleasedLabel";
            this.VersionReleasedLabel.Size = new System.Drawing.Size(102, 15);
            this.VersionReleasedLabel.TabIndex = 2;
            this.VersionReleasedLabel.Text = "Version released:";
            // 
            // BuildSeperatorLabel
            // 
            this.BuildSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuildSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BuildSeperatorLabel.Location = new System.Drawing.Point(14, 33);
            this.BuildSeperatorLabel.Name = "BuildSeperatorLabel";
            this.BuildSeperatorLabel.Size = new System.Drawing.Size(534, 1);
            this.BuildSeperatorLabel.TabIndex = 4;
            // 
            // KeySeperatorLabel
            // 
            this.KeySeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeySeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeySeperatorLabel.Location = new System.Drawing.Point(14, 158);
            this.KeySeperatorLabel.Name = "KeySeperatorLabel";
            this.KeySeperatorLabel.Size = new System.Drawing.Size(534, 1);
            this.KeySeperatorLabel.TabIndex = 8;
            // 
            // KeyTitleLabel
            // 
            this.KeyTitleLabel.AutoSize = true;
            this.KeyTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.KeyTitleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeyTitleLabel.Location = new System.Drawing.Point(11, 141);
            this.KeyTitleLabel.Name = "KeyTitleLabel";
            this.KeyTitleLabel.Size = new System.Drawing.Size(28, 15);
            this.KeyTitleLabel.TabIndex = 7;
            this.KeyTitleLabel.Text = "Key";
            // 
            // BuildTitleLabel
            // 
            this.BuildTitleLabel.AutoSize = true;
            this.BuildTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BuildTitleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BuildTitleLabel.Location = new System.Drawing.Point(11, 16);
            this.BuildTitleLabel.Name = "BuildTitleLabel";
            this.BuildTitleLabel.Size = new System.Drawing.Size(35, 15);
            this.BuildTitleLabel.TabIndex = 7;
            this.BuildTitleLabel.Text = "Build";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(14, 459);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // KeyPictureBox
            // 
            this.KeyPictureBox.Image = global::GUI.Properties.Resources._64pxKey;
            this.KeyPictureBox.Location = new System.Drawing.Point(14, 164);
            this.KeyPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.KeyPictureBox.Name = "KeyPictureBox";
            this.KeyPictureBox.Size = new System.Drawing.Size(27, 27);
            this.KeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KeyPictureBox.TabIndex = 10;
            this.KeyPictureBox.TabStop = false;
            // 
            // CurrentKeyTableLayoutPanel
            // 
            this.CurrentKeyTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CurrentKeyTableLayoutPanel.ColumnCount = 2;
            this.CurrentKeyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.CurrentKeyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrentKeyTableLayoutPanel.Controls.Add(this.CurrentKeyTextBoxPanel, 0, 0);
            this.CurrentKeyTableLayoutPanel.Controls.Add(this.KeyLastChangeDate, 0, 0);
            this.CurrentKeyTableLayoutPanel.Location = new System.Drawing.Point(104, 164);
            this.CurrentKeyTableLayoutPanel.Name = "CurrentKeyTableLayoutPanel";
            this.CurrentKeyTableLayoutPanel.RowCount = 1;
            this.CurrentKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CurrentKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CurrentKeyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.CurrentKeyTableLayoutPanel.Size = new System.Drawing.Size(444, 27);
            this.CurrentKeyTableLayoutPanel.TabIndex = 12;
            // 
            // CurrentKeyTextBoxPanel
            // 
            this.CurrentKeyTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CurrentKeyTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.CurrentKeyTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CurrentKeyTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CurrentKeyTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.CurrentKeyTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentKeyTextBoxPanel.Location = new System.Drawing.Point(112, 1);
            this.CurrentKeyTextBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CurrentKeyTextBoxPanel.Name = "CurrentKeyTextBoxPanel";
            this.CurrentKeyTextBoxPanel.ReadOnly = true;
            this.CurrentKeyTextBoxPanel.Size = new System.Drawing.Size(331, 25);
            this.CurrentKeyTextBoxPanel.TabIndex = 25;
            this.CurrentKeyTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.CurrentKeyTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            // 
            // KeyLastChangeDate
            // 
            this.KeyLastChangeDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.KeyLastChangeDate.AutoSize = true;
            this.KeyLastChangeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.KeyLastChangeDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeyLastChangeDate.Location = new System.Drawing.Point(4, 6);
            this.KeyLastChangeDate.Name = "KeyLastChangeDate";
            this.KeyLastChangeDate.Size = new System.Drawing.Size(103, 15);
            this.KeyLastChangeDate.TabIndex = 0;
            this.KeyLastChangeDate.Text = "Current key since:";
            // 
            // FileManagerPictureBox
            // 
            this.FileManagerPictureBox.Image = global::GUI.Properties.Resources._64pxFolder;
            this.FileManagerPictureBox.Location = new System.Drawing.Point(14, 354);
            this.FileManagerPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.FileManagerPictureBox.Name = "FileManagerPictureBox";
            this.FileManagerPictureBox.Size = new System.Drawing.Size(27, 27);
            this.FileManagerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FileManagerPictureBox.TabIndex = 15;
            this.FileManagerPictureBox.TabStop = false;
            // 
            // FileManagerTableLayoutPanel
            // 
            this.FileManagerTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.FileManagerTableLayoutPanel.ColumnCount = 2;
            this.FileManagerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.FileManagerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FileManagerTableLayoutPanel.Controls.Add(this.FileManagerTextBoxPanel, 1, 0);
            this.FileManagerTableLayoutPanel.Controls.Add(this.ManagerCreatedLabel, 0, 0);
            this.FileManagerTableLayoutPanel.Controls.Add(this.LocatedTextBoxPanel, 1, 1);
            this.FileManagerTableLayoutPanel.Controls.Add(this.LocatedLabel, 0, 1);
            this.FileManagerTableLayoutPanel.Location = new System.Drawing.Point(104, 354);
            this.FileManagerTableLayoutPanel.Name = "FileManagerTableLayoutPanel";
            this.FileManagerTableLayoutPanel.RowCount = 2;
            this.FileManagerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileManagerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FileManagerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FileManagerTableLayoutPanel.Size = new System.Drawing.Size(444, 54);
            this.FileManagerTableLayoutPanel.TabIndex = 16;
            // 
            // FileManagerTextBoxPanel
            // 
            this.FileManagerTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileManagerTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileManagerTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileManagerTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileManagerTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.FileManagerTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileManagerTextBoxPanel.Location = new System.Drawing.Point(112, 1);
            this.FileManagerTextBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FileManagerTextBoxPanel.Name = "FileManagerTextBoxPanel";
            this.FileManagerTextBoxPanel.ReadOnly = true;
            this.FileManagerTextBoxPanel.Size = new System.Drawing.Size(331, 25);
            this.FileManagerTextBoxPanel.TabIndex = 25;
            this.FileManagerTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FileManagerTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            // 
            // ManagerCreatedLabel
            // 
            this.ManagerCreatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ManagerCreatedLabel.AutoSize = true;
            this.ManagerCreatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ManagerCreatedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ManagerCreatedLabel.Location = new System.Drawing.Point(4, 6);
            this.ManagerCreatedLabel.Name = "ManagerCreatedLabel";
            this.ManagerCreatedLabel.Size = new System.Drawing.Size(104, 15);
            this.ManagerCreatedLabel.TabIndex = 0;
            this.ManagerCreatedLabel.Text = "Manager created:";
            // 
            // LocatedTextBoxPanel
            // 
            this.LocatedTextBoxPanel.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LocatedTextBoxPanel.ActiveForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocatedTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LocatedTextBoxPanel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.LocatedTextBoxPanel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.LocatedTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocatedTextBoxPanel.Location = new System.Drawing.Point(112, 27);
            this.LocatedTextBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LocatedTextBoxPanel.Name = "LocatedTextBoxPanel";
            this.LocatedTextBoxPanel.ReadOnly = true;
            this.LocatedTextBoxPanel.Size = new System.Drawing.Size(331, 26);
            this.LocatedTextBoxPanel.TabIndex = 25;
            this.LocatedTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LocatedTextBoxPanel.TextPadding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            // 
            // LocatedLabel
            // 
            this.LocatedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LocatedLabel.AutoSize = true;
            this.LocatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LocatedLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LocatedLabel.Location = new System.Drawing.Point(4, 32);
            this.LocatedLabel.Name = "LocatedLabel";
            this.LocatedLabel.Size = new System.Drawing.Size(67, 15);
            this.LocatedLabel.TabIndex = 4;
            this.LocatedLabel.Text = "Located in:";
            // 
            // FileManagerTitleLabel
            // 
            this.FileManagerTitleLabel.AutoSize = true;
            this.FileManagerTitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.FileManagerTitleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileManagerTitleLabel.Location = new System.Drawing.Point(11, 331);
            this.FileManagerTitleLabel.Name = "FileManagerTitleLabel";
            this.FileManagerTitleLabel.Size = new System.Drawing.Size(78, 15);
            this.FileManagerTitleLabel.TabIndex = 13;
            this.FileManagerTitleLabel.Text = "File Manager";
            // 
            // FileManagerSeperatorLabel
            // 
            this.FileManagerSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileManagerSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileManagerSeperatorLabel.Location = new System.Drawing.Point(14, 348);
            this.FileManagerSeperatorLabel.Name = "FileManagerSeperatorLabel";
            this.FileManagerSeperatorLabel.Size = new System.Drawing.Size(534, 1);
            this.FileManagerSeperatorLabel.TabIndex = 14;
            // 
            // ButtonSeperatorLabel
            // 
            this.ButtonSeperatorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ButtonSeperatorLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonSeperatorLabel.Location = new System.Drawing.Point(14, 445);
            this.ButtonSeperatorLabel.Name = "ButtonSeperatorLabel";
            this.ButtonSeperatorLabel.Size = new System.Drawing.Size(534, 1);
            this.ButtonSeperatorLabel.TabIndex = 17;
            // 
            // KeyHistoryGrid
            // 
            this.KeyHistoryGrid.AllowUserToAddRows = false;
            this.KeyHistoryGrid.AllowUserToDeleteRows = false;
            this.KeyHistoryGrid.AllowUserToOrderColumns = true;
            this.KeyHistoryGrid.AllowUserToResizeColumns = false;
            this.KeyHistoryGrid.AllowUserToResizeRows = false;
            this.KeyHistoryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.KeyHistoryGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyHistoryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.KeyHistoryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KeyHistoryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.KeyHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KeyHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KeyHistoryGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.KeyHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyHistoryGrid.EnableHeadersVisualStyles = false;
            this.KeyHistoryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.KeyHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.KeyHistoryGrid.Margin = new System.Windows.Forms.Padding(0);
            this.KeyHistoryGrid.MultiSelect = false;
            this.KeyHistoryGrid.Name = "KeyHistoryGrid";
            this.KeyHistoryGrid.ReadOnly = true;
            this.KeyHistoryGrid.RowHeadersVisible = false;
            this.KeyHistoryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KeyHistoryGrid.Size = new System.Drawing.Size(442, 77);
            this.KeyHistoryGrid.TabIndex = 18;
            this.KeyHistoryGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KeyHistoryGrid_MouseDown);
            // 
            // DateCol
            // 
            this.DateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCol.HeaderText = "Date";
            this.DateCol.Image = null;
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            // 
            // KeyHistoryGridPanel
            // 
            this.KeyHistoryGridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyHistoryGridPanel.Controls.Add(this.KeyHistoryGrid);
            this.KeyHistoryGridPanel.Location = new System.Drawing.Point(104, 219);
            this.KeyHistoryGridPanel.Margin = new System.Windows.Forms.Padding(0);
            this.KeyHistoryGridPanel.Name = "KeyHistoryGridPanel";
            this.KeyHistoryGridPanel.Size = new System.Drawing.Size(444, 79);
            this.KeyHistoryGridPanel.TabIndex = 19;
            // 
            // KeyHistoryLabel
            // 
            this.KeyHistoryLabel.AutoSize = true;
            this.KeyHistoryLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.KeyHistoryLabel.Location = new System.Drawing.Point(101, 202);
            this.KeyHistoryLabel.Name = "KeyHistoryLabel";
            this.KeyHistoryLabel.Size = new System.Drawing.Size(58, 13);
            this.KeyHistoryLabel.TabIndex = 20;
            this.KeyHistoryLabel.Text = "Key history";
            // 
            // textAndImageColumn1
            // 
            this.textAndImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textAndImageColumn1.HeaderText = "Date";
            this.textAndImageColumn1.Image = null;
            this.textAndImageColumn1.Name = "textAndImageColumn1";
            // 
            // CopyLink
            // 
            this.CopyLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.CopyLink.AutoSize = true;
            this.CopyLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CopyLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyLink.Location = new System.Drawing.Point(101, 299);
            this.CopyLink.Name = "CopyLink";
            this.CopyLink.Size = new System.Drawing.Size(31, 13);
            this.CopyLink.TabIndex = 21;
            this.CopyLink.TabStop = true;
            this.CopyLink.Text = "Copy";
            this.CopyLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.CopyLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyLink_LinkClicked);
            // 
            // FileExplorerLink
            // 
            this.FileExplorerLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.FileExplorerLink.AutoSize = true;
            this.FileExplorerLink.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileExplorerLink.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.FileExplorerLink.Location = new System.Drawing.Point(101, 410);
            this.FileExplorerLink.Name = "FileExplorerLink";
            this.FileExplorerLink.Size = new System.Drawing.Size(100, 13);
            this.FileExplorerLink.TabIndex = 22;
            this.FileExplorerLink.TabStop = true;
            this.FileExplorerLink.Text = "Open in file explorer";
            this.FileExplorerLink.VisitedLinkColor = System.Drawing.SystemColors.HighlightText;
            this.FileExplorerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FileExplorerLink_LinkClicked);
            // 
            // InformationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(560, 497);
            this.Controls.Add(this.FileExplorerLink);
            this.Controls.Add(this.CopyLink);
            this.Controls.Add(this.KeyHistoryLabel);
            this.Controls.Add(this.KeyHistoryGridPanel);
            this.Controls.Add(this.ButtonSeperatorLabel);
            this.Controls.Add(this.FileManagerPictureBox);
            this.Controls.Add(this.FileManagerTableLayoutPanel);
            this.Controls.Add(this.FileManagerTitleLabel);
            this.Controls.Add(this.FileManagerSeperatorLabel);
            this.Controls.Add(this.KeyPictureBox);
            this.Controls.Add(this.CurrentKeyTableLayoutPanel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.KeyTitleLabel);
            this.Controls.Add(this.BuildTitleLabel);
            this.Controls.Add(this.KeySeperatorLabel);
            this.Controls.Add(this.BuildSeperatorLabel);
            this.Controls.Add(this.HeaderTableFlowPanel);
            this.Controls.Add(this.PictureBoxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InformationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.Shown += new System.EventHandler(this.InformationDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.PictureBoxPanel.ResumeLayout(false);
            this.HeaderTableFlowPanel.ResumeLayout(false);
            this.HeaderTableFlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyPictureBox)).EndInit();
            this.CurrentKeyTableLayoutPanel.ResumeLayout(false);
            this.CurrentKeyTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileManagerPictureBox)).EndInit();
            this.FileManagerTableLayoutPanel.ResumeLayout(false);
            this.FileManagerTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyHistoryGrid)).EndInit();
            this.KeyHistoryGridPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Panel PictureBoxPanel;
        private System.Windows.Forms.TableLayoutPanel HeaderTableFlowPanel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label VersionReleasedLabel;
        private System.Windows.Forms.Label BuildSeperatorLabel;
        private System.Windows.Forms.Label KeySeperatorLabel;
        private System.Windows.Forms.Label KeyTitleLabel;
        private System.Windows.Forms.Label BuildTitleLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox KeyPictureBox;
        private System.Windows.Forms.TableLayoutPanel CurrentKeyTableLayoutPanel;
        private System.Windows.Forms.Label KeyLastChangeDate;
        private System.Windows.Forms.PictureBox FileManagerPictureBox;
        private System.Windows.Forms.TableLayoutPanel FileManagerTableLayoutPanel;
        private System.Windows.Forms.Label ManagerCreatedLabel;
        private System.Windows.Forms.Label FileManagerTitleLabel;
        private System.Windows.Forms.Label FileManagerSeperatorLabel;
        private System.Windows.Forms.Label ButtonSeperatorLabel;
        private System.Windows.Forms.DataGridView KeyHistoryGrid;
        private TextAndImageColumn DateCol;
        private System.Windows.Forms.Panel KeyHistoryGridPanel;
        private System.Windows.Forms.Label KeyHistoryLabel;
        private TextAndImageColumn textAndImageColumn1;
        private System.Windows.Forms.LinkLabel CopyLink;
        private System.Windows.Forms.Label LocatedLabel;
        private System.Windows.Forms.LinkLabel FileExplorerLink;
        private TextBoxPanel NameTextBoxPanel;
        private TextBoxPanel VersionReleasedTextBoxPanel;
        private TextBoxPanel VersionTextBoxPanel;
        private TextBoxPanel CurrentKeyTextBoxPanel;
        private TextBoxPanel FileManagerTextBoxPanel;
        private TextBoxPanel LocatedTextBoxPanel;
    }
}