using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Documents;

namespace HellsysLibrary.Helpers
{
    public class JsonHelper
    {
        public List<string> GetnerateList(List<string> list)
        {
            var itemList = new List<string>();
            if(list.Count == 0) { return null; }
            else
            {
                foreach (var item in list)
                {
                    itemList.Add(item.ToString());
                }
            }
            
            
            return itemList;
        }
        public string SaveToJsonFIle(List<string> list, string jsonFileName)
        {
            string jsonString = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(jsonFileName, jsonString);

            return jsonString;
        }
        public List<T> LoadedJsonFile<T>(string jsonFileName)
        {
            var list = new List<T>();
            using(StreamReader file = File.OpenText(jsonFileName))
            {
                var serializer = new JsonSerializer();
                list = (List<T>)serializer.Deserialize(file, typeof(List<T>));
            }
            return list;
        }
        public List<T> LoadJson<T>(T item, string jsonFileName)
        {
            if (File.Exists(jsonFileName))
            {
                var list = new List<T>();
                using(StreamReader file= File.OpenText(jsonFileName))
                {
                    var serializer = new JsonSerializer();
                    list = (List<T>)serializer.Deserialize(file, typeof(List<T>));
                }
            }
            return null;
        }
    }
}
