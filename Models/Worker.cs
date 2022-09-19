using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace fil_sys.Models
{
    class Worker : Person
    {
        public string login { get; set; }
        public string pwd { get; set; }
        public string address { get; set; }
        public string phNum { get; set; }
        public string toe { get; set; }

        public static List<Worker> workerList = new List<Worker>();

        static string path = $"{Program.path}/Worker/";

        public Worker(string pesel, string name, string surName, DateTime dob, string login, string pwd, string address, string phNum, string toe) : base(pesel, name, surName, dob)
        {
            this.login = login;
            this.pwd = pwd;
            this.address = address;
            this.phNum = phNum;
            this.toe = toe;
        }

        public static void addWorkerToList(Worker worker)
        {

            workerList.Add(worker);
        }



        public static void saveToFile()
        {

            System.IO.FileInfo dir = new System.IO.FileInfo(path);
            dir.Directory.Create();

            int id = 0;

            foreach (var worker in workerList)
            {
                string json = JsonConvert.SerializeObject(worker, Formatting.Indented);
                File.WriteAllText($"{path}/Worker{id}.json", json);
                id++;
            }
        }

        public static void readFromFile()
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path, "*.json");

                foreach (var obj in files)
                {

                    Worker? newObj = JsonConvert.DeserializeObject<Worker>(File.ReadAllText(Path.GetFullPath(obj)), new JsonSerializerSettings
                    {
                        ConstructorHandling = ConstructorHandling.Default

                    });

                    workerList.Add(newObj);
                }
            }

        }

    }
}
