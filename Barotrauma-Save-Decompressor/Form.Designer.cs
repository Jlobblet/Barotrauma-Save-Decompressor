namespace Barotrauma_Save_Decompressor
{
    partial class Form
    {
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.DecompressButton = new System.Windows.Forms.Button();
            this.DecompressBrowseButton = new System.Windows.Forms.Button();
            this.DecompressFilePathBox = new System.Windows.Forms.TextBox();
            this.DecompressSection = new System.Windows.Forms.Label();
            this.CompressSection = new System.Windows.Forms.Label();
            this.CompressFilePathBox = new System.Windows.Forms.TextBox();
            this.CompressBrowseButton = new System.Windows.Forms.Button();
            this.CompressButton = new System.Windows.Forms.Button();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DecompressButton
            // 
            this.DecompressButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecompressButton.Location = new System.Drawing.Point(12, 63);
            this.DecompressButton.Name = "DecompressButton";
            this.DecompressButton.Size = new System.Drawing.Size(577, 26);
            this.DecompressButton.TabIndex = 0;
            this.DecompressButton.Text = "Decompress";
            this.DecompressButton.UseVisualStyleBackColor = true;
            this.DecompressButton.Click += new System.EventHandler(this.DecompressButton_Click);
            // 
            // DecompressBrowseButton
            // 
            this.DecompressBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DecompressBrowseButton.Location = new System.Drawing.Point(465, 24);
            this.DecompressBrowseButton.Name = "DecompressBrowseButton";
            this.DecompressBrowseButton.Size = new System.Drawing.Size(124, 33);
            this.DecompressBrowseButton.TabIndex = 1;
            this.DecompressBrowseButton.Text = "Browse";
            this.DecompressBrowseButton.UseVisualStyleBackColor = true;
            this.DecompressBrowseButton.Click += new System.EventHandler(this.DecompressBrowseButton_Click);
            // 
            // DecompressFilePathBox
            // 
            this.DecompressFilePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecompressFilePathBox.Location = new System.Drawing.Point(15, 29);
            this.DecompressFilePathBox.Name = "DecompressFilePathBox";
            this.DecompressFilePathBox.Size = new System.Drawing.Size(447, 22);
            this.DecompressFilePathBox.TabIndex = 2;
            this.DecompressFilePathBox.TextChanged += new System.EventHandler(this.FilePathBox_TextChanged);
            // 
            // DecompressSection
            // 
            this.DecompressSection.AutoSize = true;
            this.DecompressSection.Location = new System.Drawing.Point(12, 4);
            this.DecompressSection.Name = "DecompressSection";
            this.DecompressSection.Size = new System.Drawing.Size(106, 17);
            this.DecompressSection.TabIndex = 3;
            this.DecompressSection.Text = "Decompression";
            this.DecompressSection.Click += new System.EventHandler(this.DecompressSection_Click);
            // 
            // CompressSection
            // 
            this.CompressSection.AutoSize = true;
            this.CompressSection.Location = new System.Drawing.Point(12, 92);
            this.CompressSection.Name = "CompressSection";
            this.CompressSection.Size = new System.Drawing.Size(90, 17);
            this.CompressSection.TabIndex = 4;
            this.CompressSection.Text = "Compression";
            this.CompressSection.Click += new System.EventHandler(this.CompressSection_Click);
            // 
            // CompressFilePathBox
            // 
            this.CompressFilePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompressFilePathBox.Location = new System.Drawing.Point(12, 114);
            this.CompressFilePathBox.Name = "CompressFilePathBox";
            this.CompressFilePathBox.Size = new System.Drawing.Size(447, 22);
            this.CompressFilePathBox.TabIndex = 7;
            // 
            // CompressBrowseButton
            // 
            this.CompressBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CompressBrowseButton.Location = new System.Drawing.Point(465, 109);
            this.CompressBrowseButton.Name = "CompressBrowseButton";
            this.CompressBrowseButton.Size = new System.Drawing.Size(124, 33);
            this.CompressBrowseButton.TabIndex = 6;
            this.CompressBrowseButton.Text = "Browse";
            this.CompressBrowseButton.UseVisualStyleBackColor = true;
            this.CompressBrowseButton.Click += new System.EventHandler(this.CompressBrowseButton_Click);
            // 
            // CompressButton
            // 
            this.CompressButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompressButton.Location = new System.Drawing.Point(12, 148);
            this.CompressButton.Name = "CompressButton";
            this.CompressButton.Size = new System.Drawing.Size(577, 26);
            this.CompressButton.TabIndex = 5;
            this.CompressButton.Text = "Compress";
            this.CompressButton.UseVisualStyleBackColor = true;
            this.CompressButton.Click += new System.EventHandler(this.CompressButton_Click);
            // 
            // OutputBox
            // 
            this.OutputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputBox.Location = new System.Drawing.Point(15, 192);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(574, 270);
            this.OutputBox.TabIndex = 8;
            this.OutputBox.Text = "";
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 477);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.CompressFilePathBox);
            this.Controls.Add(this.CompressBrowseButton);
            this.Controls.Add(this.CompressButton);
            this.Controls.Add(this.CompressSection);
            this.Controls.Add(this.DecompressSection);
            this.Controls.Add(this.DecompressFilePathBox);
            this.Controls.Add(this.DecompressBrowseButton);
            this.Controls.Add(this.DecompressButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(621, 282);
            this.Name = "Form";
            this.Text = "Barotrauma Savefile Compressor and Decompressor";
            this.Load += new System.EventHandler(this.DecompressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DecompressButton;
        private System.Windows.Forms.Button DecompressBrowseButton;
        private System.Windows.Forms.TextBox DecompressFilePathBox;
        private System.Windows.Forms.Label DecompressSection;
        private System.Windows.Forms.Label CompressSection;
        private System.Windows.Forms.TextBox CompressFilePathBox;
        private System.Windows.Forms.Button CompressBrowseButton;
        private System.Windows.Forms.Button CompressButton;
        private System.Windows.Forms.RichTextBox OutputBox;
    }
}

