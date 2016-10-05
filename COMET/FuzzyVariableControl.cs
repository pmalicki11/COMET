using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMET
{
    public partial class FuzzyVariableControl : UserControl
    {
        public FuzzyVariableControl(String name)
        {
            InitializeComponent();
            criterionName.Text = name;
        }

        public String NameOfVariable
        {
            get
            {
                return criterionName.Text;
            }
        }
    }
}
