using System;
using System.Collections.Generic;
using System.Text.Json;

namespace FinalPaint.Classes
{
    public class MyJsonSerializer
    { 
        string Serialize_(List<Figure> figures)
        {
            string json = JsonSerializer.Serialize(figures);
            return json;
        }
        List<Figure> Deserilize_(string json)
        {
            List<Figure> figures = new List<Figure>();
            figures = JsonSerializer.Deserialize<List<Figure>>(json);
            return figures;
        }
    }
}
