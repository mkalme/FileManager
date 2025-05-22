namespace GUI {
    partial class SelectDirectoryDialog {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDirectoryDialog));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ExplorerGrid = new System.Windows.Forms.DataGridView();
            this.IndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new GUI.TextAndImageColumn();
            this.LastEditedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PathPanel = new GUI.PathPanel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.UpArrowButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TableLayoutPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerGrid)).BeginInit();
            this.ToolPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 1;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Controls.Add(this.BottomPanel, 0, 2);
            this.TableLayoutPanel.Controls.Add(this.ExplorerGrid, 0, 1);
            this.TableLayoutPanel.Controls.Add(this.ToolPanel, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TableLayoutPanel.RowCount = 3;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(461, 339);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.CancelDialogButton);
            this.BottomPanel.Controls.Add(this.SelectButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BottomPanel.Location = new System.Drawing.Point(6, 304);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(449, 35);
            this.BottomPanel.TabIndex = 0;
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CancelDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDialogButton.Image = global::GUI.Properties.Resources._16pxCancel;
            this.CancelDialogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelDialogButton.Location = new System.Drawing.Point(300, 5);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(70, 23);
            this.CancelDialogButton.TabIndex = 1;
            this.CancelDialogButton.Text = "Cancel";
            this.CancelDialogButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelDialogButton.UseVisualStyleBackColor = false;
            this.CancelDialogButton.Click += new System.EventHandler(this.CancelDialogButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SelectButton.Location = new System.Drawing.Point(376, 5);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(70, 23);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ExplorerGrid
            // 
            this.ExplorerGrid.AllowUserToAddRows = false;
            this.ExplorerGrid.AllowUserToDeleteRows = false;
            this.ExplorerGrid.AllowUserToOrderColumns = true;
            this.ExplorerGrid.AllowUserToResizeColumns = false;
            this.ExplorerGrid.AllowUserToResizeRows = false;
            this.ExplorerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ExplorerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExplorerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ExplorerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExplorerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ExplorerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExplorerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexCol,
            this.NameCol,
            this.LastEditedCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExplorerGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ExplorerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExplorerGrid.EnableHeadersVisualStyles = false;
            this.ExplorerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ExplorerGrid.Location = new System.Drawing.Point(9, 34);
            this.ExplorerGrid.MultiSelect = false;
            this.ExplorerGrid.Name = "ExplorerGrid";
            this.ExplorerGrid.ReadOnly = true;
            this.ExplorerGrid.RowHeadersVisible = false;
            this.ExplorerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExplorerGrid.Size = new System.Drawing.Size(443, 267);
            this.ExplorerGrid.TabIndex = 1;
            this.ExplorerGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerGrid_CellDoubleClick);
            this.ExplorerGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerGrid_CellMouseEnter);
            this.ExplorerGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExplorerGrid_CellMouseLeave);
            this.ExplorerGrid.SelectionChanged += new System.EventHandler(this.ExplorerGrid_SelectionChanged);
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
            // 
            // LastEditedCol
            // 
            this.LastEditedCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LastEditedCol.HeaderText = "Last edited";
            this.LastEditedCol.Name = "LastEditedCol";
            this.LastEditedCol.ReadOnly = true;
            this.LastEditedCol.Width = 105;
            // 
            // ToolPanel
            // 
            this.ToolPanel.ColumnCount = 2;
            this.ToolPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.ToolPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolPanel.Controls.Add(this.PathPanel, 0, 0);
            this.ToolPanel.Controls.Add(this.ButtonPanel, 0, 0);
            this.ToolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolPanel.Location = new System.Drawing.Point(9, 1);
            this.ToolPanel.Margin = new System.Windows.Forms.Padding(3, 1, 0, 0);
            this.ToolPanel.Name = "ToolPanel";
            this.ToolPanel.RowCount = 1;
            this.ToolPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolPanel.Size = new System.Drawing.Size(446, 30);
            this.ToolPanel.TabIndex = 2;
            // 
            // PathPanel
            // 
            this.PathPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathPanel.Location = new System.Drawing.Point(58, 3);
            this.PathPanel.Name = "PathPanel";
            this.PathPanel.Size = new System.Drawing.Size(385, 24);
            this.PathPanel.TabIndex = 4;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ButtonPanel.Controls.Add(this.ForwardButton);
            this.ButtonPanel.Controls.Add(this.UpArrowButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(55, 30);
            this.ButtonPanel.TabIndex = 3;
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackgroundImage = global::GUI.Properties.Resources._64pxRightArrow;
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
            // UpArrowButton
            // 
            this.UpArrowButton.BackgroundImage = global::GUI.Properties.Resources._64pxArrowUp;
            this.UpArrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpArrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpArrowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.UpArrowButton.Location = new System.Drawing.Point(1, 4);
            this.UpArrowButton.Name = "UpArrowButton";
            this.UpArrowButton.Size = new System.Drawing.Size(23, 23);
            this.UpArrowButton.TabIndex = 3;
            this.UpArrowButton.UseVisualStyleBackColor = true;
            this.UpArrowButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SelectDirectoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(461, 339);
            this.Controls.Add(this.TableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectDirectoryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select directory";
            this.Load += new System.EventHandler(this.SelectDirectoryDialog_Load);
            this.TableLayoutPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExplorerGrid)).EndInit();
            this.ToolPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button CancelDialogButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.DataGridView ExplorerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexCol;
        private TextAndImageColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastEditedCol;
        private System.Windows.Forms.TableLayoutPanel ToolPanel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button UpArrowButton;
        private PathPanel PathPanel;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}