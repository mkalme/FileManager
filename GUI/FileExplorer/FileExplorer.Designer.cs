namespace GUI {
    partial class FileExplorer {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorer));
            this.ExplorerContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ExplorerGrid = new System.Windows.Forms.DataGridView();
            this.IndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new GUI.TextAndImageColumn();
            this.WebsiteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastEditedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExplorerGridMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.NewWindowSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.PasteSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.PathPanel = new GUI.PathPanel();
            this.BelowPanel = new System.Windows.Forms.Panel();
            this.ClearClipboardButton = new System.Windows.Forms.Button();
            this.PanelSeperatorLabel = new System.Windows.Forms.Label();
            this.SeperateCloseLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAndImageColumn1 = new GUI.TextAndImageColumn();
            this.textAndImageColumn2 = new GUI.TextAndImageColumn();
            this.textAndImageColumn3 = new GUI.TextAndImageColumn();
            this.textAndImageColumn4 = new GUI.TextAndImageColumn();
            this.textAndImageColumn5 = new GUI.TextAndImageColumn();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NewStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DirectoryStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileStripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocumentStrimitem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindowStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveStripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameStripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteStripitem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DeselectButton = new System.Windows.Forms.Button();
            this.ChangeKeyButton = new System.Windows.Forms.Button();
            this.InformationButton = new System.Windows.Forms.Button();
            this.UpArrowButton = new System.Windows.Forms.Button();
            this.ExplorerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerGrid)).BeginInit();
            this.ExplorerGridMenuStrip.SuspendLayout();
            this.ToolBarTableLayoutPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.BelowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExplorerContainer
            // 
            this.ExplorerContainer.ColumnCount = 1;
            this.ExplorerContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ExplorerContainer.Controls.Add(this.ExplorerGrid, 0, 1);
            this.ExplorerContainer.Controls.Add(this.ToolBarTableLayoutPanel, 0, 0);
            this.ExplorerContainer.Controls.Add(this.BelowPanel, 0, 2);
            this.ExplorerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerContainer.Location = new System.Drawing.Point(0, 0);
            this.ExplorerContainer.Name = "ExplorerContainer";
            this.ExplorerContainer.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ExplorerContainer.RowCount = 3;
            this.ExplorerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.ExplorerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ExplorerContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.ExplorerContainer.Size = new System.Drawing.Size(803, 460);
            this.ExplorerContainer.TabIndex = 0;
            // 
            // ExplorerGrid
            // 
            this.ExplorerGrid.AllowUserToAddRows = false;
            this.ExplorerGrid.AllowUserToDeleteRows = false;
            this.ExplorerGrid.AllowUserToOrderColumns = true;
            this.ExplorerGrid.AllowUserToResizeRows = false;
            this.ExplorerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExplorerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExplorerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ExplorerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExplorerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ExplorerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExplorerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexCol,
            this.NameCol,
            this.WebsiteCol,
            this.PasswordLength,
            this.EmailCol,
            this.LastEditedCol});
            this.ExplorerGrid.ContextMenuStrip = this.ExplorerGridMenuStrip;
            this.ExplorerGrid.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExplorerGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.ExplorerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerGrid.EnableHeadersVisualStyles = false;
            this.ExplorerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ExplorerGrid.Location = new System.Drawing.Point(9, 32);
            this.ExplorerGrid.Margin = new System.Windows.Forms.Padding(6, 1, 6, 0);
            this.ExplorerGrid.MultiSelect = false;
            this.ExplorerGrid.Name = "ExplorerGrid";
            this.ExplorerGrid.ReadOnly = true;
            this.ExplorerGrid.RowHeadersVisible = false;
            this.ExplorerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExplorerGrid.Size = new System.Drawing.Size(785, 401);
            this.ExplorerGrid.TabIndex = 0;
            this.ExplorerGrid.TabStop = false;
            this.ExplorerGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerGrid_CellDoubleClick);
            this.ExplorerGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ExplorerGrid_CellMouseDown);
            this.ExplorerGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerGrid_CellMouseEnter);
            this.ExplorerGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerGrid_CellMouseLeave);
            this.ExplorerGrid.SelectionChanged += new System.EventHandler(this.ExplorerGrid_SelectionChanged);
            this.ExplorerGrid.Sorted += new System.EventHandler(this.ExplorerGrid_Sorted);
            this.ExplorerGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExplorerGrid_KeyDown);
            this.ExplorerGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExplorerGrid_MouseDown);
            // 
            // IndexCol
            // 
            this.IndexCol.HeaderText = "";
            this.IndexCol.Name = "IndexCol";
            this.IndexCol.ReadOnly = true;
            this.IndexCol.Visible = false;
            // 
            // NameCol
            // 
            this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameCol.HeaderText = "Name";
            this.NameCol.Image = null;
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // WebsiteCol
            // 
            this.WebsiteCol.HeaderText = "Website";
            this.WebsiteCol.Name = "WebsiteCol";
            this.WebsiteCol.ReadOnly = true;
            this.WebsiteCol.Width = 180;
            // 
            // PasswordLength
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.PasswordLength.DefaultCellStyle = dataGridViewCellStyle7;
            this.PasswordLength.HeaderText = "Length";
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.ReadOnly = true;
            this.PasswordLength.Width = 60;
            // 
            // EmailCol
            // 
            this.EmailCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.EmailCol.DefaultCellStyle = dataGridViewCellStyle8;
            this.EmailCol.HeaderText = "Email";
            this.EmailCol.Name = "EmailCol";
            this.EmailCol.ReadOnly = true;
            this.EmailCol.Width = 180;
            // 
            // LastEditedCol
            // 
            this.LastEditedCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.LastEditedCol.DefaultCellStyle = dataGridViewCellStyle9;
            this.LastEditedCol.HeaderText = "Last edited";
            this.LastEditedCol.Name = "LastEditedCol";
            this.LastEditedCol.ReadOnly = true;
            this.LastEditedCol.Width = 105;
            // 
            // ExplorerGridMenuStrip
            // 
            this.ExplorerGridMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.ExplorerGridMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewStripItem,
            this.NewSeperator,
            this.ChangePasswordStripItem,
            this.NewWindowStripItem,
            this.NewWindowSeperator,
            this.CopyStripItem,
            this.PasteStripItem,
            this.PasteSeperator,
            this.MoveStripitem,
            this.RenameStripitem,
            this.DeleteStripitem,
            this.DeleteSeperator,
            this.PropertiesStripItem});
            this.ExplorerGridMenuStrip.Name = "ExplorerGridMenuStrip";
            this.ExplorerGridMenuStrip.Size = new System.Drawing.Size(187, 226);
            this.ExplorerGridMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.ExplorerGridMenuStrip_Opening);
            // 
            // NewSeperator
            // 
            this.NewSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewSeperator.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewSeperator.Name = "NewSeperator";
            this.NewSeperator.Size = new System.Drawing.Size(183, 6);
            // 
            // NewWindowSeperator
            // 
            this.NewWindowSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewWindowSeperator.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewWindowSeperator.Name = "NewWindowSeperator";
            this.NewWindowSeperator.Size = new System.Drawing.Size(183, 6);
            // 
            // PasteSeperator
            // 
            this.PasteSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasteSeperator.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasteSeperator.Name = "PasteSeperator";
            this.PasteSeperator.Size = new System.Drawing.Size(183, 6);
            // 
            // DeleteSeperator
            // 
            this.DeleteSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DeleteSeperator.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteSeperator.Name = "DeleteSeperator";
            this.DeleteSeperator.Size = new System.Drawing.Size(183, 6);
            // 
            // ToolBarTableLayoutPanel
            // 
            this.ToolBarTableLayoutPanel.AutoSize = true;
            this.ToolBarTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ToolBarTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolBarTableLayoutPanel.ColumnCount = 2;
            this.ToolBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.ToolBarTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolBarTableLayoutPanel.Controls.Add(this.ButtonPanel, 0, 0);
            this.ToolBarTableLayoutPanel.Controls.Add(this.PathPanel, 1, 0);
            this.ToolBarTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolBarTableLayoutPanel.Location = new System.Drawing.Point(6, 1);
            this.ToolBarTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.ToolBarTableLayoutPanel.Name = "ToolBarTableLayoutPanel";
            this.ToolBarTableLayoutPanel.RowCount = 1;
            this.ToolBarTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolBarTableLayoutPanel.Size = new System.Drawing.Size(791, 30);
            this.ToolBarTableLayoutPanel.TabIndex = 3;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonPanel.Controls.Add(this.UpArrowButton);
            this.ButtonPanel.Controls.Add(this.RefreshButton);
            this.ButtonPanel.Controls.Add(this.ForwardButton);
            this.ButtonPanel.Controls.Add(this.BackButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(110, 30);
            this.ButtonPanel.TabIndex = 2;
            // 
            // PathPanel
            // 
            this.PathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPanel.Location = new System.Drawing.Point(113, 3);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.Size = new System.Drawing.Size(675, 24);
            this.PathPanel.TabIndex = 3;
            // 
            // BelowPanel
            // 
            this.BelowPanel.Controls.Add(this.DeselectButton);
            this.BelowPanel.Controls.Add(this.ClearClipboardButton);
            this.BelowPanel.Controls.Add(this.ChangeKeyButton);
            this.BelowPanel.Controls.Add(this.InformationButton);
            this.BelowPanel.Controls.Add(this.PanelSeperatorLabel);
            this.BelowPanel.Controls.Add(this.SeperateCloseLabel);
            this.BelowPanel.Controls.Add(this.CloseButton);
            this.BelowPanel.Controls.Add(this.InformationLabel);
            this.BelowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BelowPanel.Location = new System.Drawing.Point(3, 433);
            this.BelowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BelowPanel.Name = "BelowPanel";
            this.BelowPanel.Size = new System.Drawing.Size(797, 27);
            this.BelowPanel.TabIndex = 4;
            // 
            // ClearClipboardButton
            // 
            this.ClearClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearClipboardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClearClipboardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClearClipboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClearClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearClipboardButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ClearClipboardButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ClearClipboardButton.Location = new System.Drawing.Point(600, 2);
            this.ClearClipboardButton.Margin = new System.Windows.Forms.Padding(0);
            this.ClearClipboardButton.Name = "ClearClipboardButton";
            this.ClearClipboardButton.Size = new System.Drawing.Size(99, 23);
            this.ClearClipboardButton.TabIndex = 2;
            this.ClearClipboardButton.Text = "Clear Clipboard";
            this.ClearClipboardButton.UseVisualStyleBackColor = true;
            this.ClearClipboardButton.Click += new System.EventHandler(this.ClearClipboardButton_Click);
            // 
            // PanelSeperatorLabel
            // 
            this.PanelSeperatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSeperatorLabel.AutoSize = true;
            this.PanelSeperatorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PanelSeperatorLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.PanelSeperatorLabel.Location = new System.Drawing.Point(554, 5);
            this.PanelSeperatorLabel.Name = "PanelSeperatorLabel";
            this.PanelSeperatorLabel.Size = new System.Drawing.Size(10, 15);
            this.PanelSeperatorLabel.TabIndex = 6;
            this.PanelSeperatorLabel.Text = "|";
            // 
            // SeperateCloseLabel
            // 
            this.SeperateCloseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeperateCloseLabel.AutoSize = true;
            this.SeperateCloseLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SeperateCloseLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.SeperateCloseLabel.Location = new System.Drawing.Point(708, 5);
            this.SeperateCloseLabel.Name = "SeperateCloseLabel";
            this.SeperateCloseLabel.Size = new System.Drawing.Size(10, 15);
            this.SeperateCloseLabel.TabIndex = 4;
            this.SeperateCloseLabel.Text = "|";
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(726, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(65, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.InformationLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InformationLabel.Location = new System.Drawing.Point(4, 6);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(126, 15);
            this.InformationLabel.TabIndex = 0;
            this.InformationLabel.Text = "Total amount of items:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // textAndImageColumn1
            // 
            this.textAndImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textAndImageColumn1.HeaderText = "Name";
            this.textAndImageColumn1.Image = null;
            this.textAndImageColumn1.Name = "textAndImageColumn1";
            // 
            // textAndImageColumn2
            // 
            this.textAndImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.textAndImageColumn2.HeaderText = "Website";
            this.textAndImageColumn2.Image = null;
            this.textAndImageColumn2.Name = "textAndImageColumn2";
            this.textAndImageColumn2.Width = 170;
            // 
            // textAndImageColumn3
            // 
            this.textAndImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.textAndImageColumn3.HeaderText = "Password length";
            this.textAndImageColumn3.Image = null;
            this.textAndImageColumn3.Name = "textAndImageColumn3";
            this.textAndImageColumn3.Width = 110;
            // 
            // textAndImageColumn4
            // 
            this.textAndImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.textAndImageColumn4.HeaderText = "Email";
            this.textAndImageColumn4.Image = null;
            this.textAndImageColumn4.Name = "textAndImageColumn4";
            this.textAndImageColumn4.Width = 170;
            // 
            // textAndImageColumn5
            // 
            this.textAndImageColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.textAndImageColumn5.HeaderText = "Last edited";
            this.textAndImageColumn5.Image = null;
            this.textAndImageColumn5.Name = "textAndImageColumn5";
            this.textAndImageColumn5.Width = 110;
            // 
            // NewStripItem
            // 
            this.NewStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewStripItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DirectoryStripItem,
            this.FileStripitem,
            this.DocumentStrimitem});
            this.NewStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewStripItem.Image = global::GUI.Properties.Resources._16pxAdd;
            this.NewStripItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewStripItem.Name = "NewStripItem";
            this.NewStripItem.Size = new System.Drawing.Size(186, 22);
            this.NewStripItem.Text = "New";
            // 
            // DirectoryStripItem
            // 
            this.DirectoryStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DirectoryStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DirectoryStripItem.Image = global::GUI.Properties.Resources._22pxFolder;
            this.DirectoryStripItem.Name = "DirectoryStripItem";
            this.DirectoryStripItem.Size = new System.Drawing.Size(185, 22);
            this.DirectoryStripItem.Text = "Directory                     ";
            this.DirectoryStripItem.Click += new System.EventHandler(this.DirectoryStripItem_Click);
            // 
            // FileStripitem
            // 
            this.FileStripitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FileStripitem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FileStripitem.Image = global::GUI.Properties.Resources._22pxPassword;
            this.FileStripitem.Name = "FileStripitem";
            this.FileStripitem.Size = new System.Drawing.Size(185, 22);
            this.FileStripitem.Text = "File";
            this.FileStripitem.Click += new System.EventHandler(this.FileStripitem_Click);
            // 
            // DocumentStrimitem
            // 
            this.DocumentStrimitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DocumentStrimitem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DocumentStrimitem.Image = global::GUI.Properties.Resources._22pxDocument;
            this.DocumentStrimitem.Name = "DocumentStrimitem";
            this.DocumentStrimitem.Size = new System.Drawing.Size(185, 22);
            this.DocumentStrimitem.Text = "Document";
            this.DocumentStrimitem.Click += new System.EventHandler(this.DocumentStrimitem_Click);
            // 
            // ChangePasswordStripItem
            // 
            this.ChangePasswordStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ChangePasswordStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangePasswordStripItem.Image = global::GUI.Properties.Resources._16pxGeneratePassword;
            this.ChangePasswordStripItem.Name = "ChangePasswordStripItem";
            this.ChangePasswordStripItem.Size = new System.Drawing.Size(186, 22);
            this.ChangePasswordStripItem.Text = "Change password";
            this.ChangePasswordStripItem.Click += new System.EventHandler(this.ChangePasswordStripItem_Click);
            // 
            // NewWindowStripItem
            // 
            this.NewWindowStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NewWindowStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewWindowStripItem.Image = global::GUI.Properties.Resources._16pxNewWindow;
            this.NewWindowStripItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewWindowStripItem.Name = "NewWindowStripItem";
            this.NewWindowStripItem.Size = new System.Drawing.Size(186, 22);
            this.NewWindowStripItem.Text = "Open in new window";
            this.NewWindowStripItem.Click += new System.EventHandler(this.NewWindowStripItem_Click);
            // 
            // CopyStripItem
            // 
            this.CopyStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CopyStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CopyStripItem.Image = global::GUI.Properties.Resources._16pxCopyItem;
            this.CopyStripItem.Name = "CopyStripItem";
            this.CopyStripItem.Size = new System.Drawing.Size(186, 22);
            this.CopyStripItem.Text = "Copy";
            this.CopyStripItem.Click += new System.EventHandler(this.CopyStripItem_Click);
            // 
            // PasteStripItem
            // 
            this.PasteStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PasteStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PasteStripItem.Image = ((System.Drawing.Image)(resources.GetObject("PasteStripItem.Image")));
            this.PasteStripItem.Name = "PasteStripItem";
            this.PasteStripItem.Size = new System.Drawing.Size(186, 22);
            this.PasteStripItem.Text = "Paste";
            this.PasteStripItem.Click += new System.EventHandler(this.PasteStripItem_Click);
            // 
            // MoveStripitem
            // 
            this.MoveStripitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MoveStripitem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MoveStripitem.Image = global::GUI.Properties.Resources._64pxMove;
            this.MoveStripitem.Name = "MoveStripitem";
            this.MoveStripitem.Size = new System.Drawing.Size(186, 22);
            this.MoveStripitem.Text = "Move";
            this.MoveStripitem.Click += new System.EventHandler(this.MoveStripitem_Click);
            // 
            // RenameStripitem
            // 
            this.RenameStripitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RenameStripitem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RenameStripitem.Image = global::GUI.Properties.Resources._16pxRename;
            this.RenameStripitem.Name = "RenameStripitem";
            this.RenameStripitem.Size = new System.Drawing.Size(186, 22);
            this.RenameStripitem.Text = "Rename";
            this.RenameStripitem.Click += new System.EventHandler(this.RenameStripitem_Click);
            // 
            // DeleteStripitem
            // 
            this.DeleteStripitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DeleteStripitem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteStripitem.Image = global::GUI.Properties.Resources._16pxTrash;
            this.DeleteStripitem.Name = "DeleteStripitem";
            this.DeleteStripitem.Size = new System.Drawing.Size(186, 22);
            this.DeleteStripitem.Text = "Delete";
            this.DeleteStripitem.Click += new System.EventHandler(this.DeleteStripitem_Click);
            // 
            // PropertiesStripItem
            // 
            this.PropertiesStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PropertiesStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PropertiesStripItem.Image = global::GUI.Properties.Resources._16pxProperty;
            this.PropertiesStripItem.Name = "PropertiesStripItem";
            this.PropertiesStripItem.Size = new System.Drawing.Size(186, 22);
            this.PropertiesStripItem.Text = "Properties";
            this.PropertiesStripItem.Click += new System.EventHandler(this.PropertiesStripItem_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackgroundImage = global::GUI.Properties.Resources.Refresh;
            this.RefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RefreshButton.Location = new System.Drawing.Point(86, 4);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ForwardButton.BackgroundImage")));
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ForwardButton.Location = new System.Drawing.Point(26, 4);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(23, 23);
            this.ForwardButton.TabIndex = 4;
            this.ForwardButton.UseVisualStyleBackColor = true;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButton.BackgroundImage")));
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackButton.Location = new System.Drawing.Point(1, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(23, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeselectButton
            // 
            this.DeselectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeselectButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeselectButton.BackgroundImage")));
            this.DeselectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeselectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.DeselectButton.FlatAppearance.BorderSize = 0;
            this.DeselectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DeselectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DeselectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeselectButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.DeselectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeselectButton.Location = new System.Drawing.Point(571, 2);
            this.DeselectButton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.DeselectButton.Name = "DeselectButton";
            this.DeselectButton.Size = new System.Drawing.Size(23, 23);
            this.DeselectButton.TabIndex = 8;
            this.DeselectButton.UseVisualStyleBackColor = true;
            this.DeselectButton.Click += new System.EventHandler(this.DeselectButton_Click);
            // 
            // ChangeKeyButton
            // 
            this.ChangeKeyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeKeyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeKeyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ChangeKeyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ChangeKeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ChangeKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeKeyButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ChangeKeyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeKeyButton.Image = global::GUI.Properties.Resources._16pxForeignKey;
            this.ChangeKeyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeKeyButton.Location = new System.Drawing.Point(447, 2);
            this.ChangeKeyButton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ChangeKeyButton.Name = "ChangeKeyButton";
            this.ChangeKeyButton.Size = new System.Drawing.Size(98, 23);
            this.ChangeKeyButton.TabIndex = 2;
            this.ChangeKeyButton.Text = "Change Key";
            this.ChangeKeyButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeKeyButton.UseVisualStyleBackColor = true;
            this.ChangeKeyButton.Click += new System.EventHandler(this.ChangeKeyButton_Click);
            // 
            // InformationButton
            // 
            this.InformationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationButton.BackgroundImage = global::GUI.Properties.Resources._16pxInformation;
            this.InformationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InformationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.InformationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.InformationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.InformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationButton.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.InformationButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InformationButton.Location = new System.Drawing.Point(417, 2);
            this.InformationButton.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(23, 23);
            this.InformationButton.TabIndex = 7;
            this.InformationButton.UseVisualStyleBackColor = true;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // UpArrowButton
            // 
            this.UpArrowButton.BackgroundImage = global::GUI.Properties.Resources._64pxArrowUp;
            this.UpArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpArrowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.UpArrowButton.Location = new System.Drawing.Point(61, 4);
            this.UpArrowButton.Name = "UpArrowButton";
            this.UpArrowButton.Size = new System.Drawing.Size(23, 23);
            this.UpArrowButton.TabIndex = 9;
            this.UpArrowButton.UseVisualStyleBackColor = true;
            this.UpArrowButton.Click += new System.EventHandler(this.UpArrowButton_Click);
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.ExplorerContainer);
            this.Name = "FileExplorer";
            this.Size = new System.Drawing.Size(803, 460);
            this.Load += new System.EventHandler(this.FileExplorer_Load);
            this.ExplorerContainer.ResumeLayout(false);
            this.ExplorerContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerGrid)).EndInit();
            this.ExplorerGridMenuStrip.ResumeLayout(false);
            this.ToolBarTableLayoutPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.BelowPanel.ResumeLayout(false);
            this.BelowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ExplorerContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextAndImageColumn textAndImageColumn1;
        private TextAndImageColumn textAndImageColumn2;
        private TextAndImageColumn textAndImageColumn3;
        private TextAndImageColumn textAndImageColumn4;
        private TextAndImageColumn textAndImageColumn5;
        private System.Windows.Forms.TableLayoutPanel ToolBarTableLayoutPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView ExplorerGrid;
        private System.Windows.Forms.Panel BelowPanel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.ContextMenuStrip ExplorerGridMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewStripItem;
        private System.Windows.Forms.ToolStripMenuItem DirectoryStripItem;
        private System.Windows.Forms.ToolStripMenuItem FileStripitem;
        private System.Windows.Forms.ToolStripMenuItem DocumentStrimitem;
        private System.Windows.Forms.ToolStripSeparator NewSeperator;
        private System.Windows.Forms.ToolStripMenuItem NewWindowStripItem;
        private System.Windows.Forms.ToolStripSeparator NewWindowSeperator;
        private System.Windows.Forms.ToolStripMenuItem CopyStripItem;
        private System.Windows.Forms.ToolStripMenuItem PasteStripItem;
        private System.Windows.Forms.ToolStripSeparator PasteSeperator;
        private System.Windows.Forms.ToolStripMenuItem MoveStripitem;
        private System.Windows.Forms.ToolStripMenuItem RenameStripitem;
        private System.Windows.Forms.ToolStripMenuItem DeleteStripitem;
        private System.Windows.Forms.ToolStripSeparator DeleteSeperator;
        private System.Windows.Forms.ToolStripMenuItem PropertiesStripItem;
        private PathPanel PathPanel;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearClipboardButton;
        private System.Windows.Forms.Label SeperateCloseLabel;
        private System.Windows.Forms.Label PanelSeperatorLabel;
        private System.Windows.Forms.Button ChangeKeyButton;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.Button DeselectButton;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexCol;
        private TextAndImageColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebsiteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastEditedCol;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordStripItem;
        private System.Windows.Forms.Button UpArrowButton;
    }
}
