namespace UnitTest_BotRoboCon
{
    public class Ear : CommonProperty
    {
        public Ear()
        {
        }

        public void TurnOnLight()
        {
            this.Color = "red";
        }

        public bool IsTurnOnLight()
        {
            return this.Color == "red";
        }
    }
}