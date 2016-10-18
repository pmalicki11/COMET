using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMET
{
    class TriangularMembershipFunction
    {
        private Double x1;
        private Double x2;
        private Double x3;

        public TriangularMembershipFunction(Double X1, Double X2, Double X3)
        {
            x1 = X1;
            x2 = X2;
            x3 = X3;
        }

        public Double getValue(Double x)
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
                return (x2 - x) / (x2 - x1);
            }
            else
            {
                return (x3 - x) / (x3 - x2);
            }
        }
    }
}
