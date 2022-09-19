using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace fil_sys.Models
{
    class Muzyk : Worker
    {
        public static List<Muzyk> muzykList = new List<Muzyk>();

        public float pensja { get; set; }
        public string rodzaj { get; set; }
        List<string> instrumentList = new List<string>();
        static string path = $"{Program.path}/Muzyk/";

        public Muzyk(string pesel, string name, string surName, DateTime dob, string login, string pwd, string address, string phNum, string toe, float pensja, string rodzaj, string instrument) : base(pesel, name, surName, dob, login, pwd, address, phNum, toe)
        {
            this.pensja = pensja;
            this.rodzaj = rodzaj;
            instrumentList.Add(instrument);
        }

        public void addInstrument(string instrument)
        {
            instrumentList.Add(instrument);
        }

        public List<string> getInstrumentList()
        {
            return instrumentList;
        }



        public static new void saveToFile()
        {

            System.IO.FileInfo dir = new System.IO.FileInfo(path);
            dir.Directory.Create();

            int id = 0;

            foreach (var muzyk in muzykList)
            {
                string json = JsonConvert.SerializeObject(muzyk, Formatting.Indented);
                File.WriteAllText($"{path}/Muzyk{id}.json", json);
                id++;
            }
        }

        public static new void readFromFile()
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.json");

                foreach (var muzyk in files)
                {

                    Muzyk? newObj = JsonConvert.DeserializeObject<Muzyk>(File.ReadAllText(Path.GetFullPath(muzyk)), new JsonSerializerSettings
                    {
                        ConstructorHandling = ConstructorHandling.Default

                    });

                    muzykList.Add(newObj);
                }
            }

        }

        public static List<Muzyk> getMuzykByType(string type) //zwaraca liste muzykow po typie typu 'Jazz' 'Klasyczny' '
        {
            List<Muzyk> list = new List<Muzyk>();

            foreach (Muzyk muzyk in muzykList)
            {
                if (muzyk.rodzaj.Equals(type))
                {
                    list.Add(muzyk);
                }
            }

            return list;

        }

    }
}
