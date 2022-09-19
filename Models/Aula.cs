using System;
using System.Collections.Generic;

namespace fil_sys.Models
{
    class Aula
    {
        public static List<Aula> aulaList = new List<Aula>();

        public string nazwa;
        StateHandler.AulaState status;

        int rzedy;
        int sektory;


        public List<Koncert> koncertList = new List<Koncert>();
        public List<Wystep> wystepList = new List<Wystep>();

        public List<DateTime> koncrtsDate = new List<DateTime>();
        public List<DateTime> wystepsDate = new List<DateTime>();


        public List<Rezerwacja> rezerwacjaList = new List<Rezerwacja>();

        public Aula(string nazwa, StateHandler.AulaState status, int rzedy, int sektory)
        {
            this.nazwa = nazwa;
            this.status = status;
            this.rzedy = rzedy;
            this.sektory = sektory;

            aulaList.Add(this);
        }

        public void addRzad()
        {
            rzedy += 1; //dodaje rzad
        }

        public void usunRzad()
        {
            rzedy -= 1; //usuwa rzad
        }

        public void dodajSektor()
        {
            sektory += 1; //dodaje sektor
        }

        public void usunSektor()
        {
            sektory -= 1; //usuwa sektor
        }


        public void addKoncert(DateTime data)
        {

            koncrtsDate.Add(data);  //dodaje date koncertu do listy ktora przechowuje daty
            koncertList.Add(Wydarzenie.koncertCalendar[data]); //dodaje wydarzenie do kalendarza

        }


        public void addWystep(DateTime data)
        {

            wystepsDate.Add(data); //dodaje wystep koncertu do listy ktora przechowuje daty
            wystepList.Add(Wydarzenie.wystepCalendar[data]); //dodaje wydarzenie do kalendarza

        }

        public void addReservation(Rezerwacja rezerwacja)
        {
            rezerwacjaList.Add(rezerwacja); //dodaje rezerwacje do listy
        }

    }
}
