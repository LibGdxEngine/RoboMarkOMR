using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboMark
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            bunifuDropdown1.AddItem("عبري");
            bunifuDropdown1.AddItem("لغة عربية");
            bunifuDropdown1.AddItem("انجليزي");
        }

        private void BunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
        }

        private void BunifuButton2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            ChooseModelControl m = new ChooseModelControl();
            NavigateToNextUserControl(m);
        }
        private void NavigateToNextUserControl(Control value)
        {
            value.Dock = DockStyle.Fill;
            Form1.instance().MarkPanelContainer().Controls.Add(value);
            Form1.instance().MarkPanelContainer().Controls["ChooseModelControl"].BringToFront();
            Form1.instance().MarkPanelContainer().Controls["PanelSide"].BringToFront();

        }
    }
}