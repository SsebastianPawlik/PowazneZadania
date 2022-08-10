using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DiffMatchPatch;
using System.Collections.Generic;

namespace testowePorownywanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FileCompare(richTextBox1.Text, richTextBox2.Text))
            {
                MessageBox.Show("Files are equal.");
            }
            else
            {
                MessageBox.Show("Files are not equal.");
            }
        }
        private bool FileCompare(string file1, string file2)
        {
            int file1byte;
            int file2byte;
            FileStream fs1;
            FileStream fs2;

            // Determine if the same file was referenced two times.
            if (file1 == file2)
            {
                // Return true to indicate that the files are the same.
                return true;
            }

            // Open the two files.
            fs1 = new FileStream(file1, FileMode.Open);
            fs2 = new FileStream(file2, FileMode.Open);

            // Check the file sizes. If they are not the same, the files
            // are not the same.
            if (fs1.Length != fs2.Length)
            {
                // Close the file
                fs1.Close();
                fs2.Close();

                // Return false to indicate files are different
                return false;
            }

            // Read and compare a byte from each file until either a
            // non-matching set of bytes is found or until the end of
            // file1 is reached.
            do
            {
                // Read one byte from each file.
                file1byte = fs1.ReadByte();
                file2byte = fs2.ReadByte();
            }
            while ((file1byte == file2byte) && (file1byte != -1));

            // Close the files.
            fs1.Close();
            fs2.Close();

            // Return the success of the comparison. "file1byte" is
            // equal to "file2byte" at this point only if the files are
            // the same.
            return ((file1byte - file2byte) == 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = true;
            if (od.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = od.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = true;
            if (od.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = od.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = File.ReadAllText(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = File.ReadAllText(textBox2.Text);
        }        
        private void button6_Click(object sender, EventArgs e)
        {
            string tekst1 = richTextBox1.Text;
            string tekst2 = richTextBox2.Text;
            diff_match_patch dmp = new diff_match_patch();
            List<Diff> diff = dmp.diff_main(tekst1, tekst2);
            dmp.diff_cleanupSemantic(diff);
            for(int i = 0; i < diff.Count; i++)
            {
                richTextBox3.Text = diff[i]+"\n";
            }
        }      
    }
}
