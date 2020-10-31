using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR09_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image MemForImage;
        private void LoadImage(bool jpg)
        {
            openFileDialog1.InitialDirectory = "c:";
            if (jpg)
            {
                openFileDialog1.Filter = "image (JPEG) files (*.jpg)|*.jpg|All files(*.*) | *.* ";
            }
            else
            {
                openFileDialog1.Filter = "image (PNG) files (*.png)|*.png|All files(*.*) | *.* ";
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MemForImage = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = MemForImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось загрузить файл: " + ex.Message);
                }
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Точно хочешь выйти", "ТЫ серьезно?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            LoadImage(false);
        }

        private void вФорматеJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage(true);
        }

        private void вФорматеPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage(false);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LoadImage(true);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form PreView = new Preview(MemForImage);
            PreView.ShowDialog();
        }
    }
}
