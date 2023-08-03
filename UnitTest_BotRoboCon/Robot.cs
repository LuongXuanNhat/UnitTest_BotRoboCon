using System.Linq;
namespace UnitTest_BotRoboCon
{
    internal class Robot
    {
        public Robot()
        {
            head = new Head();
            body = new Body();
            foots = new List<Foot>() { 
                new Foot() { Color = "black", Type = "left" }, 
                new Foot() { Color = "black", Type = "right" } };
            hands = new List<Hand>()
            {
                new Hand()
                {
                    Type = "left"
                },
                new Hand()
                {
                    Type = "right"
                }
            };            
        }

        public Robot(Head head)
        {
            this.head = head;
        }

        public Robot(Head head, Body body, List<Foot> foots, List<Hand> hands)
        {
            this.body = body;
            this.foots = foots;
            this.hands = hands;
            this.head = head;
        }

        public Head head { get;  set; }
        public Body body { get;  set; }
        public List<Foot> foots { get;  set; }
        public List<Hand> hands { get; internal set; }

        public bool IsHasHead()
        {
            return this.head != null;
        }

        public bool IsHasBody()
        {
            return this.body != null;
        }

        public bool IsHasHand()
        {
            return (this.hands != null);
        }

        public bool IsHasFoot()
        {
            return (this.foots != null);
        }

        public bool IsHasFace()
        {
            return this.head.IsHasFace();
        }

        public bool IsHasMouth()
        {
            return this.head.Face.IsHasMouth();
        }

        public bool IsHasEye()
        {
            return this.head.Face.IsHasEye();
        }

        public bool IsHasNeck()
        {
            return this.body.IsHasNeck();
        }

        public bool IsHasChest()
        {
            return this.body.IsHasChest();
        }

        public bool IsHasWaist()
        {
            return this.body.IsHasWaist();
        }

        public bool IsHasFinger()
        {
            foreach (var item in hands)
            {
                if (!item.IsHasFinger())
                {
                    return false;
                } ;
            }
            return true;
        }

        public bool IsHasToe()
        {
            foreach (var item in foots)
            {
                if (!item.IsHasToe())
                {
                    return false;
                };
            }
            return true;
        }

        public bool IsHasFeet()
        {
            foreach (var item in foots)
            {
                if (!item.IsHasFeet())
                {
                    return false;
                };
            }
            return true;
        }

        public bool MoveHand(double x, double y, string type)
        {
            this.head.Face.Mouth.Speak();

            //  
           return type is null ? this.MoveAllHand(x, y)
                          : this.hands.FirstOrDefault(x => x.Type.Equals(type)).Move(x, y);

        }

        public bool MoveAllHand(double x, double y)
        {
            bool allMoved = this.hands.All(hand => hand.Move(x, y));
            return allMoved is true ? true : false;
        }

        public void MoveFoot(double x, double y)
        {
            this.foots
            .ForEach(foot => foot.Move(x, y)) ;
            
            this.hands
            .ForEach(hand => hand.Move(x, y)) ;

            this.head.Ears
            .ForEach(ear => ear.TurnOnLight());

            //foreach (var item in this.foots)
            //{
            //  //  item.Move(x, y);

            //    var type = item.Type;
            //    this.head.GetTypeEar(type).TurnOnLight();
            //    GetTypeHand(type).Move(x,y);
            //}
        }

        public Hand GetTypeHand(string type)
        {
            return this.hands.FirstOrDefault(x => x.Type.Equals(type));
        }
         public Foot GetTypeFoot(string type)
        {
            return this.foots.FirstOrDefault(x => x.Type.Equals(type));
        }

       
    }
}