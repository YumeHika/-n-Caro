﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_Caro
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Battle _battle  = new Battle(richTextBox1.Text);
            _battle.Show();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
