using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMET
{
    public class CharacteristicObject
    {
        public String[] names;
        public String[] values;
        private int size;
        private Double preference;

        public CharacteristicObject(int numOfCriteria)
        {
            size = numOfCriteria;
            generateArrays();
        }

        private void generateArrays()
        {
            names = new String[size];
            values = new String[size];
        }

        public void setObjectValues(int position, String name, String value)
        {
            names[position] = name;
            values[position] = value;
        }

        public Double Preference 
        {
            get
            {
                return preference;
            }
            set
            {
                preference = value;
            }
        }

        public int Size()
        {
            return size;
        }
        
        public override String ToString()
        {
            String res = "";
            for (int i = 0; i < size; i++)
            {
                res += names[i] + " - " + values[i] + "\n";
            }
            return res;
        }
    }
}
