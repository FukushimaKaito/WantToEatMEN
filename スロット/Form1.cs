using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6._30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int x = rand.Next(1, 10);
            int shusseki = rand.Next(1, 44);
                label2.Text=shusseki.ToString();
            if (x == 1)
                label1.Text = "ラーメン";
            if (x == 2)
                label1.Text = "うどん";
            if (x == 3)
                label1.Text = "そば";
            if (x == 4)
                label1.Text = "パスタ";
            if (x == 5)
                label1.Text = "そうめん";
            if (x == 6)
                label1.Text = "ベビースター";
        }
    }
}