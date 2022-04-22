using System;
using System.ComponentModel;
using System.IO;
using static Barotrauma_Save_Decompressor_Backend.CompressionUtil;

namespace Barotrauma_Save_Decompressor_Form;

public partial class Form : System.Windows.Forms.Form
{
    protected string CompressDirectory;

    protected string CompressFilePath;
    protected string DecompressDirectory;
    protected string DecompressFilePath;

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
        DecompressToDirectory(DecompressFilePath, DecompressDirectory);
    }

    private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
    {
    }

    private void DecompressBrowseButton_Click(object sender, EventArgs e)
    {
        string filepath = FormUtil.ShowFileBrowserDialog();

        if (filepath == "")
        {
            return;
        }

        DecompressFilePath         = filepath;
        DecompressDirectory        = Path.GetDirectoryName(DecompressFilePath);
        DecompressFilePathBox.Text = DecompressFilePath;
    }

    private void DecompressSection_Click(object sender, EventArgs e)
    {
    }

    private void FilePathBox_TextChanged(object sender, EventArgs e)
    {
    }

    private void CompressButton_Click(object sender, EventArgs e)
    {
        CompressDirectory(CompressDirectory, CompressFilePath);
    }

    private void CompressBrowseButton_Click(object sender, EventArgs e)
    {
        string filepath = FormUtil.ShowFolderBrowserDialog();

        if (filepath == "")
        {
            return;
        }

        CompressDirectory        = filepath;
        CompressFilePath         = Path.GetDirectoryName(CompressDirectory);
        CompressFilePathBox.Text = CompressDirectory;
    }

    private void CompressSection_Click(object sender, EventArgs e)
    {
    }

    private void OutputBox_TextChanged(object sender, EventArgs e)
    {
        OutputBox.SelectionStart = OutputBox.Text.Length;
        OutputBox.ScrollToCaret();
    }
}
