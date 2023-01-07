using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ShitHappens.FileManagement
{
    public static class GameSaver
    {
        private static string fileName = "save.json";
        public static void Save(Model model)
        {
            string jsonString = JsonSerializer.Serialize(model);
            File.WriteAllText(fileName, jsonString);
        }
        public static Model Load() {
            string jsonString = File.ReadAllText(fileName);
            var model = JsonSerializer.Deserialize<Model>(jsonString)!;
            if(model == null || model.HasNullField()) { throw new Exception("Invalid data"); }
            return model;
        }
    }
}