using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace RoboMark
{
    public partial class UserControlEdit : UserControl
    {

        BubblesGenerator generator;
        public UserControlEdit()
        {
            InitializeComponent();
            generator = new BubblesGenerator(this);
            generator.setNumberOfQuestions(15);
            generator.setNumberOfChoices(3);
            generator.rowHeight = 100;

            for (int i = 1; i <= generator.getNumberOfQuestions(); i++)
            {
                this.Controls.Add(generator.GenerateNewRow(i));
            }
        }

        
    }
}
