namespace GUI {
    partial class NotesInputDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesInputDialog));
            this.DoneButtonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonContainer = new System.Windows.Forms.Panel();
            this.FontSizeLabel = new System.Windows.Forms.Label();
            this.FontSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.DoneButton = new System.Windows.Forms.Button();
            this.NotesRichTextBoxPanel = new GUI.Panel.RichTextBoxPanel();
            this.DoneButtonContainer.SuspendLayout();
            this.ButtonContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DoneButtonContainer
            // 
            this.DoneButtonContainer.ColumnCount = 1;
            this.DoneButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DoneButtonContainer.Controls.Add(this.ButtonContainer, 0, 1);
            this.DoneButtonContainer.Controls.Add(this.NotesRichTextBoxPanel, 0, 0);
            this.DoneButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoneButtonContainer.Location = new System.Drawing.Point(0, 0);
            this.DoneButtonContainer.Name = "DoneButtonContainer";
            this.DoneButtonContainer.Padding = new System.Windows.Forms.Padding(9);
            this.DoneButtonContainer.RowCount = 2;
            this.DoneButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DoneButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.DoneButtonContainer.Size = new System.Drawing.Size(590, 331);
            this.DoneButtonContainer.TabIndex = 0;
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.Controls.Add(this.FontSizeLabel);
            this.ButtonContainer.Controls.Add(this.FontSizeUpDown);
            this.ButtonContainer.Controls.Add(this.DoneButton);
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonContainer.Location = new System.Drawing.Point(9, 287);
            this.ButtonContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.Size = new System.Drawing.Size(572, 35);
            this.ButtonContainer.TabIndex = 2;
            // 
            // FontSizeLabel
            // 
            this.FontSizeLabel.AutoSize = true;
            this.FontSizeLabel.Location = new System.Drawing.Point(52, 14);
            this.FontSizeLabel.Name = "FontSizeLabel";
            this.FontSizeLabel.Size = new System.Drawing.Size(51, 13);
            this.FontSizeLabel.TabIndex = 13;
            this.FontSizeLabel.Text = "Font Size";
            // 
            // FontSizeUpDown
            // 
            this.FontSizeUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.FontSizeUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.FontSizeUpDown.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FontSizeUpDown.Location = new System.Drawing.Point(4, 9);
            this.FontSizeUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.FontSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FontSizeUpDown.Name = "FontSizeUpDown";
            this.FontSizeUpDown.Size = new System.Drawing.Size(45, 23);
            this.FontSizeUpDown.TabIndex = 12;
            this.FontSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.FontSizeUpDown.ValueChanged += new System.EventHandler(this.FontSizeUpDown_ValueChanged);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(492, 9);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(76, 23);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // NotesRichTextBoxPanel
            // 
            this.NotesRichTextBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NotesRichTextBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesRichTextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesRichTextBoxPanel.InputText = "";
            this.NotesRichTextBoxPanel.Location = new System.Drawing.Point(12, 12);
            this.NotesRichTextBoxPanel.Name = "NotesRichTextBoxPanel";
            this.NotesRichTextBoxPanel.Padding = new System.Windows.Forms.Padding(3);
            this.NotesRichTextBoxPanel.PanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NotesRichTextBoxPanel.ReadOnly = false;
            this.NotesRichTextBoxPanel.Size = new System.Drawing.Size(566, 272);
            this.NotesRichTextBoxPanel.TabIndex = 3;
            this.NotesRichTextBoxPanel.TextColor = System.Drawing.SystemColors.HighlightText;
            this.NotesRichTextBoxPanel.TextFont = new System.Drawing.Font("Segoe UI", 11F);
            // 
            // NotesInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(590, 331);
            this.Controls.Add(this.DoneButtonContainer);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotesInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notes";
            this.DoneButtonContainer.ResumeLayout(false);
            this.ButtonContainer.ResumeLayout(false);
            this.ButtonContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DoneButtonContainer;
        private System.Windows.Forms.Panel ButtonContainer;
        private System.Windows.Forms.Button DoneButton;
        private Panel.RichTextBoxPanel NotesRichTextBoxPanel;
        private System.Windows.Forms.Label FontSizeLabel;
        private System.Windows.Forms.NumericUpDown FontSizeUpDown;
    }
}