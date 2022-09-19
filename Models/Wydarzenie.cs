using System;
using System.Collections.Generic;

namespace fil_sys.Models
{
    class Wydarzenie
    {

        public static List<DateTime> calendar = new List<DateTime>();

        public static Dictionary<DateTime, Wystep> wystepCalendar = new Dictionary<DateTime, Wystep>();
        public static Dictionary<DateTime, Koncert> koncertCalendar = new Dictionary<DateTime, Koncert>();


        public DateTime data;
        Udzial obsada;
        Organizator organizator;

        public Wydarzenie(DateTime data, Wystep wystep)
        {
            if (calendar.Contains(data))
            {
                throw new Exception("Juz istnieje w danym dniu!");
            }
            else
            {
                calendar.Add(data);
                wystepCalendar.Add(data, wystep);
            }
        }

        public Wydarzenie(DateTime data, Koncert koncert)
        {
            if (calendar.Contains(data))
            {
                throw new Exception("Juz istnieje w danym dniu!");
            }
            else
            {
                calendar.Add(data);
                koncertCalendar.Add(data, koncert);
            }
        }

        public void setObsada(Udzial obsada)
        {
            this.obsada = obsada;
        }

        public void setOrganizator(Organizator organizator)
        {
            this.organizator = organizator;
        }
    }
}
