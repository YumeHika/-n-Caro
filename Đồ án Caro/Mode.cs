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
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Battle _battle = new Battle();
            //_battle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Practice _practice = new Practice();
            _practice.Show();
        }
    }
}
