using System.Drawing;

namespace UnitTest_BotRoboCon
{
    internal class Foot : CommonProperty
    {
        public Foot()
        {
            Feet = new Feet();
            Toes = new List<Toe>();
        }
        public double X { get; set; }
        public double Y { get; set; }
        public Feet Feet { get; set; }
        public List<Toe> Toes { get; set; }

        public bool IsHasFeet()
        {
            return Feet != null;
        }

        public bool IsHasToe()
        {
            return this.Toes.Any();
        }

        public Location Move(double x, double y)
        {
            this.X = x;
            this.Y = y;
            return new Location(this.X, this.Y);
        }
    }
}