using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelLibrary.SpreadSheet;
using System.IO;


namespace COMET
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        
        private void createModelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModelCreatorForm form = new ModelCreatorForm();
            form.ShowDialog();
            this.Close();
        }

        private void loadModelButton_Click(object sender, EventArgs e)
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
                        if (loader.loadFromFile())
                        {
                            if (loader.pairsLeft > 0)
                            {
                                this.Hide();
                                ModelCreatorForm form = new ModelCreatorForm(loader);
                                form.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("File contains completed judgment");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    Application.Exit();
                }
            }


        }

        private void inferenceButton_Click(object sender, EventArgs e)
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
                        if (loader.loadFromFile())
                        {
                            if (loader.pairsLeft == 0)
                            {
                                this.Hide();
                                InferenceForm form = new InferenceForm(loader.objectList);
                                form.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("File have not a rule base");
                            }
                        }
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
