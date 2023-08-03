using System.Drawing;

namespace UnitTest_BotRoboCon
{
    public class Eye : CommonProperty
    {
        
        public Eye() { 
        
        }

        public void OpenEye()
        {
            this.Type = "Open";
        }

        public bool IsHasOpen()
        {
            return this.Type.Equals("Open");
        }

        public bool IsHasEye()
        {
            return this != null;
        }
    }
}