using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR10_1_1
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        State state = new State();
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90)); 
            if (listBox1.Items.Count > 7) 
            {
                listBox1.Items.Clear(); 
                listBox1.Items.Add("Игра окончена!");
                timer1.Stop(); 
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode)) 
            {
                listBox1.Items.Remove(e.KeyCode); 
                listBox1.Refresh();
                if (timer1.Interval > 400) timer1.Interval -= 10;
                if (timer1.Interval > 250) timer1.Interval -= 7;
                if (timer1.Interval > 100) timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;
                state.Update(true); 
            }
            else
            {
                state.Update(false);
            }
            correctLabel.Text = "Correct: " + state.Correct;
            missedLabel.Text = "Missed " + state.Missed;
            totalLabel.Text = "Total " + state.Total;
            accuracyLabel.Text = "Accuracy: " + state.Accuracy + "%";
        }
    }
}
