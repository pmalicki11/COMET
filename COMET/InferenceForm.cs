using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ExcelLibrary.SpreadSheet;

namespace COMET
{
    public partial class InferenceForm : Form
    {
        #region Old variables
        /*
        List<MamdaniFuzzyRule> rules;
        MamdaniFuzzySystem fuzzySystem;
        FuzzyVariable[] systemInputVariables;*/
        #endregion

        List<CharacteristicObject> objectList;
        List<FuzzyVariableControl> inputVariables;
        Dictionary<String, List<Double>> criteria;
        Dictionary<String, List<TriangularMembershipFunction>> msFunctions;
        Dictionary<String, Plot> plots;

        public InferenceForm(List<CharacteristicObject> list)
        {
            InitializeComponent();
            objectList = list;
            criteria = getCriteriaFromObjectList();
            msFunctions = genetareMembershipFunctions(criteria);
            generateControls();
        }
        
        private void generateControls()
        {
            genPlots();
            genBoxesForInputValues();
        }

        private void genPlots()
        {
            #region OLD
            //List<String> keys = new List<String>(this.criteria.Keys);
            //charts = new List<Chart>();
            //for (int i = 0; i < criteria.Count; i++)
            //{
            //    Chart chart = new Chart();
            //    chart.Location = new Point(i * 310 + 10, 10);
            //    chart.Titles.Add(keys[i]);
            //    chart.Name = keys[i];
            //    ChartArea chartArea = new ChartArea();
            //    chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            //    chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            //    chartArea.AxisX.IsMarginVisible = false;
            //    chartArea.AxisY.IsMarginVisible = false;
            //    chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            //    chart.ChartAreas.Add(chartArea);
            //    for (int j = 0; j < criteria[keys[i]].Count; j++)
            //    {
            //        Series series = new Series();
            //        series.ChartType = SeriesChartType.Line;
            //        setPointsToSeries(getPointsForSeries(keys[i], criteria[keys[i]][j]), ref series);
            //        chart.Series.Add(series);
            //    }
            //    charts.Add(chart);
            //    plotsPanel.Controls.Add(chart);
            //}
            #endregion

            List<String> variableNames = new List<String>(this.criteria.Keys);
            plots = new Dictionary<String, Plot>();

            for (int i = 0; i < criteria.Count; i++)
            {
                Plot plot = new Plot(variableNames[i]);
                plot.Location = new Point(i * 310 + 10, 10);
                for (int j = 0; j < criteria[variableNames[i]].Count; j++)
                {
                    Series series = new Series();
                    setPointsToSeries(getPointsForSeries(variableNames[i], criteria[variableNames[i]][j]), ref series);
                    plot.addSeries(series);
                }
                plots.Add(variableNames[i], plot);
                plotsPanel.Controls.Add(plot);
            }

        }

