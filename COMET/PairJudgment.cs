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
    public struct Pair
    {
        public int left;
        public int right;
    }

    public partial class pairJudgment : UserControl
    {
        private List<CharacteristicObject> listOfObjects;
        private int pairsLeft;
        private Double[,] mej;
        private Double[] sj;
        private Double[] objectPreference;
        private bool judgmentComplete = false;
        private Pair[] pairs;
        private int pairIndex = 0;
        private SaveFileDialog saveFileDialog;

        public pairJudgment(ref List<CharacteristicObject> list)
        {
            InitializeComponent();
            listOfObjects = list;
            pairsLeft = ((listOfObjects.Count * (listOfObjects.Count - 1)) / 2);
            totalObjectsLabel.Text = "Total objects:\n" + listOfObjects.Count;
            mej = new Double[listOfObjects.Count, listOfObjects.Count];
            sj = new Double[listOfObjects.Count];
            Array.Clear(mej, 0, mej.Length);
            Array.Clear(sj, 0, sj.Length);
            genCombinations();
            getNextPair();
        }

        public pairJudgment(ExcelFileManager loader)
        {
            InitializeComponent();
            this.listOfObjects = loader.objectList;
            this.pairs = loader.pairs;
            this.pairsLeft = loader.pairsLeft;
            this.mej = loader.mej;
            this.pairIndex = pairs.Length - pairsLeft;
            totalObjectsLabel.Text = "Total objects:\n" + listOfObjects.Count;
            sj = new Double[listOfObjects.Count];
            Array.Clear(sj, 0, sj.Length);
            getNextPair();
        }

        private void getNextPair()
        {
            if (pairsLeft > 0)
            {
                //throw next pair to boxes
                leftText.Text = listOfObjects[pairs[pairIndex].left].ToString();
                rightText.Text = listOfObjects[pairs[pairIndex].right].ToString();
                pairsLeftLabel.Text = "Pairs left:\n" + pairsLeft;
            }
            else
            {
                //complete judgment
                judgmentComplete = true;
                clearControls();
                generateSj();
                genPreferenceValues();
                assignPreferencesToObjects();
            }
        }

        private void genCombinations()
        {
            pairs = new Pair[pairsLeft];
            int pairIndex = 0;

            for (int i = 0; i < listOfObjects.Count; i++)
            {
                for (int j = (i + 1); j < listOfObjects.Count; j++)
                {
                    pairs[pairIndex].left = i;
                    pairs[pairIndex].right = j;
                    pairIndex++;
                }
            }
            shufflePairs();
        }

        private void shufflePairs()
        {
            Random r = new Random();
            for (int i = pairs.Length; i> 0; i--)
            {
                int j = r.Next(i);
                Pair k = pairs[j];
                pairs[j] = pairs[i - 1];
                pairs[i - 1] = k;
            }
        }

        private void clearControls()
        {
            leftGroupBox.Visible = false;
            rightGroupBox.Visible = false;
            leftButton.Visible = false;
            rightButton.Visible = false;
            skipButton.Visible = false;
            pairsLeftLabel.Visible = false;
            totalObjectsLabel.Visible = false;
            saveToFile.Visible = false;
            judgmentCompleteLabel.Visible = true;
        }

        private void generateSj()
        {
            if (judgmentComplete)
            {
                for (int i = 0; i < sj.Length; i++)
                {
                    for (int j = 0; j < listOfObjects.Count; j++)
                    {
                        sj[i] += mej[i, j];     //sum values along row   
                    }
                    Console.WriteLine("SJ[" + i + "] = " + sj[i]);
                }
            }
            Console.WriteLine("Unique SJ values = " + sj.Distinct().ToArray().Length);
        }

        private void genPreferenceValues()
        {
            int k = sj.Distinct().ToArray().Length; //number of unique values in SJ
            objectPreference = new Double[sj.Length];     //same dims as SJ
            Array.Clear(objectPreference, 0, objectPreference.Length);            //for safety
            int ind = 0;                            
            for (int i = 1; i <= k; i++)
            {
                ind = sj.ToList().IndexOf(sj.Max());    //index of max val in SJ
                if (sj[ind] == 0)
                {
                    continue;
                }
                objectPreference[ind] = Math.Truncate(((Double)k - (Double)i) / ((Double)k - 1.0) * 10000) / 10000; //calc preference value and round to 4 digits
                Console.WriteLine("P[" + ind + "] = " + objectPreference[ind]);
                sj[ind] = 0.0;                          //this ind of SJ is done
            }   //next
        }

        private void assignPreferencesToObjects()
        {
            for (int i = 0; i < listOfObjects.Count; i++)
            {
                listOfObjects[i].Preference = objectPreference[i];
            }
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            //1 point for left
            mej[pairs[pairIndex].left, pairs[pairIndex].right]++;
            pairsLeft--;
            pairIndex++;
            getNextPair();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            //1 point for right
            mej[pairs[pairIndex].right, pairs[pairIndex].left]++;
            pairsLeft--;
            pairIndex++;
            getNextPair();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            //0.5 points for both left and right
            mej[pairs[pairIndex].left, pairs[pairIndex].right] += 0.5;
            mej[pairs[pairIndex].right, pairs[pairIndex].left] += 0.5;
            pairsLeft--;
            pairIndex++;
            getNextPair();
        }

        private void saveToFile_Click(object sender, EventArgs e)
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
            ExcelFileManager fm = new ExcelFileManager(this);
            try
            {
                fm.saveToFile(saveFileDialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\nProgram restart needed");
            }
        }

        public Boolean JudgmentCompleted
        {
            get
            {
                return judgmentComplete;
            }
        }

        public List<CharacteristicObject> ListOfObjects
        {
            get
            {
                return listOfObjects;
            }
        }

        public Pair[] Pairs
        {
            get
            {
                return pairs;
            }
        }
        
        public int PairsLeft
        {
            get
            {
                return pairsLeft;
            }
        }

        public Double[,] Mej
        {
            get
            {
                return mej;
            }
        }
    }
}
