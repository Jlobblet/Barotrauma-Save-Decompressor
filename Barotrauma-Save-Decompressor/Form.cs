using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.ComponentModel;
using System.IO;

namespace Barotrauma_Save_Decompressor
{
    public partial class Form : System.Windows.Forms.Form
    {
        protected string DecompressFilePath;
        protected string DecompressDirectory;

        protected string CompressFilePath;
        protected string CompressDirectory;

        public Form()
        {
            InitializeComponent();
            Console.SetOut(new MultiTextWriter(new ControlWriter(OutputBox), Console.Out));
            Console.Out.NewLine = "\n";
        }

        private void DecompressForm_Load(object sender, EventArgs e)
        {

        }

        private void DecompressButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Decompressing " + DecompressDirectory);
            string newDir;
            newDir = Path.Combine(DecompressDirectory, Path.GetFileNameWithoutExtension(DecompressFilePath));
            Directory.CreateDirectory(newDir);
            SaveUtils.DecompressToDirectory(DecompressFilePath, newDir);
            Console.WriteLine("Decompressed to " + newDir);
            Console.WriteLine("Success");
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void DecompressBrowseButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                InitialDirectory = SaveUtils.SaveFolder,

                EnsureFileExists = true,
                EnsurePathExists = true,

                DefaultExtension = "save",

                ShowHiddenItems = true,
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                DecompressFilePath = dialog.FileName;
                DecompressDirectory = Path.GetDirectoryName(DecompressFilePath);
                DecompressFilePathBox.Text = DecompressFilePath;
            }
        }

        private void DecompressSection_Click(object sender, EventArgs e)
        {

        }

        private void FilePathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompressButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Compressing " + CompressDirectory);
            SaveUtils.CompressDirectory(CompressDirectory, CompressFilePath);
            Console.WriteLine("Compressed to " + CompressFilePath);
            Console.WriteLine("Success");
        }

        private void CompressBrowseButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog()
            {
                InitialDirectory = SaveUtils.SaveFolder,

                EnsureFileExists = true,
                EnsurePathExists = true,

                IsFolderPicker = true,

                ShowHiddenItems = true,
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                CompressDirectory = dialog.FileName;
                CompressFilePath = Path.Combine(Path.GetDirectoryName(CompressDirectory), Path.GetFileName(CompressDirectory) + ".save");
                CompressFilePathBox.Text = CompressDirectory;
            }

        }

        private void CompressSection_Click(object sender, EventArgs e)
        {

        }
    }
}
