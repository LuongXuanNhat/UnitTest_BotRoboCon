using System.Drawing;

namespace UnitTest_BotRoboCon
{
    public class Head : CommonProperty
    {
        public Face Face { get;  set; }
        public List<Eye> Eyes { get;  set; }
        public List<Ear> Ears { get;  set; }

        

        public Head()
        {
            Face = new Face();
            Eyes = new List<Eye>() {
                new Eye()
                {
                    Color = "black",
                    Type = "left"
                },
                new Eye()
                {
                    Color = "black",
                    Type = "right"
                }
            };
            Ears = new List<Ear>()
            {
                new Ear()
                {
                    Color = "black",
                    Type = "left"
                },
                new Ear()
                {
                    Color = "black",
                    Type = "right"
                }
        };
          
        }


        public Ear GetTypeEar(string type)
        {
            return this.Ears.FirstOrDefault(x => x.Type.Equals(type));
        }
        public bool IsHasFace()
        {
            return Face != null;
        }

    }
}