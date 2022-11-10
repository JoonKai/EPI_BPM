using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Documents;

namespace HellsysLibrary.Helpers
{
    public class JsonHelper
    {
        public string SaveToJsonFile(List<string> list, string jsonFileName)
        {
            string jsonString = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(jsonFileName, jsonString);

            return jsonString;
        }
        //public string UsingJavaScriptSerialize(string JsonFileName)
        //{
        //    JavaScriptSerializer jSer = new JavaScriptSerializer();
        //    string json = JsonConvert.DeserializeObject<(JsonFileName);
        //    return jSer.Serialize(json);
        //}
        /// <summary>
        /// JsonFile을 열어서 저장된 Json 항목을 가져온다.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonFileName"></param>
        /// <returns></returns>
        public List<T> GetJsonFileList<T>(string jsonFileName)
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
