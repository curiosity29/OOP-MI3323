using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Json<T>
    {
        public static void Read(string file, ref T obj)
        {
            string json = File.ReadAllText(file);
            obj = JsonConvert.DeserializeObject<T>(json);
        }
        public static void Write(string filename, T obj)
        {
            string jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(filename, jsonString);
        }
    }
}
