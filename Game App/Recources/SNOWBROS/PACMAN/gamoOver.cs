using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACMAN
{
    public partial class gamoOver : Form
    {
        public gamoOver()
        {
            InitializeComponent();
        }

        private void BTN_PLAYAGAIN_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Close();
            this.Close();
        }
    }
}
