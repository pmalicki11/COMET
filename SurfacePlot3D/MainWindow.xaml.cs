using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFSurfacePlot3D;


namespace SurfacePlot3D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SurfacePlotModel model;
        public MainWindow(Double[,] zArray, Double[] xArray, Double[] yArray)
        {
            InitializeComponent();
            model = new SurfacePlotModel();
            mySurfacePlotView.DataContext = model;
            model.PlotData(zArray);
            
        }
        


    }
}
