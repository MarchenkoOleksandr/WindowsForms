using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinForms_homework1_5_runaway_static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            label1.Text = "Чомусь ми так і думали! ;-)\n   З повагою, адміністрація";
        }

        private void ButtonNo_MouseEnter(object sender, EventArgs e)
        {
            if (ButtonNo.Location.X == 10 && ButtonNo.Location.Y == 70)
                ButtonNo.Location = new Point(10, 255);
            else if (ButtonNo.Location.X == 10 && ButtonNo.Location.Y == 255)
                ButtonNo.Location = new Point(455, 255);
            else if (ButtonNo.Location.X == 455 && ButtonNo.Location.Y == 255)
                ButtonNo.Location = new Point(455, 70);
            else
                ButtonNo.Location = new Point(10, 70);
        }
    }
}