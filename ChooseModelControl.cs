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
    public partial class ChooseModelControl : UserControl
    {
        public ChooseModelControl()
        {
            InitializeComponent();
        }

        private void NoOfChoicesDropDown_onItemSelected(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            UserControlEdit m = new UserControlEdit();
            NavigateToManualModelEditor(m);
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel14_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel13_Click(object sender, EventArgs e)
        {

        }

        private void BunifuRadioButton1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuRadioButton2_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel12_Click(object sender, EventArgs e)
        {

        }

        private void BunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void BunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuLabel10_Click(object sender, EventArgs e)
        {

        }

        private void BunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void BunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void BunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
           
            
        }
        private void NavigateToManualModelEditor(Control value)
        {
            UserControlEdit m = new UserControlEdit();
            m.Dock = DockStyle.Fill;
            Form1.instance().MarkPanelContainer().Controls.Add(m);
            Form1.instance().MarkPanelContainer().Controls["UserControlEdit"].BringToFront();
            Form1.instance().MarkPanelContainer().Controls["PanelSide"].BringToFront();

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void ChooseModelControl_Load(object sender, EventArgs e)
        {
            noOfChoicesDropDown.AddItem("3");
            noOfChoicesDropDown.AddItem("4");
            noOfChoicesDropDown.AddItem("5");
        }
    }
}
