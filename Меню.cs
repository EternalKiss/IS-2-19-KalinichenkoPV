﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_KalinichenkoPV
{
    public partial class Меню : Form
    {
        public Меню()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Задание1 Form2 = new Задание1();
            Form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Задание2 Form3 = new Задание2();
            Form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Задание3 Form4 = new Задание3();
            Form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Задание4 Form5 = new Задание4();
            Form5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Задание5 Form6 = new Задание5();
            Form6.ShowDialog();
        }
    }
}
