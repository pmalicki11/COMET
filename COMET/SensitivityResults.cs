using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMET
{
    public partial class SensitivityResults : Form
    {
        Double bResult;
        int lastLocation = 0;
        public SensitivityResults(String input, String result)
        {
            InitializeComponent();
            this.baseResult.Title = "Base result";
            this.baseResult.Input = input;
            this.baseResult.Result = result;
            this.baseResult.ResultChange = "0";
            this.bResult = Convert.ToDouble(result);
        }

        public void addResult(String title, String input, String result)
        {
            SensitivityResultSingle res = new SensitivityResultSingle();
            res.Title = title;
            res.Input = input;
            res.Result = result;
            Double currentResult = Convert.ToDouble(result);
            res.ResultChange = Math.Round(((currentResult - bResult) / bResult * 100), 4).ToString();
            res.Location = new Point(0, lastLocation);
            resultsPanel.Controls.Add(res);
            lastLocation += res.Size.Height + 2;
        }

    }
}
