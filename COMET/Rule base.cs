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
    public partial class Rule_base : Form
    {
        public Rule_base(String rules)
        {
            InitializeComponent();
            this.rules.Text = rules;
        }
    }
}
