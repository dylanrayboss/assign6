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
    public partial class Graph1 : Form
    {
        public Graph1()
        {
            int counter = 0;
            InitializeComponent();
            this.actualGraph1.ChartAreas[0].AxisX.Interval = 1;
            foreach (var line in Variables.series)
            {
                if (counter == Variables.limit)
                    break;
                this.actualGraph1.Series.Add(line);
                counter++;
            }
            foreach (var people in Variables.people)
            {
                for (int i = 0; i < counter; i++)
                {
                    this.actualGraph1.Series[i].Points.AddXY(people[0], people[i+1]);
                }
            }
        }
    }
}
