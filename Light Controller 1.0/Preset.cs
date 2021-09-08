using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Web.Script.Serialization;

namespace Light_Controller_1._0
{
    class Preset
    {
        public int colorSpeed;
        public int brightness;
        public Color[][] colors;
        public bool fadeIn;
        public bool fadeOut;
        public bool barSync;
        public string name;

        public static readonly string filename = Path.GetDirectoryName
            (Assembly.GetEntryAssembly().Location) + "\\programData.json";

        public void Save()
        {
            List<Preset> list = GetLocalPresets();
            list.Add(this);
            string jsonString = new JavaScriptSerializer().Serialize(list);
            Console.WriteLine(jsonString);
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, jsonString);
            }
        }

        public static List<Preset> GetLocalPresets()
        {
            List<Preset> list = new List<Preset>();
            if (File.Exists(filename))
            {
                string initialJson = ClearJsonText(File.ReadAllText(filename));
                Console.WriteLine("json:" + initialJson + "\n");
                list = new JavaScriptSerializer().Deserialize<List<Preset>>(initialJson);
            }
            return list;
        }

        private static string ClearJsonText(string jsonString)
        {
            jsonString = jsonString.Remove(0, 1);
            jsonString = jsonString.Remove(jsonString.Length - 1, 1);
            while (jsonString.Contains("\\"))
            {
                int index = jsonString.IndexOf("\\");
                jsonString = jsonString.Remove(index, 1);
            }
            return jsonString;
        }
    }
}
