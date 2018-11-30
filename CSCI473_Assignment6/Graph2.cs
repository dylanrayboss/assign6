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
            foreach (var line in Variables.series)
            {
                if (counter == Variables.limit)
                    break;
                this.actualGraph2.Series.Add(line);
                counter++;
            }
            foreach (var people in Variables.people)
            {
                for (int i = 0; i < counter; i++)
                {
                    this.actualGraph2.Series[i].Points.AddXY(people[0], people[i + 1]);
                    this.actualGraph2.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    this.actualGraph2.Series[i].BorderWidth = 5;
                }
            }
        }
    }
}
