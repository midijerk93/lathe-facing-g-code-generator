using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Code_Lathe_Facing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateGCodeButton_Click(object sender, EventArgs e)
        {

            if (double.TryParse(odTextbox.Text, out double od))
            {
                double odCut = od + .100;
                string toolNum = toolNumTextbox.Text;

                DialogBox.Text = "";
                DialogBox.Text += "T" + toolNum + "0" + toolNum + ";";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G54;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "M8;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G50 S1500;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G96 S650 M3;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G0 X10. Z0.;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "X" + Convert.ToString(odCut) + ";";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G1 X-.050 F.010;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G0 Z.1;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G28 U0.;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G0 Z2.;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "M5;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "M9;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "M30;";
            }
            else
            {
                MessageBox.Show("Please enter fields numerically only.");
                odTextbox.Text = "";
                toolNumTextbox.Text = "";
            }
            
        }
    }
}
