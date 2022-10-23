using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Mars_Project
{
    public partial class ReadTextFile : Form
    {
        WebClient wc = new WebClient();
        public ReadTextFile()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_READ_Click(object sender, EventArgs e)
        {

            OpenFileDialog OpenFolder = new OpenFileDialog();

            OpenFolder.Filter = "Txt files (*.txt) |*.txt|All files (*.*)|*.*";
            OpenFolder.FilterIndex = 2;
            OpenFolder.RestoreDirectory = true;
            if (OpenFolder.ShowDialog() == DialogResult.OK)
            {
                
                Directory.Text = Path.GetFullPath(OpenFolder.FileName);
                DateTime filecreate = File.GetCreationTime(Directory.Text);
                FileCreatedDateTxtBx.Text = filecreate.ToString();
                string path = OpenFolder.FileName;
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0)
                    {
                        sb.Append(sr.ReadLine());
                    }
                }
                richTextBox1.Text = sb.ToString();
            }
            
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {

            
           wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);

            try
            {
                Uri imageURL = new Uri(LinkURL.Text);
                wc.DownloadFileTaskAsync(imageURL, "NASA Rover.png");
               
            }
            catch
            {
                MessageBox.Show("Invalid please enter URL Link", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
          MessageBox.Show("Download Complete");
            LinkURL.Clear();
        }

        void CopyAction(object sender, EventArgs e)
        {
            Graphics objGraphics;
            Clipboard.SetData(DataFormats.Rtf, richTextBox1.SelectedRtf);
            Clipboard.Clear();
        }

        void PasteAction(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf
                    = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        private void ShowThumbnailBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileFolderOpen = new OpenFileDialog();
            if (FileFolderOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                ThumbnailBox.ImageLocation = FileFolderOpen.FileName;
            }
        }

        private void LinkURL_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
