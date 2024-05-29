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
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
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
