using System;
using System.Collections.Generic;

namespace fil_sys.Models
{
    class Organizator : Person
    {
        public static List<Organizator> organizatorList = new List<Organizator>();

        string rola;
        public Organizator(string pesel, string name, string surName, DateTime dob, string rola) : base(pesel, name, surName, dob)
        {
            this.rola = rola;
            organizatorList.Add(this);
        }
    }
}
