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
using AI.Fuzzy.Library;

namespace COMET
{
    public partial class InferenceForm : Form
    {
        List<CharacteristicObject> objectList;
        List<FuzzyVariableControl> inputVariables;
        List<MamdaniFuzzyRule> rules;
        MamdaniFuzzySystem fuzzySystem;
        FuzzyVariable[] systemInputVariables;

        public InferenceForm(List<CharacteristicObject> list)
        {
            InitializeComponent();
            objectList = list;
            generateControls();
        }

        private void generateControls()
        {
            inputVariables = new List<FuzzyVariableControl>();
            for (int i = 0; i < objectList[0].Size(); i++)
            {
                FuzzyVariableControl variableControl = new FuzzyVariableControl(objectList[0].names[i]);
                if (inputVariables.Capacity > 0)
                {
                    variableControl.Location = new Point(inputVariables.Last<FuzzyVariableControl>().Location.X, inputVariables.Last<FuzzyVariableControl>().Location.Y + 30);
                }
                else
                {
                    variableControl.Location = new Point(12, 40);
                }
                Controls.Add(variableControl);
                inputVariables.Add(variableControl);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            generateFuzzySystem();

            Dictionary<FuzzyVariable, double> inputValues = new Dictionary<FuzzyVariable,double>();
            
            for (int i = 0; i < inputVariables.Count; i++)
            {
                inputValues.Add(fuzzySystem.InputByName(inputVariables[i].NameOfVariable), Convert.ToDouble(inputVariables[i].ValueOfVariable));
            }
            
            FuzzyVariable outputResult = fuzzySystem.OutputByName("output");
            Dictionary<FuzzyVariable, double> result = fuzzySystem.Calculate(inputValues);

            resultTextBox.Text = result[outputResult].ToString("f4");
        }

        private void generateFuzzySystem()
        {
            fuzzySystem = new MamdaniFuzzySystem();
            generateSystemInputVariables();
            generateSystemOutputVariables();
            generateSystemRules();
        }

        private void generateSystemInputVariables()
        {
            systemInputVariables = new FuzzyVariable[objectList[0].Size()];
            for (int i = 0; i < objectList[0].Size(); i++)
            {
                systemInputVariables[i] = new FuzzyVariable(objectList[0].names[i], 0.0, 1000000.0);
                List<String> values = new List<string>();
                for (int j = 0; j < objectList.Count; j++)
                {
                    if (!values.Contains(objectList[j].values[i]))
                    {
                        values.Add(objectList[j].values[i]);
                    }
                }

                values.Sort();

                for (int j = 0; j < values.Count; j++)
                {
                    Double x1 = 0.0;
                    Double x2 = 0.0;
                    Double x3 = 0.0;

                    if (j == 0)
                    {
                        x1 = -1.0;
                        x2 = Convert.ToDouble(values[j]);
                        x3 = Convert.ToDouble(values[j + 1]);
                    }
                    else if (j == values.Count - 1)
                    {
                        x1 = Convert.ToDouble(values[j - 1]);
                        x2 = Convert.ToDouble(values[j]);
                        x3 = 2.0;
                    }
                    else
                    {
                        x1 = Convert.ToDouble(values[j - 1]);
                        x2 = Convert.ToDouble(values[j]);
                        x3 = Convert.ToDouble(values[j + 1]);
                    }
                    systemInputVariables[i].Terms.Add(new FuzzyTerm(values[j].Replace(",", "."), new TriangularMembershipFunction(x1, x2, x3)));
                }
                fuzzySystem.Input.Add(systemInputVariables[i]);
            }
        }

        private void generateSystemOutputVariables()
        {
            objectList = objectList.OrderBy(o => o.Preference).ToList();
            FuzzyVariable outputVariable = new FuzzyVariable("output", 0.0, 1.0);
            for (int i = 0; i < objectList.Count; i++)
            {
                Double x1 = 0.0;
                Double x2 = 0.0;
                Double x3 = 0.0;

                if (i == 0)
                {
                    x1 = -1.0;
                    x2 = objectList[i].Preference;
                    x3 = objectList[i + 1].Preference;
                }
                else if (i == objectList.Count - 1)
                {
                    x1 = objectList[i - 1].Preference;
                    x2 = objectList[i].Preference;
                    x3 = 2.0;
                }
                else
                {
                    x1 = objectList[i - 1].Preference;
                    x2 = objectList[i].Preference;
                    x3 = objectList[i + 1].Preference;
                }
                outputVariable.Terms.Add(new FuzzyTerm(objectList[i].Preference.ToString().Replace(",", "."), new TriangularMembershipFunction(x1, x2, x3)));
            }
            fuzzySystem.Output.Add(outputVariable);

        }

        private void generateSystemRules()
        {   
            rules = new List<MamdaniFuzzyRule>();
            for (int i = 0; i < objectList.Count(); i++)
            {
                String ruleString = "if";
                for (int j = 0; j < inputVariables.Count(); j++)
                {
                    ruleString += " (" + objectList[0].names[j] + " is " + Convert.ToDouble(objectList[i].values[j]).ToString() + ")";
                    if (j < inputVariables.Count() - 1)
                    {
                        ruleString += " and ";
                    }
                }
                ruleString += " then (output is " + objectList[i].Preference.ToString() + ")";
                ruleString = ruleString.Replace(",", ".");
                try
                {
                    fuzzySystem.Rules.Add(fuzzySystem.ParseRule(ruleString));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Parsing exception: {0}", ex.Message));
                }
            }
        }
    }
}
