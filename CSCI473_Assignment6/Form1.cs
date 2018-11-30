using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*
 * Alonso Arteaga 
 * Dylan Boss
 * Haley Scheina
 */

namespace CSCI473_Assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Variables.ReadData();
        }

        private void ChartTwoButton_Click(object sender, EventArgs e)
        {
            Graph2 graph = new Graph2();
            this.Visible = false;
            graph.ShowDialog();
            this.Visible = true;
        }

        private void ChartFourButton_Click(object sender, EventArgs e)
        {
            Graph4 graph = new Graph4();
            this.Visible = false;
            graph.ShowDialog();
            this.Visible = true;
        }

        private void ChartOneButton_Click(object sender, EventArgs e)
        {
            Graph1 graph = new Graph1();
            this.Visible = false;
            graph.ShowDialog();
            this.Visible = true;
        }

        private void ChartThreeButton_Click(object sender, EventArgs e)
        {
            Graph3 graph = new Graph3();
            this.Visible = false;
            graph.ShowDialog();
            this.Visible = true;
        }

        private void ExitPortalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void perEntryUpDown_ValueChanged(object sender, EventArgs e)
        {
            Variables.limit = Convert.ToInt32(Math.Round(perEntryUpDown.Value, 0));
        }
    }
}
