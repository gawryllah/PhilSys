using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace fil_sys.Models
{
    class Dyrektor : Worker
    {
        public static List<Dyrektor> dyrList = new List<Dyrektor>();

        public static float pensja = 5662.53f * 4;

        public string rodzaj;

        static string path = $"{Program.path}/Dyrektor/";

        public Dyrektor(string pesel, string name, string surName, DateTime dob, string login, string pwd, string address, string phNum, string toe, string rodzaj) : base(pesel, name, surName, dob, login, pwd, address, phNum, toe)
        {
            this.rodzaj = rodzaj;
        }


        public static new void saveToFile()
        {

            System.IO.FileInfo dir = new System.IO.FileInfo(path);
            dir.Directory.Create();

            int id = 0;

            foreach (var obj in dyrList)
            {
                string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                File.WriteAllText($"{path}/Dyrektor{id}.json", json);
                id++;
            }
        }

        public static new void readFromFile()
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.json");

                foreach (var obj in files)
                {

                    Dyrektor? newObj = JsonConvert.DeserializeObject<Dyrektor>(File.ReadAllText(Path.GetFullPath(obj)), new JsonSerializerSettings
                    {
                        ConstructorHandling = ConstructorHandling.Default

                    });

                    dyrList.Add(newObj);
                }
            }

        }

        public void setPensja(Dyrygent dyrygent, float pensja) //ustawia pensje dla obiektu dyrygent
        {
            dyrygent.pensja = pensja;
        }

        public void setPensja(Muzyk muzyk, float pensja) //ustawia pensje dla obiektu muzyk
        {
            muzyk.pensja = pensja;
        }

        public void usunWydarzenie(Aula aula, DateTime dateTime)
        {



            if (Wydarzenie.wystepCalendar.ContainsKey(dateTime))  //spradza czy jest event o takiej dacie
            {
                Wystep wydarzenie = Wydarzenie.wystepCalendar[dateTime]; //jesli jest to pobieramy obiekt przypisany dal danej daty
                aula.wystepList.Remove(wydarzenie); //usuwa sie wystep z listy
                aula.wystepsDate.Remove(dateTime); //usuwa sie date z listy

            }
            else if (Wydarzenie.koncertCalendar.ContainsKey(dateTime))
            {
                Koncert wydarzenie = Wydarzenie.koncertCalendar[dateTime]; //jesli jest to pobieramy obiekt przypisany dal danej daty
                aula.koncertList.Remove(wydarzenie); //usuwa sie koncert z listy
                aula.koncrtsDate.Remove(dateTime); //usuwa sie date z listy
            }



        }
    }
}
