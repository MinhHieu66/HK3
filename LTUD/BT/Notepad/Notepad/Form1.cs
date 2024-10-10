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

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co muon thoat khong?", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if(font.ShowDialog() == DialogResult.OK)
            {
                rtFile.Font = font.Font;
            }
        }

        private void menuStripFileNew_Click(object sender, EventArgs e)
        {
            rtFile.Clear();
        }

        private void menuStripEditCopy_Click(object sender, EventArgs e)
        {
            rtFile.Copy();
        }

        private void menuStripEditCut_Click(object sender, EventArgs e)
        {
            rtFile.Cut();
        }

        private void menuStripEditPast_Click(object sender, EventArgs e)
        {
            rtFile.Paste();
        }

        private void menuStripFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlg = new OpenFileDialog();
            odlg.Filter = "All file (*.*)|*.*| Text file (*.txt)|*.txt";
            if (odlg.ShowDialog() == DialogResult.OK) {
                //Mo luong fike
                Stream f = odlg.OpenFile();
                StreamReader read = new StreamReader(f);
                rtFile.Text = read.ReadToEnd();

                read.Close();
            }
        }

        private void menuStripFileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "All file (*.*)|*.*| Text file (*.txt)|*.txt";
            if(sdlg.ShowDialog() == DialogResult.OK)
            {
                Stream f = sdlg.OpenFile();
                StreamWriter writer = new StreamWriter(f);
                writer.Write(rtFile.Text);
                writer.Close();
            }
        }

        private void menuStripFormatColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog() == DialogResult.OK)
            {
                rtFile.ForeColor = color.Color;
            }
        }
    }
}
