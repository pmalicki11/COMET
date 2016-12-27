using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMET.Testy
{
    class TriangularFuzzyNumber : IFuzzyNumber
    {
        String name;
        Double x1;
        Double x2;
        Double x3;

        public TriangularFuzzyNumber(String Name, Double X1, Double X2, Double X3)
        {
            this.name = Name;
            this.x1 = X1;
            this.x2 = X2;
            this.x3 = X3;
        }

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

        public Double getMembershipValueFor(Double x)
        {
            if (x < x1 || x > x3)
            {
                return 0.0;
            }
            else if (x == x2)
            {
                return 1.0;
            }
            else if (x < x2)
            {
                return 1-  (x2 - x) / (x2 - x1);
            }
            else
            {
                return (x3 - x) / (x3 - x2);
            }
        }
    }
}
