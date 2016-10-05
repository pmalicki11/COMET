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
    public partial class CriterionControl : UserControl
    {
        public CriterionControl()
        {
            InitializeComponent();
        }

        //reference to labelClickEvent handled in upper class
        public delegate void LinkLabelLinkClickedEventHandler(object sender, EventArgs e);
        public event LinkLabelLinkClickedEventHandler LinkLabelClick;

        private void operationLabel_Click(object sender, EventArgs e)
        {
            if (LinkLabelClick != null)
            {
                LinkLabelClick(sender, e);
            }
        }
        
        //assign enter action as a linkLabel action
        private void enterPressed(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                operationLabel_Click(this.operationLabel, e);
            }
        }

        //fields validated
        public Boolean isCorrect()
        {
            if (criterionTextBox.Text.Length > 0 && valuesTextBox.Text.Length > 0)
            {
                criterionTextBox.Enabled = false;
                valuesTextBox.Enabled = false;
                operationLabel.Text = "Delete";
                return true;
            } 
            else
            {
                return false;
            }
        }
        
        public String CriterionName
        {
            get
            {
                return this.criterionTextBox.Text;
            }
        }

        public String[] Values
        {
            get
            {
                char[] separator = new char[] { ',' };
                return this.valuesTextBox.Text.Trim().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
