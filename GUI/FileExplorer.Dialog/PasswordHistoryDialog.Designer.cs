namespace GUI {
    partial class PasswordHistoryDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordHistoryDialog));
            this.BackgroundContainer = new System.Windows.Forms.TableLayoutPanel();
            this.DateGrid = new System.Windows.Forms.DataGridView();
            this.IndexCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new GUI.TextAndImageColumn();
            this.AgeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textAndImageColumn1 = new GUI.TextAndImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BackgroundContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateGrid)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundContainer
            // 
            this.BackgroundContainer.ColumnCount = 1;
            this.BackgroundContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackgroundContainer.Controls.Add(this.DateGrid, 0, 0);
            this.BackgroundContainer.Controls.Add(this.BottomPanel, 0, 1);
            this.BackgroundContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundContainer.Location = new System.Drawing.Point(0, 0);
            this.BackgroundContainer.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundContainer.Name = "BackgroundContainer";
            this.BackgroundContainer.RowCount = 2;
            this.BackgroundContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BackgroundContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.BackgroundContainer.Size = new System.Drawing.Size(544, 324);
            this.BackgroundContainer.TabIndex = 0;
            // 
            // DateGrid
            // 
            this.DateGrid.AllowUserToAddRows = false;
            this.DateGrid.AllowUserToDeleteRows = false;
            this.DateGrid.AllowUserToOrderColumns = true;
            this.DateGrid.AllowUserToResizeColumns = false;
            this.DateGrid.AllowUserToResizeRows = false;
            this.DateGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DateGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DateGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DateGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DateGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexCol,
            this.DateCol,
            this.AgeCol});
            this.DateGrid.ContextMenuStrip = this.MenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DateGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DateGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateGrid.EnableHeadersVisualStyles = false;
            this.DateGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DateGrid.Location = new System.Drawing.Point(10, 10);
            this.DateGrid.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.DateGrid.MultiSelect = false;
            this.DateGrid.Name = "DateGrid";
            this.DateGrid.ReadOnly = true;
            this.DateGrid.RowHeadersVisible = false;
            this.DateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DateGrid.Size = new System.Drawing.Size(524, 271);
            this.DateGrid.TabIndex = 0;
            this.DateGrid.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateGrid_CellMouseEnter);
            this.DateGrid.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DateGrid_CellMouseLeave);
            this.DateGrid.SelectionChanged += new System.EventHandler(this.DateGrid_SelectionChanged);
            this.DateGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DateGrid_MouseDown);
            // 
            // IndexCol
            // 
            this.IndexCol.HeaderText = "";
            this.IndexCol.Name = "IndexCol";
            this.IndexCol.ReadOnly = true;
            this.IndexCol.Visible = false;
            // 
            // DateCol
            // 
            this.DateCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateCol.HeaderText = "Edit date";
            this.DateCol.Image = null;
            this.DateCol.Name = "DateCol";
            this.DateCol.ReadOnly = true;
            this.DateCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // AgeCol
            // 
            this.AgeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.AgeCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.AgeCol.HeaderText = "Ago";
            this.AgeCol.Name = "AgeCol";
            this.AgeCol.ReadOnly = true;
            this.AgeCol.Width = 125;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddStripItem,
            this.EditStripItem,
            this.RemoveStripItem});
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(170, 70);
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.MenuStrip_Opening);
            // 
            // AddStripItem
            // 
            this.AddStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AddStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddStripItem.Image = global::GUI.Properties.Resources._16pxAdd;
            this.AddStripItem.Name = "AddStripItem";
            this.AddStripItem.Size = new System.Drawing.Size(169, 22);
            this.AddStripItem.Text = "Add edit date        ";
            this.AddStripItem.Click += new System.EventHandler(this.AddStripItem_Click);
            // 
            // EditStripItem
            // 
            this.EditStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EditStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditStripItem.Image = global::GUI.Properties.Resources._16pxEdit;
            this.EditStripItem.Name = "EditStripItem";
            this.EditStripItem.Size = new System.Drawing.Size(169, 22);
            this.EditStripItem.Text = "Edit";
            this.EditStripItem.Click += new System.EventHandler(this.EditStripItem_Click);
            // 
            // RemoveStripItem
            // 
            this.RemoveStripItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RemoveStripItem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveStripItem.Image = global::GUI.Properties.Resources._16pxTrash;
            this.RemoveStripItem.Name = "RemoveStripItem";
            this.RemoveStripItem.Size = new System.Drawing.Size(169, 22);
            this.RemoveStripItem.Text = "Remove";
            this.RemoveStripItem.Click += new System.EventHandler(this.RemoveStripItem_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CloseButton.Location = new System.Drawing.Point(10, 10);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.textAndImageColumn1.HeaderText = "Date";
            this.textAndImageColumn1.Image = null;
            this.textAndImageColumn1.Name = "textAndImageColumn1";
            this.textAndImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ago";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.RemoveButton);
            this.BottomPanel.Controls.Add(this.AddButton);
            this.BottomPanel.Controls.Add(this.EditButton);
            this.BottomPanel.Controls.Add(this.CloseButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 281);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(544, 43);
            this.BottomPanel.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AddButton.Image = global::GUI.Properties.Resources._16pxAdd;
            this.AddButton.Location = new System.Drawing.Point(453, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(23, 23);
            this.AddButton.TabIndex = 17;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditButton.Image = global::GUI.Properties.Resources._16pxEdit;
            this.EditButton.Location = new System.Drawing.Point(482, 10);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(23, 23);
            this.EditButton.TabIndex = 16;
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveButton.Image = global::GUI.Properties.Resources._16pxTrash;
            this.RemoveButton.Location = new System.Drawing.Point(511, 10);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(23, 23);
            this.RemoveButton.TabIndex = 18;
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // PasswordHistoryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(544, 324);
            this.Controls.Add(this.BackgroundContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordHistoryDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Password edit history";
            this.Load += new System.EventHandler(this.PasswordHistoryDialog_Load);
            this.BackgroundContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateGrid)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BackgroundContainer;
        private System.Windows.Forms.DataGridView DateGrid;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextAndImageColumn textAndImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddStripItem;
        private System.Windows.Forms.ToolStripMenuItem EditStripItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveStripItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexCol;
        private TextAndImageColumn DateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeCol;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}