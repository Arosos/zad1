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

namespace zad1
{
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
            Text += PopulationInfo.generationNumber;
            
            Series avSeries = AverageChart.Series.Add("Generation");
            Series maxSeries = MaxChart.Series.Add("Generation");
            Series minSeries= MinChart.Series.Add("Generation");
            Series functionSeries = FunctionChart.Series.Add("Generation");
            Series indSeries = FunctionChart.Series.Add("individual");
            indSeries.ChartType = SeriesChartType.Point;
            functionSeries.ChartType = SeriesChartType.Line;
            foreach (Generation g in Program.generations)
            {
                avSeries.Points.Add(g.average);
                maxSeries.Points.Add(g.max);
                minSeries.Points.Add(g.min);
                foreach (Individual i in Program.generations[0].population)
                    functionSeries.Points.AddXY(i.x, i.fitness);
                foreach (Individual i in Program.generations[Program.generations.Length - 1].population)
                    indSeries.Points.AddXY(i.x, i.fitness);
            }
        }
    }
}
