namespace GUI {
    partial class DocumentDialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentDialog));
            this.TextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TableLayoutContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonContainer = new System.Windows.Forms.Panel();
            this.ColorButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.ChangeFontButton = new System.Windows.Forms.Button();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TableLayoutContainer.SuspendLayout();
            this.ButtonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextRichTextBox
            // 
            this.TextRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.TextRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextRichTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TextRichTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TextRichTextBox.Location = new System.Drawing.Point(12, 12);
            this.TextRichTextBox.Name = "TextRichTextBox";
            this.TextRichTextBox.Size = new System.Drawing.Size(566, 270);
            this.TextRichTextBox.TabIndex = 0;
            this.TextRichTextBox.Text = "";
            // 
            // TableLayoutContainer
            // 
            this.TableLayoutContainer.ColumnCount = 1;
            this.TableLayoutContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutContainer.Controls.Add(this.TextRichTextBox, 0, 0);
            this.TableLayoutContainer.Controls.Add(this.ButtonContainer, 0, 1);
            this.TableLayoutContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutContainer.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutContainer.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutContainer.Name = "TableLayoutContainer";
            this.TableLayoutContainer.Padding = new System.Windows.Forms.Padding(9);
            this.TableLayoutContainer.RowCount = 2;
            this.TableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TableLayoutContainer.Size = new System.Drawing.Size(590, 331);
            this.TableLayoutContainer.TabIndex = 1;
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.Controls.Add(this.ColorButton);
            this.ButtonContainer.Controls.Add(this.DoneButton);
            this.ButtonContainer.Controls.Add(this.ChangeFontButton);
            this.ButtonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonContainer.Location = new System.Drawing.Point(9, 285);
            this.ButtonContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.Size = new System.Drawing.Size(572, 37);
            this.ButtonContainer.TabIndex = 1;
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ColorButton.Image = global::GUI.Properties.Resources._16pxColorWheel;
            this.ColorButton.Location = new System.Drawing.Point(110, 10);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(23, 23);
            this.ColorButton.TabIndex = 2;
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneButton.Location = new System.Drawing.Point(492, 10);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(76, 23);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // ChangeFontButton
            // 
            this.ChangeFontButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ChangeFontButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeFontButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ChangeFontButton.Image = global::GUI.Properties.Resources._16pxFont;
            this.ChangeFontButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChangeFontButton.Location = new System.Drawing.Point(4, 10);
            this.ChangeFontButton.Name = "ChangeFontButton";
            this.ChangeFontButton.Size = new System.Drawing.Size(96, 23);
            this.ChangeFontButton.TabIndex = 0;
            this.ChangeFontButton.Text = "Change Font";
            this.ChangeFontButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeFontButton.UseVisualStyleBackColor = false;
            this.ChangeFontButton.Click += new System.EventHandler(this.ChangeFontButton_Click);
            // 
            // DocumentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(590, 331);
            this.Controls.Add(this.TableLayoutContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocumentDialog_FormClosing);
            this.TableLayoutContainer.ResumeLayout(false);
            this.ButtonContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextRichTextBox;
        private System.Windows.Forms.TableLayoutPanel TableLayoutContainer;
        private System.Windows.Forms.Panel ButtonContainer;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button ChangeFontButton;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}