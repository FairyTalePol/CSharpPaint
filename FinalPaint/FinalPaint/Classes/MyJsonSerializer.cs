using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace FinalPaint.Classes
{
    public static class MyJsonSerializer
    { 

        public static string Serialize_(List<FigureWithParametrs> figures, string path)
        {
            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
            serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All;
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
           
        
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, figures);
                // {"ExpiryDate":new Date(1230375600000),"Price":0}
            }
            return "";

        }
        public static List<FigureWithParametrs> DeserilizeByPath_(string path)
        {
            //List<FigureWithParametrs> figures = new List<FigureWithParametrs>();
            //figures = JsonConvert.DeserializeObject<List<FigureWithParametrs>>(json);
            //return figures;
            List<FigureWithParametrs> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FigureWithParametrs>>(File.ReadAllText(path), new Newtonsoft.Json.JsonSerializerSettings
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
            });
            return list;
        }

        public static List<FigureWithParametrs> Deserilize_(string json)
        {
            //List<FigureWithParametrs> figures = new List<FigureWithParametrs>();
            //figures = JsonConvert.DeserializeObject<List<FigureWithParametrs>>(json);
            //return figures;
            List<FigureWithParametrs> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<FigureWithParametrs>>(json, new Newtonsoft.Json.JsonSerializerSettings
            {
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
            });
            return list;
        }

        public static string SerializeToString(List<FigureWithParametrs> figures)
        {
            Newtonsoft.Json.JsonSerializer serializer = new Newtonsoft.Json.JsonSerializer();
            serializer.Converters.Add(new Newtonsoft.Json.Converters.JavaScriptDateTimeConverter());
            serializer.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            serializer.TypeNameHandling = Newtonsoft.Json.TypeNameHandling.All;
            serializer.Formatting = Newtonsoft.Json.Formatting.Indented;

            TextWriter s = new StringWriter();
            serializer.Serialize(s, figures);
            return s.ToString();

        }
    }
}
