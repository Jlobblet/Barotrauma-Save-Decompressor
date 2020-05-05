using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Barotrauma_Save_Decompressor
{
    public class ControlWriter : TextWriter
    {
        private readonly Control textbox;
        public ControlWriter(Control textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.Text += value;
        }

        public override void Write(string value)
        {
            textbox.Text += value;
        }

        public override Encoding Encoding => Encoding.ASCII;
    }

    public class MultiTextWriter : TextWriter
    {
        private readonly IEnumerable<TextWriter> writers;
        public MultiTextWriter(IEnumerable<TextWriter> writers)
        {
            this.writers = writers.ToList();
        }
        public MultiTextWriter(params TextWriter[] writers)
        {
            this.writers = writers;
        }

        public override void Write(char value)
        {
            foreach (TextWriter writer in writers)
            {
                writer.Write(value);
            }
        }

        public override void Write(string value)
        {
            foreach (TextWriter writer in writers)
            {
                writer.Write(value);
            }
        }

        public override void Flush()
        {
            foreach (TextWriter writer in writers)
            {
                writer.Flush();
            }
        }

        public override void Close()
        {
            foreach (TextWriter writer in writers)
            {
                writer.Close();
            }
        }

        public override Encoding Encoding => Encoding.ASCII;
    }
}
