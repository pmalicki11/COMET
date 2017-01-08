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
    public partial class AlternativeControl : UserControl
    {
        private List<TextBox> criteria;

        public AlternativeControl(int numOfCriteria, int index)
        {
            InitializeComponent();
            generateControls(numOfCriteria);
            this.label1.Text = index.ToString() + ":";
            this.Size = this.Size = new System.Drawing.Size(this.Controls[numOfCriteria - 1].Location.X + 300, 20);
            this.label2.Text = "Result: ";
            this.label2.Location = new Point(this.Size.Width - 75, 4);
        }

        private void generateControls(int numOfCriteria)
        {
            criteria = new List<TextBox>();
            for (int i = 0; i < numOfCriteria; i++)
            {
                TextBox criterion = new TextBox();
                if (i == 0)
                {
                    criterion.Location = new Point(30, 0);
                }
                else
                {
                    criterion.Location = new Point(criteria[i - 1].Location.X + 80 , 0);
                }
                criterion.Size = new System.Drawing.Size(60, 20);

                criteria.Add(criterion);
                this.Controls.Add(criterion);
            }
        }

        public Double getCriterionValue(int index)
        {
            Double val = 0.0;
            try
            {
                val = Convert.ToDouble(criteria[index].Text.Replace(".", ","));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return val;
        }

        public Double Result
        {
            set
            {
                this.label2.Text = "Result: " + value.ToString();
            }
        }
    }
}
