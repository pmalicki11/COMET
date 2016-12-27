using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMET.Testy
{
    public class Judge
    {
        List<CharacteristicObject> listOfObjects;
        Double[,] MEJ;
        Double[] SJ;

        Judge(List<CharacteristicObject> ListOfObjects)
        {
            this.listOfObjects = ListOfObjects;
            this.MEJ = new Double[listOfObjects.Count, listOfObjects.Count];
            this.SJ = new Double[listOfObjects.Count];
        }


        

    }
}
