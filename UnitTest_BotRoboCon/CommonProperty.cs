using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_BotRoboCon
{
    public class CommonProperty
    {
        public string Shape { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public CommonProperty(string shape, string color, string type, double height, double weight)
        {
            Shape = shape;
            Color = color;
            Type = type;
            Height = height;
            Weight = weight;
        }
        public CommonProperty() { }
   
    }
}
