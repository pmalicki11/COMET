using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COMET
{
    public partial class Plot : UserControl
    {
        
        public Plot()
        {
            InitializeComponent();
        }

        public Plot(String title)
        {
            InitializeComponent();
            this.chart.Titles.Add(title);
        }

        public void addSeries(Series series)
        {
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            this.chart.Series.Add(series);
        }

        public void addIntersections(Double criterionValue, Double x, Double y)
        {
            String name = criterionValue.ToString() + " -> " + y.ToString();
            Series series = new Series(name);
            series.Color = Color.DarkGray;
            series.ChartType = SeriesChartType.Line;
            series.BorderDashStyle = ChartDashStyle.Dash;
            series.BorderWidth = 1;
            series.Points.AddXY(chart.ChartAreas[0].AxisX.Minimum, y);
            series.Points.AddXY(x, y);
            series.Points.AddXY(x, chart.ChartAreas[0].AxisY.Minimum);
            series.Legend = null;
            if (!intersectionExists(series))
            {
                this.chart.Series.Add(series);

            }
        }

        private bool intersectionExists(Series seriesNew)
        {
            foreach (Series series in this.chart.Series)
            {
                if (seriesEqual(series, seriesNew))
                {
                    return true;
                }
            }
            return false;
        }

        public void removeIntersections()
        {
            while (findIntersectionIndex() > -1)
            {
                this.chart.Series.RemoveAt(findIntersectionIndex());
            }
        }

        private int findIntersectionIndex()
        {
            for (int i = 0; i < chart.Series.Count; i++)
            {
                if (chart.Series[i].BorderDashStyle == ChartDashStyle.Dash)
                { 
                    return i;
                }
            }
        return -1;
        }

        private bool seriesEqual(Series s1, Series s2)
        {
            for (int i = 0; i < s1.Points.Count; i++)
            {
                if (s1.Points[i].XValue != s2.Points[i].XValue || s1.Points[i].YValues[0] != s2.Points[i].YValues[0])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
