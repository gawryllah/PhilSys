using System;

namespace fil_sys.Models
{
    public abstract class Person
    {

        public string pesel { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public DateTime dob { get; set; }

        protected Person(string pesel, string name, string surName, DateTime dob)
        {
            this.pesel = pesel;
            this.name = name;
            this.surName = surName;
            this.dob = dob;
        }
    }
}
