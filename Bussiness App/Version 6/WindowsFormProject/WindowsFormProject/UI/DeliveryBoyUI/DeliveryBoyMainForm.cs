using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormProject.UI.DeliveryBoyUI
{
    public partial class DeliveryBoyMainForm : Form
    {
        public DeliveryBoyMainForm()
        {
            InitializeComponent();
        }
        public Form ActiveForm;
        private void AddUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            this.childpanel.Controls.Clear();
            this.childpanel.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChangePassword form = new ChangePassword();
            AddUserControl(form);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SignIN signIN = new SignIN();
            this.Hide();
            signIN.Show();

        }
    }
}
