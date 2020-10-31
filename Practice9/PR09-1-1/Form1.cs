using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR09_1_1
{
    public partial class Form1 : Form
    {
        Point tmp_location;
        int w = SystemInformation.PrimaryMonitorSize.Width;
        int h = SystemInformation.PrimaryMonitorSize.Height;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
           if(e.X>80 && e.X<190 && e.Y>60 && e.Y < 110)
            {
                tmp_location.X += rnd.Next(-100, 100);
                tmp_location.Y += rnd.Next(-100, 100);
                if (tmp_location.X < 0 || tmp_location.X > (w - this.Width / 2) || tmp_location.Y < 0 || tmp_location.Y > (h - this.Height / 2))
                {
                    tmp_location.X = w / 2;
                    tmp_location.Y = h / 2;
                }
                this.Location = tmp_location;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ну кто бы сомневался");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Жаль тебя", "Что-то пошло не так", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
