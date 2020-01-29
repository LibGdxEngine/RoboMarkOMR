using Bunifu.UI.WinForms;
using RoboMark.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboMark
{
    
    class BubblesGenerator
    {
        private UserControlEdit _userControl;

        //height of each row in pixeles
        public int rowHeight { get; set; }
        //number of quiz quistions
        private static int noOfQuestions = 10;
        //number of row choices it can be from ( 2 - 5 ) choices
        private static int noOfChoices { get; set; }
        //an array that holds reference to each row panel
        private Control[] rows;
        public int[,] Model;
        public void setNumberOfChoices(int num)
        {
            noOfChoices = num;
           
        }
        public int getNumberOfChoices()
        {

            return noOfChoices;

        }
        public void setNumberOfQuestions(int num)
        {
            noOfQuestions = num;
            rows = new Control[noOfQuestions + 1];
        }
        public int getNumberOfQuestions()
        {
            
           return noOfQuestions;

        }
        public BubblesGenerator(UserControlEdit userControl)
        {
            this._userControl = userControl;
            this.rowHeight = 50;
            rows = new Control[noOfQuestions + 1];
            noOfChoices = 5;
            Model = new int[noOfQuestions, noOfChoices];
        }

        //Generates a new row of options with and index number
        public Control GenerateNewRow(int i)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEdit));

            _userControl.row = new System.Windows.Forms.Panel();
            _userControl.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            _userControl.pictureBox1 = new System.Windows.Forms.PictureBox();
            _userControl.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            _userControl.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            _userControl.pictureBox2 = new System.Windows.Forms.PictureBox();
            _userControl.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            _userControl.pictureBox3 = new System.Windows.Forms.PictureBox();
            _userControl.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            _userControl.pictureBox4 = new System.Windows.Forms.PictureBox();
            _userControl.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            _userControl.pictureBox5 = new System.Windows.Forms.PictureBox();
            _userControl.row.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox5)).BeginInit();
            _userControl.SuspendLayout();
            // 
            // row
            // 
            if (noOfChoices == 5)
            {
                _userControl.row.Controls.Add(_userControl.bunifuLabel6);
                _userControl.row.Controls.Add(_userControl.pictureBox5);
                _userControl.row.Controls.Add(_userControl.bunifuLabel5);
                _userControl.row.Controls.Add(_userControl.pictureBox4);
                _userControl.row.Controls.Add(_userControl.bunifuLabel4);
                _userControl.row.Controls.Add(_userControl.pictureBox3);
                _userControl.row.Controls.Add(_userControl.bunifuLabel3);
                _userControl.row.Controls.Add(_userControl.pictureBox2);
                _userControl.row.Controls.Add(_userControl.bunifuLabel2);
                _userControl.row.Controls.Add(_userControl.pictureBox1);
            }
            else if (noOfChoices == 4)
            {

                _userControl.row.Controls.Add(_userControl.bunifuLabel5);
                _userControl.row.Controls.Add(_userControl.pictureBox4);
                _userControl.row.Controls.Add(_userControl.bunifuLabel4);
                _userControl.row.Controls.Add(_userControl.pictureBox3);
                _userControl.row.Controls.Add(_userControl.bunifuLabel3);
                _userControl.row.Controls.Add(_userControl.pictureBox2);
                _userControl.row.Controls.Add(_userControl.bunifuLabel2);
                _userControl.row.Controls.Add(_userControl.pictureBox1);
            }
            else if (noOfChoices == 3)
            {

                _userControl.row.Controls.Add(_userControl.bunifuLabel4);
                _userControl.row.Controls.Add(_userControl.pictureBox3);
                _userControl.row.Controls.Add(_userControl.bunifuLabel3);
                _userControl.row.Controls.Add(_userControl.pictureBox2);
                _userControl.row.Controls.Add(_userControl.bunifuLabel2);
                _userControl.row.Controls.Add(_userControl.pictureBox1);
            }
            else if (noOfChoices == 2)
            {

                _userControl.row.Controls.Add(_userControl.bunifuLabel3);
                _userControl.row.Controls.Add(_userControl.pictureBox2);
                _userControl.row.Controls.Add(_userControl.bunifuLabel2);
                _userControl.row.Controls.Add(_userControl.pictureBox1);
            }
            else if (noOfChoices == 1)
            {

                _userControl.row.Controls.Add(_userControl.bunifuLabel2);
                _userControl.row.Controls.Add(_userControl.pictureBox1);
            }

            _userControl.row.Controls.Add(_userControl.bunifuLabel1);
            _userControl.row.Location = new System.Drawing.Point(226, i * rowHeight);
            _userControl.row.Name = "row";
            _userControl.row.Size = new System.Drawing.Size(328, 36);
            _userControl.row.TabIndex = 0;
            // 
            // bunifuLabel1
            // 
            _userControl.bunifuLabel1.AutoEllipsis = false;
            _userControl.bunifuLabel1.CursorType = null;
            _userControl.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _userControl.bunifuLabel1.Location = new System.Drawing.Point(3, 11);
            _userControl.bunifuLabel1.Name = "bunifuLabel1";
            _userControl.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _userControl.bunifuLabel1.Size = new System.Drawing.Size(9, 15);
            _userControl.bunifuLabel1.TabIndex = 0;
            _userControl.bunifuLabel1.Text = i + "";
            _userControl.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            _userControl.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pictureBox1
            // 
            _userControl.pictureBox1.Image = ((System.Drawing.Image)Resources.test2);
            _userControl.pictureBox1.Location = new System.Drawing.Point(18, 0);
            _userControl.pictureBox1.Name = "pictureBox1";
            _userControl.pictureBox1.Size = new System.Drawing.Size(34, 36);
            _userControl.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _userControl.pictureBox1.TabIndex = 1;
            _userControl.pictureBox1.TabStop = false;
            _userControl.pictureBox1.Click += new System.EventHandler(OptionAClicked);
            // 
            // bunifuLabel2
            // 
            _userControl.bunifuLabel2.AutoEllipsis = false;
            _userControl.bunifuLabel2.BackColor = Color.FromArgb(232, 233, 236);
            _userControl.bunifuLabel2.CursorType = null;
            _userControl.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _userControl.bunifuLabel2.ForeColor = Color.Black;
            _userControl.bunifuLabel2.Location = new System.Drawing.Point(31, 9);
            _userControl.bunifuLabel2.Name = "bunifuLabel2";
            _userControl.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _userControl.bunifuLabel2.Size = new System.Drawing.Size(10, 15);
            _userControl.bunifuLabel2.TabIndex = 2;
            _userControl.bunifuLabel2.Text = "A";
            _userControl.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            _userControl.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            _userControl.bunifuLabel2.Click += new System.EventHandler(OptionAClicked);
            // 
            // bunifuLabel3
            // 
            _userControl.bunifuLabel3.AutoEllipsis = false;
            _userControl.bunifuLabel3.BackColor = Color.FromArgb(232, 233, 236);
            _userControl.bunifuLabel3.CursorType = null;
            _userControl.bunifuLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _userControl.bunifuLabel3.ForeColor = Color.Black;
            _userControl.bunifuLabel3.Location = new System.Drawing.Point(74, 9);
            _userControl.bunifuLabel3.Name = "bunifuLabel3";
            _userControl.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _userControl.bunifuLabel3.Size = new System.Drawing.Size(10, 15);
            _userControl.bunifuLabel3.TabIndex = 4;
            _userControl.bunifuLabel3.Text = "B";
            _userControl.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            _userControl.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            _userControl.bunifuLabel3.Click += new System.EventHandler(OptionBClicked);
            // 
            // pictureBox2
            // 
            _userControl.pictureBox2.Image = ((System.Drawing.Image)Resources.test2);
            _userControl.pictureBox2.Location = new System.Drawing.Point(62, 0);
            _userControl.pictureBox2.Name = "pictureBox2";
            _userControl.pictureBox2.Size = new System.Drawing.Size(34, 36);
            _userControl.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _userControl.pictureBox2.TabIndex = 3;
            _userControl.pictureBox2.TabStop = false;
            _userControl.pictureBox2.Click += new System.EventHandler(OptionBClicked);
            // 
            // bunifuLabel4
            // 
            _userControl.bunifuLabel4.AutoEllipsis = false;
            _userControl.bunifuLabel4.BackColor = Color.FromArgb(232, 233, 236);
            _userControl.bunifuLabel4.CursorType = null;
            _userControl.bunifuLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _userControl.bunifuLabel4.ForeColor = Color.Black;
            _userControl.bunifuLabel4.Location = new System.Drawing.Point(118, 9);
            _userControl.bunifuLabel4.Name = "bunifuLabel4";
            _userControl.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _userControl.bunifuLabel4.Size = new System.Drawing.Size(10, 15);
            _userControl.bunifuLabel4.TabIndex = 6;
            _userControl.bunifuLabel4.Text = "C";
            _userControl.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            _userControl.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            _userControl.bunifuLabel4.Click += new System.EventHandler(OptionCClicked);
            // 
            // pictureBox3
            // 
            _userControl.pictureBox3.Image = ((System.Drawing.Image)Resources.test2);
            _userControl.pictureBox3.Location = new System.Drawing.Point(106, 0);
            _userControl.pictureBox3.Name = "pictureBox3";
            _userControl.pictureBox3.Size = new System.Drawing.Size(34, 36);
            _userControl.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _userControl.pictureBox3.TabIndex = 5;
            _userControl.pictureBox3.TabStop = false;
            _userControl.pictureBox3.Click += new System.EventHandler(OptionCClicked);
            // 
            // bunifuLabel5
            // 
            _userControl.bunifuLabel5.AutoEllipsis = false;
            _userControl.bunifuLabel5.BackColor = Color.FromArgb(232, 233, 236);
            _userControl.bunifuLabel5.CursorType = null;
            _userControl.bunifuLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _userControl.bunifuLabel5.ForeColor = Color.Black;
            _userControl.bunifuLabel5.Location = new System.Drawing.Point(162, 9);
            _userControl.bunifuLabel5.Name = "bunifuLabel5";
            _userControl.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _userControl.bunifuLabel5.Size = new System.Drawing.Size(11, 15);
            _userControl.bunifuLabel5.TabIndex = 8;
            _userControl.bunifuLabel5.Text = "D";
            _userControl.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            _userControl.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            _userControl.bunifuLabel5.Click += new System.EventHandler(OptionDClicked);
            // 
            // pictureBox4
            // 
            _userControl.pictureBox4.Image = ((System.Drawing.Image)Resources.test2);
            _userControl.pictureBox4.Location = new System.Drawing.Point(150, 0);
            _userControl.pictureBox4.Name = "pictureBox4";
            _userControl.pictureBox4.Size = new System.Drawing.Size(34, 36);
            _userControl.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _userControl.pictureBox4.TabIndex = 7;
            _userControl.pictureBox4.TabStop = false;
            _userControl.pictureBox4.Click += new System.EventHandler(OptionDClicked);
            // 
            // bunifuLabel6
            // 
            _userControl.bunifuLabel6.AutoEllipsis = false;
            _userControl.bunifuLabel6.BackColor = Color.FromArgb(232, 233, 236);
            _userControl.bunifuLabel6.CursorType = null;
            _userControl.bunifuLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _userControl.bunifuLabel6.ForeColor = Color.Black;
            _userControl.bunifuLabel6.Location = new System.Drawing.Point(205, 9);
            _userControl.bunifuLabel6.Name = "bunifuLabel6";
            _userControl.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            _userControl.bunifuLabel6.Size = new System.Drawing.Size(10, 15);
            _userControl.bunifuLabel6.TabIndex = 10;
            _userControl.bunifuLabel6.Text = "E";
            _userControl.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            _userControl.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            _userControl.bunifuLabel6.Click += new System.EventHandler(OptionEClicked);
            // 
            // pictureBox5
            // 
            _userControl.pictureBox5.Image = ((System.Drawing.Image)Resources.test2);
            _userControl.pictureBox5.Location = new System.Drawing.Point(194, 0);
            _userControl.pictureBox5.Name = "pictureBox5";
            _userControl.pictureBox5.Size = new System.Drawing.Size(34, 36);
            _userControl.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            _userControl.pictureBox5.TabIndex = 9;
            _userControl.pictureBox5.TabStop = false;
            _userControl.pictureBox5.Click += new System.EventHandler(OptionEClicked);
            _userControl.row.ResumeLayout(false);
            _userControl.row.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(_userControl.pictureBox5)).EndInit();
            rows[i] = _userControl.row;
            return _userControl.row;
        }


        private void OptionEClicked(object sender, EventArgs e)
        {
            string index = "-1";
            bool ON = false;
            //to handle which control user clicks on -> Text or pictureBox
            if (sender.GetType().ToString().Contains("PictureBox"))
            {
                index = ((Panel)((PictureBox)sender).Parent)
                    .Controls["bunifuLabel1"]
                    .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel6"])
                    .ForeColor == Color.White;

            }
            else if (sender.GetType().ToString().Contains("BunifuLabel"))
            {
                index = ((Panel)((BunifuLabel)sender).Parent)
                         .Controls["bunifuLabel1"]
                         .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel6"])
                    .ForeColor == Color.White;

            }
            if (!ON)
            {
                //if button is pressed while !ON make the corresponding number in array = 1 else = 0
                Model[int.Parse(index), 4] = 1;
            }
            else
            {
                Model[int.Parse(index), 4] = 0;
            }
            //change the clicked button attributes according to index of click
            ToggleButton(index, "E", ON);
        }

        private void OptionDClicked(object sender, EventArgs e)
        {
            string index = "-1";
            bool ON = false;
            //to handle which control user clicks on -> Text or pictureBox
            if (sender.GetType().ToString().Contains("PictureBox"))
            {
                index = ((Panel)((PictureBox)sender).Parent)
                    .Controls["bunifuLabel1"]
                    .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel5"])
                    .ForeColor == Color.White;

            }
            else if (sender.GetType().ToString().Contains("BunifuLabel"))
            {
                index = ((Panel)((BunifuLabel)sender).Parent)
                         .Controls["bunifuLabel1"]
                         .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel5"])
                    .ForeColor == Color.White;

            }
            if (!ON)
            {
                //if button is pressed while !ON make the corresponding number in array = 1 else = 0
                Model[int.Parse(index), 3] = 1;
            }
            else
            {
                Model[int.Parse(index), 3] = 0;
            }
            //change the clicked button attributes according to index of click
            ToggleButton(index, "D", ON);
        }

        private void OptionCClicked(object sender, EventArgs e)
        {
            string index = "-1";
            bool ON = false;
            //to handle which control user clicks on -> Text or pictureBox
            if (sender.GetType().ToString().Contains("PictureBox"))
            {
                index = ((Panel)((PictureBox)sender).Parent)
                    .Controls["bunifuLabel1"]
                    .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel4"])
                    .ForeColor == Color.White;

            }
            else if (sender.GetType().ToString().Contains("BunifuLabel"))
            {
                index = ((Panel)((BunifuLabel)sender).Parent)
                         .Controls["bunifuLabel1"]
                         .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel4"])
                    .ForeColor == Color.White;

            }
            if (!ON)
            {
                //if button is pressed while !ON make the corresponding number in array = 1 else = 0
                Model[int.Parse(index), 2] = 1;
            }
            else
            {
                Model[int.Parse(index), 2] = 0;
            }
            //change the clicked button attributes according to index of click
            ToggleButton(index, "C", ON);
            string result = "";
            for(int i = 0; i < int.Parse(index); i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    result += (Model[i, j] + "");
                }
                result += " \n";
            }
            MessageBox.Show(result + "");
        }

        private void OptionBClicked(object sender, EventArgs e)
        {
            string index = "-1";
            bool ON = false;
            //to handle which control user clicks on -> Text or pictureBox
            if (sender.GetType().ToString().Contains("PictureBox"))
            {
                index = ((Panel)((PictureBox)sender).Parent)
                    .Controls["bunifuLabel1"]
                    .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel3"])
                    .ForeColor == Color.White;

            }
            else if (sender.GetType().ToString().Contains("BunifuLabel"))
            {
                index = ((Panel)((BunifuLabel)sender).Parent)
                         .Controls["bunifuLabel1"]
                         .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel3"])
                    .ForeColor == Color.White;

            }
            if (!ON)
            {
                //if button is pressed while !ON make the corresponding number in array = 1 else = 0
                Model[int.Parse(index), 1] = 1;
            }
            else
            {
                Model[int.Parse(index), 1] = 0;
            }
            //change the clicked button attributes according to index of click
            ToggleButton(index, "B", ON);
        }

        private void OptionAClicked(object sender, EventArgs e)
        {
            string index = "-1";
            bool ON = false;
            //to handle which control user clicks on -> Text or pictureBox
            if (sender.GetType().ToString().Contains("PictureBox"))
            {
                index = ((Panel)((PictureBox)sender).Parent)
                    .Controls["bunifuLabel1"]
                    .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).ForeColor == Color.White;

            }
            else if (sender.GetType().ToString().Contains("BunifuLabel"))
            {
                index = ((Panel)((BunifuLabel)sender).Parent)
                         .Controls["bunifuLabel1"]
                         .Text.ToString();
                ON = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).ForeColor == Color.White;

            }
            if (!ON)
            {
                //if button is pressed while !ON make the corresponding number in array = 1 else = 0
                Model[int.Parse(index), 0] = 1;
            }
            else
            {
                Model[int.Parse(index), 0] = 0;
            }
            //change the clicked button attributes according to index of click
            ToggleButton(index, "A", ON);
        }

        //change button color to blue or white according to its state ( ON or OFF )
        void ToggleButton(string index, string character, bool ON)
        {
            if (character.Equals("A"))
            {
                // string color = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).ForeColor.ToString();
                //  MessageBox.Show(color)
                if (ON)
                {

                    ((PictureBox)rows[int.Parse(index)].Controls["pictureBox1"]).Image = Image.FromFile("C:\\test2.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).ForeColor = Color.Black;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).BackColor = Color.FromArgb(232, 233, 236);
                }
                else
                {
                    ((PictureBox)rows[int.Parse(index)].Controls["pictureBox1"]).Image = Image.FromFile("C:\\test1.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).ForeColor = Color.White;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).BackColor = Color.FromArgb(52, 152, 219);

                }
            }

            else if (character.Equals("B"))
            {
                // string color = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).ForeColor.ToString();
                //  MessageBox.Show(color)
                if (ON)
                {
                    ((PictureBox)rows[int.Parse(index)].Controls["pictureBox2"]).Image = Image.FromFile("C:\\test2.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel3"]).ForeColor = Color.Black;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel3"]).BackColor = Color.FromArgb(232, 233, 236);


                }
                else
                {
                    ((PictureBox)rows[int.Parse(index)].Controls["pictureBox2"]).Image = Image.FromFile("C:\\test1.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel3"]).ForeColor = Color.White;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel3"]).BackColor = Color.FromArgb(52, 152, 219);

                }
            }
            else if (character.Equals("C"))
            {
                // string color = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).ForeColor.ToString();
                //  MessageBox.Show(color)
                if (ON)
                {
                     ((PictureBox)rows[int.Parse(index)].Controls["pictureBox3"]).Image = Image.FromFile("C:\\test2.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel4"]).ForeColor = Color.Black;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel4"]).BackColor = Color.FromArgb(232, 233, 236);

                }
                else
                {
                    ((PictureBox)rows[int.Parse(index)].Controls["pictureBox3"]).Image = Image.FromFile("C:\\test1.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel4"]).ForeColor = Color.White;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel4"]).BackColor = Color.FromArgb(52, 152, 219);

                }
            }
            else if (character.Equals("D"))
            {
                // string color = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).ForeColor.ToString();
                //  MessageBox.Show(color)
                if (ON)
                {
                   ((PictureBox)rows[int.Parse(index)].Controls["pictureBox4"]).Image = Image.FromFile("C:\\test2.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel5"]).ForeColor = Color.Black;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel5"]).BackColor = Color.FromArgb(232, 233, 236);

                }
                else
                {
                    ((PictureBox)rows[int.Parse(index)].Controls["pictureBox4"]).Image = Image.FromFile("C:\\test1.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel5"]).ForeColor = Color.White;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel5"]).BackColor = Color.FromArgb(52, 152, 219);

                }
            }
            else if (character.Equals("E"))
            {
                // string color = ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel2"]).ForeColor.ToString();
                //  MessageBox.Show(color)
                if (ON)
                {
                   ((PictureBox)rows[int.Parse(index)].Controls["pictureBox5"]).Image = Image.FromFile("C:\\test2.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel6"]).ForeColor = Color.Black;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel6"]).BackColor = Color.FromArgb(232, 233, 236);

                }
                else
                {
                    ((PictureBox)rows[int.Parse(index)].Controls["pictureBox5"]).Image = Image.FromFile("C:\\test1.png");
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel6"]).ForeColor = Color.White;
                    ((BunifuLabel)rows[int.Parse(index)].Controls["bunifuLabel6"]).BackColor = Color.FromArgb(52, 152, 219);

                }
            }
        }

    }
}
