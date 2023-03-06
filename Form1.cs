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

namespace Notepad
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }
        private void saveFile()
        {
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }
        private void loadFile()
        {
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                textBox.Clear();
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }
        private void showMessage()
        {
            DialogResult result = MessageBox.Show("Do you want to save the file?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                saveFile();
                textBox.Clear();
            }
            else if (result == DialogResult.No)
            {
                textBox.Clear();
            }

        }
        private void menuSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Length!=0)
            {
                showMessage();
            }
            loadFile();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            showMessage();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            textBox.Font = fontDialog.Font;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.BackColor = Color.FromArgb(0, 0, 255);
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.BackColor = Color.FromArgb(0, 0, 0);
            textBox.ForeColor = Color.FromArgb(255, 255, 255);
        }
    }
}
