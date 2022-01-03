using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Web.Script.Serialization;

namespace Light_Controller_1._0
{
    public class Preset
    {
        public int colorSpeed;
        public int brightness;
        public ColorHolder[][] colors;
        public bool fadeIn;
        public bool fadeOut;
        public bool barSync;
        public string name;
        public int presetIndex = -1;

        public static readonly string filename = Path.GetDirectoryName
            (Assembly.GetEntryAssembly().Location) + "\\programData.json";

        public void Save()
        {
            List<Preset> list = GetLocalPresets();
            if(presetIndex == - 1) presetIndex = list[list.Count - 1].presetIndex + 1;
            list.Insert(presetIndex, this);
            string jsonString = new JavaScriptSerializer().Serialize(list);
            Console.WriteLine(jsonString);
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, jsonString);
            }
        }

        public void Delete()
        {
            List<Preset> list = GetLocalPresets();
            if (list[presetIndex].name.Equals(name)) list.RemoveAt(presetIndex);
            string jsonString = new JavaScriptSerializer().Serialize(list);
            Console.WriteLine(list.Contains(this));
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
            for (int i = 0; i < list.Count; i++) list[i].presetIndex = i;
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

        public Preset Clone()
        {
            Preset preset = new Preset();
            preset.barSync = barSync;
            preset.colors = colors;
            preset.brightness = brightness;
            preset.colorSpeed = colorSpeed;
            preset.fadeIn = fadeIn;
            preset.fadeOut = fadeOut;
            preset.name = name;
            return preset;
        }
    }
}
