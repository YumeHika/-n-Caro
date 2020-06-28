using System;
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
            this.Close();
            ListRoom listroom = new ListRoom();
            listroom.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ListRoom listroom = new ListRoom();
            listroom.Show();
        }
    }
}
