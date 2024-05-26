using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = colorInput.Text + "" + animalinput.Text;
            label8.Text = "With" + numberinput.Text + "" + bodypartinput.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            animalinput.Clear(); colorInput.Clear(); bodypartinput.Clear(); numberinput.Clear();
            label7.Text = ""; label8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
