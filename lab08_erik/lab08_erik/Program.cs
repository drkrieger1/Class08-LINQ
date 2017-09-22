using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace lab08_erik
{
    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Properties
    {
        public string zip { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string address { get; set; }
        public string borough { get; set; }
        public string neighborhood { get; set; }
        public string county { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

    public class RootObject
    {
        public string type { get; set; }
        public List<Feature> features { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"data.json";
            string json = LoadJson(filePath);

            RootObject myCollection = JsonConvert.DeserializeObject<RootObject>(json);

            //Console.WriteLine(json);
            Console.Read();

        } 

        static string LoadJson(string filePath)
        {
            string jsonFile; 

            using (StreamReader sr = File.OpenText(filePath))
            {
                jsonFile = sr.ReadToEnd();
            }

            return jsonFile;
        }  
       

    }
}
