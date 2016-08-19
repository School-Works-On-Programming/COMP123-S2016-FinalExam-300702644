using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{
    public partial class GenerateNameForm : Form
    {

        private Random _random; 


        public GenerateNameForm()
        {
            InitializeComponent();
        }

        public void GenerateNames()
        {
            FirstNameTextBox.Text = this.Roll().ToString();
            LastNameTextBox.Text = this.Roll().ToString();
        }

        private void GenerateNamesButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
