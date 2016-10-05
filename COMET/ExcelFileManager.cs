using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//GNU Lesser GPL lisense library
using ExcelLibrary.SpreadSheet;

namespace COMET
{
    public class ExcelFileManager
    {
        private int dataType;
        public List<CharacteristicObject> objectList;
        public Pair[] pairs;
        public int pairsLeft;
        public double[,] mej;
        private Stream stream;
        private Workbook workbook;
        
        public ExcelFileManager(pairJudgment pj)
        {
            this.objectList = new List<CharacteristicObject>(pj.ListOfObjects);
            this.pairs = pj.Pairs;
            this.pairsLeft = pj.PairsLeft;
            this.mej = pj.Mej;
        }

        public ExcelFileManager(Stream stream)
        {
            this.stream = stream;
        }

        public void saveToFile(String filename)
        {
            //workbook declaration
            Workbook workbook = new Workbook();
            Worksheet characteristicObjectsWorksheet = new Worksheet("Characteristic objects");
            Worksheet pairsWorksheet = new Worksheet("Pairs of judgment");
            Worksheet mejWorksheet = new Worksheet("MEJ matrix");

            //characteristic objects
            prepareSheet(ref characteristicObjectsWorksheet);
            characteristicObjectsWorksheet.Cells[0, 0] = new Cell("Object");
            for (int i = 0; i < objectList[0].Size(); i++)
            {
                characteristicObjectsWorksheet.Cells[0, i + 1] = new Cell(objectList[0].names[i], CellFormat.General);
            }
            if (pairsLeft == 0)
            {
                characteristicObjectsWorksheet.Cells[0, objectList[0].Size() + 1] = new Cell("P");
            }


            for (int i = 1; i <= objectList.Count; i++)
            {
                for (int j = 0; j < objectList[0].Size(); j++)
                {
                    characteristicObjectsWorksheet.Cells[i, 0] = new Cell("O" + i);
                    characteristicObjectsWorksheet.Cells[i, j + 1] = new Cell(objectList[i - 1].values[j], CellFormat.General);
                }
                if (pairsLeft == 0)
                {
                    characteristicObjectsWorksheet.Cells[i, objectList[0].Size() + 1] = new Cell(objectList[i - 1].Preference, CellFormat.General);
                }
            }

            //pairs of indexes of characteristic objects (all)
            prepareSheet(ref pairsWorksheet);
            pairsWorksheet.Cells[0, 0] = new Cell("Pairs left");
            pairsWorksheet.Cells[0, 1] = new Cell(pairsLeft);
            for (int i = 1; i <= pairs.Length; i++)
            {
                pairsWorksheet.Cells[i, 0] = new Cell(pairs[i - 1].left);
                pairsWorksheet.Cells[i, 1] = new Cell(pairs[i - 1].right);
            }

            //SJ matrix
            prepareSheet(ref mejWorksheet);
            for (int i = 0; i < objectList.Count; i++)
            {
                for (int j = 0; j < objectList.Count; j++)
                {
                    mejWorksheet.Cells[i, j] = new Cell(mej[i, j]);
                }
            }

            //add worksheets to workbook and save
            workbook.Worksheets.Add(characteristicObjectsWorksheet);
            workbook.Worksheets.Add(pairsWorksheet);
            workbook.Worksheets.Add(mejWorksheet);
            workbook.Save(filename);
        }

        public bool loadFromFile()
        {
            try
            {
                this.workbook = Workbook.Load(this.stream);

               /* if (workbook.Worksheets[1].Cells[0, 1].StringValue == "0")
                {
                    System.Windows.Forms.MessageBox.Show("File contains completed judgment");
                    return false;
                }*/

                //load characteristic objects
                this.objectList = new List<CharacteristicObject>();

                int row = 1;
                Worksheet characteristicObjectsWorksheet = workbook.Worksheets[0];
                while (!isEmptyCell(characteristicObjectsWorksheet.Cells[row, 0]))
                {
                    this.objectList.Add(new CharacteristicObject(numOfCriteria()));
                    for (int i = 0; i < numOfCriteria(); i++)
                    {
                        this.objectList.Last().names[i] = characteristicObjectsWorksheet.Cells[0, i + 1].ToString();
                        this.objectList.Last().values[i] = characteristicObjectsWorksheet.Cells[row, i + 1].ToString();
                    }
                    if (characteristicObjectsWorksheet.Cells[0, numOfCriteria() + 1].StringValue == "P")
                    {
                        this.objectList.Last().Preference = Convert.ToDouble(characteristicObjectsWorksheet.Cells[row, numOfCriteria() + 1].Value);
                    }
                    row++;
                }

                //load pairs of judgment
                row = 1;
                Worksheet pairsWorksheet = workbook.Worksheets[1];
                this.pairsLeft = Convert.ToInt32(pairsWorksheet.Cells[0, 1].Value);
                pairs = new Pair[numOfPairs()];
                while (!isEmptyCell(pairsWorksheet.Cells[row, 0]))
                {
                    pairs[row - 1].left = Convert.ToInt32(pairsWorksheet.Cells[row, 0].Value);
                    pairs[row - 1].right = Convert.ToInt32(pairsWorksheet.Cells[row, 1].Value);
                    row++;
                }

                //load MEJ
                row = 0;
                int column = 0;
                Worksheet mejWorksheet = workbook.Worksheets[2];
                this.mej = new Double[objectList.Count, objectList.Count];
                while (!isEmptyCell(mejWorksheet.Cells[row, column]))
                {
                    while (!isEmptyCell(mejWorksheet.Cells[row, column]))
                    {
                        this.mej[row, column] = Convert.ToDouble(mejWorksheet.Cells[row, column].Value);
                        column++;
                    }
                    column = 0;
                    row++;
                }
                return true;
            }
            catch(Exception)
            {
                System.Windows.Forms.MessageBox.Show("Bad file format");
                return false;
            }
        }

        private void prepareSheet(ref Worksheet ws)
        {
            //method to create some blank cells to prevent file opening error
            //if file is too small (probably less than 7kB) Excel treats it as corrupted
            int row = 1;
            int col;
            for (int i = 0; i < 150; i++)
            {
                col = 1;
                for (int j = 0; j < 10; j++)
                {
                    ws.Cells[row, col] = new Cell(" ");
                    col++;
                }
                row++;
            }
        }

        private int numOfCriteria()
        {
            int column = 1;
            while (workbook.Worksheets[0].Cells[0, column].StringValue != "" && workbook.Worksheets[0].Cells[0, column].StringValue != "P")
            {
                column++;
            }
            return column - 1;
        }

        private int numOfPairs()
        {
            int row = 1;
            while (workbook.Worksheets[1].Cells[row, 0].StringValue != "")
            {
                row++;
            }
            return row - 1;
        }

        private bool isEmptyCell(Cell cell)
        {
            if (cell.StringValue == "" || cell.StringValue == " ")
            {
                return true;
            }
            return false;
        }
    }
}