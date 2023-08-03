using System.Drawing;

namespace UnitTest_BotRoboCon
{
    public class Body : CommonProperty
    {
        public Body()
        {
            Neck = new Neck();
            Chest = new Chest();
            Waist = new Waist();
        }

        public Neck Neck { get; set; }
        public Chest Chest { get; set; }
        public Waist Waist { get; set; }

        public bool IsHasNeck()
        {
            return this.Neck != null;
        }

        public bool IsHasChest()
        {
            return (this.Chest != null);
        }

        public bool IsHasWaist()
        {
            return (this.Waist != null);
        }
    }
}