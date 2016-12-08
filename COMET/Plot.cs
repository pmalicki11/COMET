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
        private List<Series> intersections;
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

        public void addIntersections(Double x, Double y)
        {
            Series series = new Series();
            series.Color = Color.Black;
            series.ChartType = SeriesChartType.Line;
            series.BorderDashStyle = ChartDashStyle.Dash;
            series.BorderWidth = 1;
            series.Points.AddXY(chart.ChartAreas[0].AxisX.Minimum, y);
            series.Points.AddXY(x, y);
            series.Points.AddXY(x, chart.ChartAreas[0].AxisY.Minimum);
            this.chart.Series.Add(series);
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
    }
}
