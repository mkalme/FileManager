namespace GUI {
    partial class ConfirmationDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmationDialog));
            this.MessageLabel = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.NoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.FlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MessageLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MessageLabel.Location = new System.Drawing.Point(60, 16);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 16);
            this.MessageLabel.TabIndex = 0;
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.YesButton.Location = new System.Drawing.Point(3, 3);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 2;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CancelDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDialogButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CancelDialogButton.Location = new System.Drawing.Point(173, 3);
            this.CancelDialogButton.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(75, 23);
            this.CancelDialogButton.TabIndex = 3;
            this.CancelDialogButton.Text = "Cancel";
            this.CancelDialogButton.UseVisualStyleBackColor = false;
            this.CancelDialogButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = global::GUI.Properties.Resources._64pxQuestion;
            this.IconPictureBox.Location = new System.Drawing.Point(12, 14);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(40, 40);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 1;
            this.IconPictureBox.TabStop = false;
            // 
            // FlowPanel
            // 
            this.FlowPanel.AutoSize = true;
            this.FlowPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanel.Controls.Add(this.YesButton);
            this.FlowPanel.Controls.Add(this.NoButton);
            this.FlowPanel.Controls.Add(this.CancelDialogButton);
            this.FlowPanel.Location = new System.Drawing.Point(8, 72);
            this.FlowPanel.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(251, 29);
            this.FlowPanel.TabIndex = 4;
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NoButton.Location = new System.Drawing.Point(88, 3);
            this.NoButton.Margin = new System.Windows.Forms.Padding(7, 3, 3, 3);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 4;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // ConfirmationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(330, 109);
            this.Controls.Add(this.FlowPanel);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.MessageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfirmationDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.ConfirmationDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.FlowPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button CancelDialogButton;
        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Button NoButton;
    }
}