using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COMET
{
    public partial class InferenceAlternatives : Form
    {
        private InferenceForm parent;

        public InferenceAlternatives(InferenceForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            parent.AlternativesNumber = Convert.ToInt16(this.numOfAlternatives.Value);
            this.Close();
        }

        private void loadFromFile_Click(object sender, EventArgs e)
        {
            Stream stream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Microsoft Excel Worksheet (*.xls)|*.xls";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = openFileDialog.OpenFile()) != null)
                    {
                        ExcelFileManager loader = new ExcelFileManager(stream);
                        loader.loadAlternativesFromFile();
                        int numOfAlternatives = loader.alternatives.GetLength(0);
                        parent.AlternativesNumber = Convert.ToInt16(numOfAlternatives);
                        parent.AlternativesValues = loader.alternatives;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    Application.Exit();
                }
            }
        }
    }
}
