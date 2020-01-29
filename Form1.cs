using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboMark
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
       

        public static Form1 instance()
        {
            if(_obj == null)
            {
                _obj = new Form1();
            }
            return _obj;
        }
        public Panel MarkPanelContainer()
        {
            return markPanel;
        }

        int panelWidth;
        bool hidden;
        int sliderAnimationSpeed = 15;
        public Form1()
        {
            InitializeComponent();
            panelWidth = PanelSide.Width;
            hidden = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                PanelSide.Width = PanelSide.Width + sliderAnimationSpeed;
                if(PanelSide.Width >= panelWidth)
                {
                    sliderTimer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSide.Width = PanelSide.Width - sliderAnimationSpeed;
                if(PanelSide.Width <= 0)
                {
                    sliderTimer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            sliderTimer.Start();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
        
            UserControl1 us = new UserControl1();
            NavigateToMarkUserControl(us);
        }


        private void MarkPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void NavigateToMarkUserControl(Control us)
        {
            us.Dock = DockStyle.Fill;
            markPanel.Controls.Add(us);
            markPanel.Controls["UserControl1"].BringToFront();
            markPanel.Controls["PanelSide"].BringToFront();
        }
        private void PictureBox11_Click(object sender, EventArgs e)
        {
        
        }

    }
}
