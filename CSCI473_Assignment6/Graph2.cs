using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Alonso Arteaga 
 * Dylan Boss
 * Haley Scheina
 */

namespace CSCI473_Assignment6
{
    public partial class Graph2 : Form
    {
        public Graph2()
        {
            int counter = 0;
            InitializeComponent();
            this.actualGraph2.ChartAreas[0].AxisX.Interval = 1;
            this.Text = "How Many Crickets My Lizards Eat Per Month";
            foreach (var line in Variables.seriesLizard)
            {
                if (counter == Variables.limit)
                    break;
                this.actualGraph2.Series.Add(line);
                counter++;
            }
            for (int i = 0; i < counter; i++)
            {
                foreach (var crickets in Variables.crickets)
                {
                    this.actualGraph2.Series[i].Points.AddXY(crickets[0], crickets[i + 1]);
                    this.actualGraph2.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    this.actualGraph2.Series[i].BorderWidth = 5;
                }
            }
        }
    }
}
