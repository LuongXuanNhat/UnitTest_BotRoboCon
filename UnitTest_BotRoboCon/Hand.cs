using System.Drawing;

namespace UnitTest_BotRoboCon
{

    public class Hand : CommonProperty
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Hand()
        {
            Fingers = new List<Finger>();
        }

        public List<Finger> Fingers { get; set; }

        public bool IsHasFinger()
        {
            return this.Fingers.Any();
        }

        public bool Move(double x, double y)
        {
            this.X = x;
            this.Y = y;
            return IsMoved(x, y);
        }

        private bool IsMoved(double x, double y)
        {
            return (this.X == x && this.Y == y) ? true : false;
        }
    }
}