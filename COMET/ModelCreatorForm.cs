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
    public partial class ModelCreatorForm : Form
    {
        private List<CriterionControl> criteriaControls;
        private List<CharacteristicObject> characteristicObjectsList;
        pairJudgment pj;
        SaveFileDialog saveFileDialog;
        
        public ModelCreatorForm()
        {
            InitializeComponent();
            //create and configure first Criterion control
            criteriaControls = new List<CriterionControl>();
            criteriaControls.Add(firstCriterionControl);
            criteriaControls.Last<CriterionControl>().LinkLabelClick += operationLinkLabelClick;
        }

        public ModelCreatorForm(ExcelFileManager loader)
        {
            InitializeComponent();
            this.characteristicObjectsList = loader.objectList;
            pj = new pairJudgment(loader);
            pj.Location = new Point(136, 99);
            judgmentPanel.Controls.Add(pj);
            showJudgmentPanel();
        }

        private void operationLinkLabelClick(object sender, EventArgs e)
        {
            //occurs when click on operation inside concrete control
            LinkLabel opLabel = (LinkLabel)sender;
            switch (opLabel.Text)
            {
                case ("Add criterion"):
                    addCiterionToList(sender);
                    break;
                case ("Delete"):
                    deleteCriterionFromList(sender, opLabel);
                    break;
            }
        } 

        private void addCiterionToList(object sender)
        {
            if (criteriaControls.Last<CriterionControl>().isCorrect()) //fields filled etc.
            {
                CriterionControl criterion = new CriterionControl();
                criterion.Location = new Point(criteriaControls.Last<CriterionControl>().Location.X, criteriaControls.Last<CriterionControl>().Location.Y + 30);
                creatorPanel.Controls.Add(criterion);
                criteriaControls.Add(criterion);
                criteriaControls.Last<CriterionControl>().LinkLabelClick += operationLinkLabelClick;
            }
            else
            {
                MessageBox.Show("Please enter criterion name and values");
            }
        }

        private void deleteCriterionFromList(object sender, LinkLabel itemLabel)
        {
            int deletedIndex = 0;
            deletedIndex = criteriaControls.IndexOf((CriterionControl)itemLabel.Parent);
            criteriaControls.Remove((CriterionControl)itemLabel.Parent);
            creatorPanel.Controls.Remove(itemLabel.Parent);
            // layout of controls corrections (move up controls with index greater than deleted control)
            foreach (CriterionControl currentCriterion in criteriaControls)
            {
                if (criteriaControls.IndexOf(currentCriterion) >= deletedIndex)
                {
                    currentCriterion.Location = new Point(currentCriterion.Location.X, currentCriterion.Location.Y - 30);
                }
            }
        }

        private void creatorNextButton_Click(object sender, EventArgs e)
        {
            //at least 2 criteria must be entered 
            if (criteriaControls.Count > 2)
            {
                int numberOfCharacteristicObjects = 1;

                //vector product of all crieria
                foreach (CriterionControl i in criteriaControls)
                {
                    if (i.CriterionName.Length > 0)
                    {
                        numberOfCharacteristicObjects *= i.Values.Length;
                    }
                }

                characteristicObjectsList = new List<CharacteristicObject>(numberOfCharacteristicObjects);


                int[] combination = new int[criteriaControls.Count - 1];
                Array.Clear(combination, 0, combination.Length);

                for (int i = 0; i < numberOfCharacteristicObjects; i++)
                {
                    CharacteristicObject currentObject = new CharacteristicObject(criteriaControls.Count - 1);

                    //assign values with generated indexes to object.
                    for (int j = 0; j < currentObject.Size(); j++)
                    {
                        currentObject.setObjectValues(j, criteriaControls[j].CriterionName, criteriaControls[j].Values[combination[j]]);
                    }
                    characteristicObjectsList.Add(currentObject);

                    //set next combination of indexes for new characteristic object
                    for (int c = combination.Length - 1; c >= 0; c--)
                    {
                        if (combination[c] < criteriaControls[c].Values.Length - 1)
                        {
                            combination[c]++;
                            break;
                        }
                        combination[c] = 0;
                    }
                }

                //prepare and initialize judgment panel to show
                pj = new pairJudgment(ref characteristicObjectsList);
                pj.Location = new Point(136, 99);
                judgmentPanel.Controls.Add(pj);
                showJudgmentPanel();
            }
            else
            {
                MessageBox.Show("Please enter at least two criteria.");
            }
        }

        private void judgmentNextButton_Click(object sender, EventArgs e)
        {
            if (pj.JudgmentCompleted)
            {
                judgmentResultsContent.Text = "";
                for (int i = 0; i < characteristicObjectsList.Count; i++)
                {
                    judgmentResultsContent.Text += "R" + (i + 1) + ": ";
                    for (int j = 0; j < characteristicObjectsList[0].Size(); j++)
                    {
                        judgmentResultsContent.Text += "IF " + characteristicObjectsList[i].names[j] + "~" + characteristicObjectsList[i].values[j];
                        if (j + 1 != characteristicObjectsList[0].Size())
                        {
                            judgmentResultsContent.Text += " AND ";
                        }
                    }
                    judgmentResultsContent.Text += " THEN " + characteristicObjectsList[i].Preference + "\n\n";
                }
                showJudgmentResultsPanel();
            }
            else
            {
                MessageBox.Show("Judgment not completed!\nYou can save actual results and finish judgment later.");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Microsoft Excel Worksheet (*.xls)|*.xls";
            //saveFileDialog.Filter = "Microsoft Excel Worksheet (*.xls)|*.xls|XML File (*.xml)|*.xml";
            saveFileDialog.FileOk += saveFileDialog_FileOk;
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //create classes that can save to different filetypes
            //check what type user want to save and create object "saver" using chracteristic object list
            //save to file
            Console.WriteLine(saveFileDialog.FileName);
            ExcelFileManager fm = new ExcelFileManager(pj);
            try
            {
                fm.saveToFile(saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\nProgram restart needed");
            }
        }

        public void showJudgmentPanel()
        {
            creatorPanel.Hide();
            judgmentResultsPanel.Hide();
            judgmentPanel.Show();
        }

        private void showJudgmentResultsPanel()
        {
            creatorPanel.Hide();
            judgmentPanel.Hide();
            judgmentResultsPanel.Show();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            bool closeForm = true;

            if (judgmentPanel.Visible)
            { 
                if (MessageBox.Show("Are  you sure?",
                                    "Exit to main menu", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    closeForm = false;
                }
            }

            if (closeForm)
            {
                this.Hide();
                StartForm form = new StartForm();
                form.ShowDialog();
                this.Close();
            }
        }

        private void inferenceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            InferenceForm form = new InferenceForm(characteristicObjectsList);
            form.ShowDialog();
            this.Close();
        }
    }
}
