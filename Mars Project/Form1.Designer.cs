
namespace Mars_Project
{
    partial class ReadTextFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadTextFile));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BTN_READ = new System.Windows.Forms.Button();
            this.Directory = new System.Windows.Forms.TextBox();
            this.FileCreateDateLabel = new System.Windows.Forms.Label();
            this.FileCreatedDateTxtBx = new System.Windows.Forms.TextBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.LinkURL = new System.Windows.Forms.TextBox();
            this.ShowThumbnailBox = new System.Windows.Forms.Button();
            this.ThumbnailBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(24, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(491, 297);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BTN_READ
            // 
            this.BTN_READ.Location = new System.Drawing.Point(3, 331);
            this.BTN_READ.Name = "BTN_READ";
            this.BTN_READ.Size = new System.Drawing.Size(75, 33);
            this.BTN_READ.TabIndex = 1;
            this.BTN_READ.Text = "Fetch";
            this.BTN_READ.UseVisualStyleBackColor = true;
            this.BTN_READ.Click += new System.EventHandler(this.BTN_READ_Click);
            // 
            // Directory
            // 
            this.Directory.Enabled = false;
            this.Directory.Location = new System.Drawing.Point(84, 338);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(419, 20);
            this.Directory.TabIndex = 2;
            // 
            // FileCreateDateLabel
            // 
            this.FileCreateDateLabel.AutoSize = true;
            this.FileCreateDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileCreateDateLabel.Location = new System.Drawing.Point(530, 12);
            this.FileCreateDateLabel.Name = "FileCreateDateLabel";
            this.FileCreateDateLabel.Size = new System.Drawing.Size(244, 31);
            this.FileCreateDateLabel.TabIndex = 3;
            this.FileCreateDateLabel.Text = "File Created Date";
            // 
            // FileCreatedDateTxtBx
            // 
            this.FileCreatedDateTxtBx.Enabled = false;
            this.FileCreatedDateTxtBx.Location = new System.Drawing.Point(536, 58);
            this.FileCreatedDateTxtBx.Name = "FileCreatedDateTxtBx";
            this.FileCreatedDateTxtBx.Size = new System.Drawing.Size(238, 20);
            this.FileCreatedDateTxtBx.TabIndex = 4;
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(536, 95);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(238, 36);
            this.DownloadButton.TabIndex = 5;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // LinkURL
            // 
            this.LinkURL.Location = new System.Drawing.Point(536, 137);
            this.LinkURL.Name = "LinkURL";
            this.LinkURL.Size = new System.Drawing.Size(238, 20);
            this.LinkURL.TabIndex = 6;
            this.LinkURL.TextChanged += new System.EventHandler(this.LinkURL_TextChanged);
            // 
            // ShowThumbnailBox
            // 
            this.ShowThumbnailBox.Location = new System.Drawing.Point(536, 302);
            this.ShowThumbnailBox.Name = "ShowThumbnailBox";
            this.ShowThumbnailBox.Size = new System.Drawing.Size(238, 23);
            this.ShowThumbnailBox.TabIndex = 8;
            this.ShowThumbnailBox.Text = "Show Thumbnail";
            this.ShowThumbnailBox.UseVisualStyleBackColor = true;
            this.ShowThumbnailBox.Click += new System.EventHandler(this.ShowThumbnailBox_Click);
            // 
            // ThumbnailBox
            // 
            this.ThumbnailBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ThumbnailBox.Location = new System.Drawing.Point(536, 174);
            this.ThumbnailBox.Name = "ThumbnailBox";
            this.ThumbnailBox.Size = new System.Drawing.Size(238, 122);
            this.ThumbnailBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThumbnailBox.TabIndex = 9;
            this.ThumbnailBox.TabStop = false;
            // 
            // ReadTextFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 370);
            this.Controls.Add(this.ThumbnailBox);
            this.Controls.Add(this.ShowThumbnailBox);
            this.Controls.Add(this.LinkURL);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.FileCreatedDateTxtBx);
            this.Controls.Add(this.FileCreateDateLabel);
            this.Controls.Add(this.Directory);
            this.Controls.Add(this.BTN_READ);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReadTextFile";
            this.Text = "NASA Text File Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbnailBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BTN_READ;
        private System.Windows.Forms.TextBox Directory;
        private System.Windows.Forms.Label FileCreateDateLabel;
        private System.Windows.Forms.TextBox FileCreatedDateTxtBx;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.TextBox LinkURL;
        private System.Windows.Forms.Button ShowThumbnailBox;
        private System.Windows.Forms.PictureBox ThumbnailBox;
    }
}

