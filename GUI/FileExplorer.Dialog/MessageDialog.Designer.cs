namespace GUI {
    partial class MessageDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageDialog));
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.FormContainer = new System.Windows.Forms.TableLayoutPanel();
            this.MessagePanel = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.TextPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            this.FormContainer.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = global::GUI.Properties.Resources._64pxMessage;
            this.IconPictureBox.Location = new System.Drawing.Point(10, 10);
            this.IconPictureBox.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(40, 40);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 2;
            this.IconPictureBox.TabStop = false;
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RichTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RichTextBox.Location = new System.Drawing.Point(3, 3);
            this.RichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.ReadOnly = true;
            this.RichTextBox.Size = new System.Drawing.Size(506, 295);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
            // 
            // TextPanel
            // 
            this.TextPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextPanel.Controls.Add(this.RichTextBox);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Location = new System.Drawing.Point(60, 10);
            this.TextPanel.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Padding = new System.Windows.Forms.Padding(3);
            this.TextPanel.Size = new System.Drawing.Size(514, 303);
            this.TextPanel.TabIndex = 5;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.OkButton.Location = new System.Drawing.Point(499, 8);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ButtonPanel.Controls.Add(this.OkButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonPanel.Location = new System.Drawing.Point(0, 323);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(584, 38);
            this.ButtonPanel.TabIndex = 4;
            // 
            // Container
            // 
            this.FormContainer.ColumnCount = 1;
            this.FormContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormContainer.Controls.Add(this.MessagePanel, 0, 0);
            this.FormContainer.Controls.Add(this.ButtonPanel, 0, 1);
            this.FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormContainer.Location = new System.Drawing.Point(0, 0);
            this.FormContainer.Name = "Container";
            this.FormContainer.RowCount = 2;
            this.FormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FormContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.FormContainer.Size = new System.Drawing.Size(584, 361);
            this.FormContainer.TabIndex = 6;
            // 
            // MessagePanel
            // 
            this.MessagePanel.ColumnCount = 2;
            this.MessagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MessagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MessagePanel.Controls.Add(this.IconPictureBox, 0, 0);
            this.MessagePanel.Controls.Add(this.TextPanel, 1, 0);
            this.MessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagePanel.Location = new System.Drawing.Point(0, 0);
            this.MessagePanel.Margin = new System.Windows.Forms.Padding(0);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.RowCount = 1;
            this.MessagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MessagePanel.Size = new System.Drawing.Size(584, 323);
            this.MessagePanel.TabIndex = 0;
            // 
            // MessageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.FormContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 150);
            this.Name = "MessageDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.MessageDialog_Load);
            this.Shown += new System.EventHandler(this.MessageDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.TextPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            this.FormContainer.ResumeLayout(false);
            this.MessagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.TableLayoutPanel FormContainer;
        private System.Windows.Forms.TableLayoutPanel MessagePanel;
    }
}