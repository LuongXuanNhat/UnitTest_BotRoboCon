using System.Drawing;

namespace UnitTest_BotRoboCon
{
    public class Face : CommonProperty
    {
        public Face() {
            Mouth = new Mouth();
            Eyes = new List<Eye>();
        }

        public Mouth Mouth { get; set; }
        public List<Eye> Eyes { get; set; }

        public bool IsHasMouth()
        {
            return Mouth != null;
        }

        public bool IsHasEye()
        {
            foreach (var item in Eyes)
            {
                if (!item.IsHasEye())
                {
                    return false;
                }
            }
            return true;
        }

       
    }
}