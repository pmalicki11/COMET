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
    public partial class SensitivityResultSingle : UserControl
    {
        public SensitivityResultSingle()
        {
            InitializeComponent();
        }

        public String Title
        {
            get
            {
                return this.title.Text;
            }
            set
            {
                this.title.Text = value;
            }
        }

        public String Input
        {
            get
            {
                return this.inputValues.Text;
            }
            set
            {
                this.inputValues.Text = value;
            }
        }

        public String Result
        {
            get
            {
                return this.result.Text;
            }
            set
            {
                this.result.Text = "Result: " + value;
            }
        }

        public String ResultChange
        {
            get
            {
                return this.resultChange.Text;
            }
            set
            {
                this.resultChange.Text = "Result change: " + value + "%";
            }
        }
    }
}
