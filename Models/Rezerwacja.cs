using System;
using System.Collections.Generic;

namespace fil_sys.Models
{
    class Rezerwacja
    {
        public static Dictionary<int, MiejsceSiedzace> rezerwacjaDict = new Dictionary<int, MiejsceSiedzace>();

        static int id = 1;

        public Rezerwacja(MiejsceSiedzace miejsceSiedzace)
        {
            bool isFound = false;
            foreach (MiejsceSiedzace msc in rezerwacjaDict.Values)
            {
                if (miejsceSiedzace.getCompared().Equals(msc.getCompared()))
                {
                    isFound = true;
                }
            }

            if (!isFound)
            {
                rezerwacjaDict.Add(id, miejsceSiedzace);
                id++;
            }
            else
            {
                throw new Exception("Miejsce juz jest zarezerwowane!");
            }
        }

        public void removeReservation(int id)
        {
            if (rezerwacjaDict.ContainsKey(id))
            {
                rezerwacjaDict.Remove(id);
            }
            else
            {
                throw new Exception("Nie ma rezerwacji o takim id!");
            }
        }
    }
}
