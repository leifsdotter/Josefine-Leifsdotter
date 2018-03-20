using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace del3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] x = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //Lägga till egna värden istället för x och y
            int[] y = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] y2 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i=0; i<x.Length; i++)

            {
                chart1.Series["Series1"].Points.AddXY(x[i], y[i]); //Series1 från grafen i Form1.cs
                chart1.Series["Series1"].Points.AddXY(x[i], y2[i]);
            }

            chart1.Series["Series1"].ChartType = SeriesChartType.Point; //vi ska även använda column istället för point
            chart1.Series["Series2"].ChartType = SeriesChartType.Line;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