        private void genBoxesForInputValues()
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
                    variableControl.Location = new Point(12, 430);
                }
                Controls.Add(variableControl);
                inputVariables.Add(variableControl);
            }
        }

        private LinkedList<PointD> getPointsForSeries(String key, Double val)
        {
            LinkedList<PointD> points = new LinkedList<PointD>();
            List<String> keys = new List<String>(this.criteria.Keys);

            for (int i = 0; i < criteria[key].Count; i++)
            {
                if (criteria[key][i] == val)
                {
                    points.AddLast(new PointD(val, 1));
                }
                else
                {
                    points.AddLast(new PointD(criteria[key][i], 0));
                }
            }
            return points;
        }

        private void setPointsToSeries(LinkedList<PointD> points, ref Series series)
        {
            foreach (PointD point in points)
            {
                series.Points.AddXY(point.X, point.Y);
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            #region using of old functions
            /*generateFuzzySystem();

            Dictionary<FuzzyVariable, Double> inputValues = new Dictionary<FuzzyVariable,Double>();
            
            for (int i = 0; i < inputVariables.Count; i++)
            {
                inputValues.Add(fuzzySystem.InputByName(inputVariables[i].NameOfVariable), Convert.ToDouble(inputVariables[i].ValueOfVariable));
            }
            
            FuzzyVariable outputResult = fuzzySystem.OutputByName("output");

            Dictionary<FuzzyVariable, Double> result = fuzzySystem.Calculate(inputValues);
            

            resultTextBox.Text = result[outputResult].ToString("f4");*/
            #endregion

            resultTextBox.Text = "";
            removeIntersectionsFromPlots();

            if (isEmptyField())
            {
                MessageBox.Show("Any field can't be empty");
                return;
            }

            Dictionary<CharacteristicObject, Double> activationValues = new Dictionary<CharacteristicObject, Double>();

            List<Double> endMfValue = new List<Double>();
            for (int i = 0; i < objectList.Count; i++)
            {
                Double criterionMfValue = 1.0;
                for (int j = 0; j < objectList[0].Size(); j++)
                {
                    String criterionName = objectList[i].names[j];
                    Double criterionValue = Convert.ToDouble(objectList[i].values[j]);
                    Double inputX = Convert.ToDouble(inputVariables[j].ValueOfVariable);
                    int indexOfCriterion = criteria[criterionName].IndexOf(criterionValue);

                    Double criterionMin = criteria[criterionName].Min();
                    Double criterionMax = criteria[criterionName].Max();

                    if (inputX < criterionMin || inputX > criterionMax)
                    {
                        MessageBox.Show("Input value for " + criterionName + "(" + inputX + ") is out of domain (" + criterionMin + " - " + criterionMax + ")");
                        return;
                    }

                    Double currentValue = msFunctions[criterionName][indexOfCriterion].getValue(inputX);

                    plots[criterionName].addIntersections(inputX, currentValue);
                    

                    criterionMfValue = criterionMfValue * currentValue;
                }
                endMfValue.Add(criterionMfValue = criterionMfValue * objectList[i].Preference);
            }
            resultTextBox.Text = Math.Round(endMfValue.Sum(), 4).ToString();


        }

        private void removeIntersectionsFromPlots()
        {
            foreach (Plot plot in plots.Values)
            {
                plot.removeIntersections();
            }
        }

        private Dictionary<String, List<TriangularMembershipFunction>> genetareMembershipFunctions(Dictionary<String, List<Double>> criteria)
        {
            Dictionary<String, List<TriangularMembershipFunction>> msFunctions = new Dictionary<String, List<TriangularMembershipFunction>>();

            foreach (String name in criteria.Keys)
            {
                List<TriangularMembershipFunction> functions = new List<TriangularMembershipFunction>();

                for (int i = 0; i < criteria[name].Count; i++)
                {
                    Double x1 = 0.0;
                    Double x2 = 0.0;
                    Double x3 = 0.0;

                    x2 = criteria[name][i];

                    if (i == 0)
                    {
                        x1 = x2;
                    }
                    else
                    {
                        x1 = criteria[name][i - 1];
                    }

                    if (i + 1 == criteria[name].Count)
                    {
                        x3 = x2;
                    }
                    else
                    {
                        x3 = criteria[name][i + 1];
                    }
                    functions.Add(new TriangularMembershipFunction(x1, x2, x3));
                }
                msFunctions.Add(name, functions);
            }
            return msFunctions;
        }

        private Dictionary<string, List<double>> getCriteriaFromObjectList()
        {
            Dictionary<String, List<Double>> criteria;
            criteria = new Dictionary<string, List<Double>>();
            for (int i = 0; i < objectList[0].Size(); i++)
            {
                List<Double> criterionValues = new List<Double>();
                for (int j = 0; j < objectList.Count; j++)
                {
                    if (criterionValues.Count == 0)
                    {
                        criterionValues.Add(Convert.ToDouble(objectList[j].values[i]));
                    }
                    else if (!criterionValues.Contains(Convert.ToDouble(objectList[j].values[i])))
                    {
                        criterionValues.Add(Convert.ToDouble(objectList[j].values[i]));
                    }
                }
                criterionValues.Sort();
                criteria.Add(objectList[0].names[i], criterionValues);
            }
            return criteria;
        }

        private Boolean isEmptyField()
        {
            for (int i = 0; i < inputVariables.Count; i++)
            {
                if (inputVariables[i].ValueOfVariable == "")
                {
                    return true;
                }
            }
            return false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm form = new StartForm();
            form.ShowDialog();
            this.Close();
        }

        #region Old functions
        /*private void generateFuzzySystem()
        {
            fuzzySystem = new MamdaniFuzzySystem();
            fuzzySystem.AggregationMethod = AI.Fuzzy.Library.AggregationMethod.Sum;
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
                List<String> values = new List<String>();
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
                        x3 = 1000000.0;
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
                String ruleString = "if ";
                for (int j = 0; j < inputVariables.Count(); j++)
                {                   
                    ruleString += "(" + objectList[0].names[j] + " is " + objectList[i].values[j].ToString() + ")";
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
        }*/
        #endregion
    }
}
