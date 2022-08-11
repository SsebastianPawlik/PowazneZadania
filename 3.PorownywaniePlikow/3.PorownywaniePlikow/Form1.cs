﻿using DiffMatchPatch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PorownywaniePlikow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        diff_match_patch DIFF = new diff_match_patch();

        // these are the diffs
        List<Diff> diffs;

        // chunks for formatting the two RTBs:
        List<Chunk> chunklist1;
        List<Chunk> chunklist2;

        // two color lists:
        Color[] colors1 = new Color[3] { Color.LightGreen, Color.LightSalmon, Color.White };
        Color[] colors2 = new Color[3] { Color.Red, Color.Red, Color.White };


        public struct Chunk
        {
            public int startpos;
            public int length;
            public Color BackColor;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            diffs = DIFF.diff_main(RTB1.Text, RTB2.Text);
            DIFF.diff_cleanupSemanticLossless(diffs);      // <--- see note !

            chunklist1 = collectChunks(RTB1);
            chunklist2 = collectChunks(RTB2);

            paintChunks(RTB1, chunklist1);
            paintChunks(RTB2, chunklist2);

            RTB1.SelectionLength = 0;
            RTB2.SelectionLength = 0;
        }
        List<Chunk> collectChunks(RichTextBox RTB)
        {
            RTB.Text = "";
            List<Chunk> chunkList = new List<Chunk>();
            foreach (Diff d in diffs)
            {
                if (RTB == RTB2 && d.operation == Operation.DELETE) continue;  // **
                if (RTB == RTB1 && d.operation == Operation.INSERT) continue;  // **

                Chunk ch = new Chunk();
                int length = RTB.TextLength;
                RTB.AppendText(d.text);
                ch.startpos = length;
                ch.length = d.text.Length;
                ch.BackColor = RTB == RTB1 ? colors1[(int)d.operation]
                                           : colors2[(int)d.operation];
                chunkList.Add(ch);
            }
            return chunkList;

        }

        void paintChunks(RichTextBox RTB, List<Chunk> theChunks)
        {
            foreach (Chunk ch in theChunks)
            {
                RTB.Select(ch.startpos, ch.length);
                RTB.SelectionBackColor = ch.BackColor;
            }

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
            RTB1.Text = File.ReadAllText(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RTB2.Text = File.ReadAllText(textBox2.Text);
        }
    }
}
