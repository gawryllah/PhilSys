using System;
using System.Collections.Generic;

namespace fil_sys.Models
{
    class Udzial
    {


        public static List<Koncert> listOfKoncerts = new List<Koncert>();

        Dyrygent dyrygent;
        Koncert koncert;


        public Dictionary<Muzyk, Koncert> udzialDict = new Dictionary<Muzyk, Koncert>();

        public Udzial(Dyrygent dyrygent, Koncert koncert)
        {
            this.dyrygent = dyrygent;
            this.koncert = koncert;

            if (listOfKoncerts.Contains(koncert))
            {
                throw new Exception("Juz jest taki koncert!");
            }
            else
            {
                listOfKoncerts.Add(koncert);
            }
        }

        public void addMuzyk(Koncert koncert, Muzyk muzyk)
        {
            if (udzialDict.ContainsKey(muzyk))
            {
                throw new Exception("Ten muzyk juz jest przypisany!");
            }
            else
            {
                udzialDict.Add(muzyk, koncert);
            }
        }

    }
}
