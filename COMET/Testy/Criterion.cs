using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMET.Testy
{
    class Criterion
    {
        String name;
        Dictionary<String, IFuzzyNumber> fuzzyNumber;

        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public IFuzzyNumber number(String Name)
        {
            return this.fuzzyNumber[Name];
        }
    }
}
