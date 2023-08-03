namespace UnitTest_BotRoboCon
{
    public class Mouth : CommonProperty
    {
        public Mouth() { }

        public void Speak()
        {
            this.Color = "white";
        }
        public bool IsHasSound()
        {
            return this.Color.Equals("white");
        }
    }
}