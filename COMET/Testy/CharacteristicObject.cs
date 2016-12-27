using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMET.Testy
{
    class CharacteristicObject
    {
        Dictionary<String, IFuzzyNumber> criteria = null;
        Int16 size = 0;
        Double preference;
        Decimal rankPoints = 0;
        
        public CharacteristicObject(Int16 Size)
        {
            this.size = Size;
        }

        public Double Preference
        {
            get
            {
                return this.preference;
            }
            set
            {
                this.preference = value;
            }
        }

        public Decimal RankPoints
        {
            get
            {
                return this.rankPoints;
            }
            set
            {
                this.rankPoints = value;
            }
        }


        public void addCriterion(String Name, IFuzzyNumber Number)
        {
            if (this.criteria == null || size > 0)
            {
                this.criteria = new Dictionary<string,IFuzzyNumber>(this.size);
            }
            criteria.Add(Name, Number);
        }
    }
}
