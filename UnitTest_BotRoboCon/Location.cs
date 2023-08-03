using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_BotRoboCon
{
    public class Location
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Location()
        {
            X = 0;
            Y = 0;
        }

        public Location(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
