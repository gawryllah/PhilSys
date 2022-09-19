using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace fil_sys.Models
{
    class Dyrygent : Worker
    {
        public static List<Dyrygent> dyrygentList = new List<Dyrygent>();

        public float pensja;

        static string path = $"{Program.path}/Dyrygent/";

        public Dyrygent(string pesel, string name, string surName, DateTime dob, string login, string pwd, string address, string phNum, string toe, float pensja) : base(pesel, name, surName, dob, login, pwd, address, phNum, toe)
        {
            this.pensja = pensja;
        }

        public static new void saveToFile()
        {

            System.IO.FileInfo dir = new System.IO.FileInfo(path);
            dir.Directory.Create();

            int id = 0;

            foreach (var obj in dyrygentList)
            {
                string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                File.WriteAllText($"{path}/Conductor{id}.json", json);
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

                    Dyrygent? newObj = JsonConvert.DeserializeObject<Dyrygent>(File.ReadAllText(Path.GetFullPath(obj)), new JsonSerializerSettings
                    {
                        ConstructorHandling = ConstructorHandling.Default

                    });

                    dyrygentList.Add(newObj);
                }
            }

        }
    }
}
