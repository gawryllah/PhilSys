using fil_sys.Models;
using System;
using System.Windows.Forms;

namespace fil_sys
{
    static class Program
    {

        public static string path = @"./../../../Output/";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Worker.readFromFile();
            Muzyk.readFromFile();
            Dyrygent.readFromFile();
            Dyrektor.readFromFile();


            Aula aula1 = new Aula("Aula1", StateHandler.AulaState.ZAREZERWOWANE, 50, 5);
            Aula aula2 = new Aula("Aula2", StateHandler.AulaState.ZAREZERWOWANE, 30, 10);
            Aula aula3 = new Aula("Aula3", StateHandler.AulaState.ZAREZERWOWANE, 25, 15);

            Organizator organizator1 = new Organizator("000123", "Jan", "Matejko", new DateTime(1982, 02, 10), "Patron");

            Wydarzenie w1 = new Wydarzenie(new DateTime(2022, 06, 25), new Koncert("Koncert muzyki filmowej - Jaœ Fasola", StateHandler.EventState.PRZED));
            Wydarzenie w2 = new Wydarzenie(new DateTime(2022, 06, 20), new Wystep("StandUP", "komedia", StateHandler.EventState.PRZED));
            Wydarzenie w3 = new Wydarzenie(new DateTime(2022, 07, 10), new Koncert("Johny Bravo muzyka", StateHandler.EventState.PRZED));

            w1.setOrganizator(organizator1);

            MiejsceSiedzace ms1 = new MiejsceSiedzace(1, 1, 1);
            MiejsceSiedzace ms2 = new MiejsceSiedzace(1, 1, 2);

            Rezerwacja rez1 = new Rezerwacja(ms1);
            //Rezerwacja rez2 = new Rezerwacja(ms1);
            Rezerwacja rez2 = new Rezerwacja(ms2);

            //Udzial ud1 = new Udzial(Dyrygent.dyrygentList[0], Wydarzenie.koncertCalendar[new DateTime(2022, 06, 25)]);

            //Dyrygent dyrygentZmuzyka = new Dyrygent(Muzyk.muzykList[1], 2000);

            //Udzial ud2 = new Udzial(dyrygentZmuzyka, Wydarzenie.koncertCalendar[new DateTime(2022, 07, 10)]);

            //ud1.addMuzyk(Wydarzenie.koncertCalendar[new DateTime(2022, 06, 25)], Muzyk.muzykList[0]);
            //ud1.addMuzyk(Wydarzenie.koncertCalendar[new DateTime(2022, 06, 25)], Muzyk.muzykList[0]);

            aula1.addKoncert(new DateTime(2022, 06, 25));
            aula2.addWystep(new DateTime(2022, 06, 20));
            aula3.addKoncert(new DateTime(2022, 07, 10));

            //Dyrektor.dyrList[0].usunWydarzenie(aula1 ,new DateTime(2022, 06, 25));


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



        }
    }
}
