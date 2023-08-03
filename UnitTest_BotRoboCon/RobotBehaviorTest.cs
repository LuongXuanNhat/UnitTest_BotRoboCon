using System.Reflection.Metadata;

namespace UnitTest_BotRoboCon
{
    [TestClass]
    public class RobotBehaviorTest
    {
        //      28/06/2023
        [TestMethod]
        public void Check_Light_Ear_Turn_On_Test()
        {
            var leftEar = new Ear()
            {
                Color = "black",
                Type = "left"
            };
            leftEar.TurnOnLight();
            Assert.AreEqual(true, leftEar.IsTurnOnLight());
        }
        [TestMethod]
        public void Check_robot_Move_Left_Hand_Test()
        {
            //var head = new Head();
            //var body = new Body();
            //var foots = new List<Foot>();
            //var leftHand = new Hand()
            //{
            //    Type = "left",
            //};
            //var hands = new List<Hand>();
            //hands.Add(leftHand);


            //var robot = new Robot(head, body, foots, hands);
            //double x = 3.4;
            //double y = -7.6;
            //var result = robot.MoveHand(x, y);

            //Assert.AreEqual(x, result.X);
            //Assert.AreEqual(y, result.Y);
        }
        [TestMethod]
        public void Check_robot_Left_Ear_Light_On_When_Left_Hand_Move()
        {
            //var head = new Head();
            //var body = new Body();
            //var foots = new List<Foot>();
            //var leftHand = new Hand()
            //{
            //    Type = "left",
            //};
            //var hands = new List<Hand>();
            //hands.Add(leftHand);


            //var robot = new Robot(head, body, foots, hands);
            //double x = 3.4;
            //double y = -7.6;
            //var result = robot.MoveHand(x, y);

            //var left_ear = robot.head.Ears.FirstOrDefault(x => x.Type.Equals("left"));

            //Assert.AreEqual(true, left_ear.IsTurnOnLight());
        }
        [TestMethod]
        public void Check_robot_Feet_move()
        {
            var head = new Head();
            var body = new Body();
            var hands = new List<Hand>();

            var leftFeet = new Foot()
            {
                Type = "left",
            };
            var rightFeet = new Foot()
            {
                Type = "right",
            };
            var foots = new List<Foot>();
            foots.Add(leftFeet);
            foots.Add(rightFeet);
            
            var robot = new Robot(head, body, foots, hands);
            double x = 3.4;
            double y = -7.6;

            robot.MoveFoot(x, y);
            

            Assert.AreEqual(x, leftFeet.X);
            Assert.AreEqual(x, rightFeet.X);
            Assert.AreEqual(y, leftFeet.Y);
            Assert.AreEqual(y, rightFeet.Y);
        }
        [TestMethod]
        public void Check_robot_Ear_light_on_when_feet_move()
        {
            //var head = new Head();
            //var body = new Body();
            //var hands = new List<Hand>();

            //var leftHand = new Foot()
            //{
            //    Type = "left",
            //};
            //var rightHand = new Foot()
            //{
            //    Type = "right",
            //};
            //var foots = new List<Foot>();
            //foots.Add(leftHand);
            //foots.Add(rightHand);
            
            //var robot = new Robot(head, body, foots, hands);
            //double x = 3.4;
            //double y = -7.6;

            //robot.MoveLeftFoot(x, y);
            //robot.MoveRightFoot(x, y);

            //var left_ear = robot.head.Ears.FirstOrDefault(x => x.Type.Equals("left"));
            //var right_ear = robot.head.Ears.FirstOrDefault(x => x.Type.Equals("right"));

            //Assert.AreEqual(x, leftHand.X);
            //Assert.AreEqual(y, leftHand.Y);
            //Assert.AreEqual(true, left_ear.IsTurnOnLight());

            //Assert.AreEqual(x, rightHand.X);
            //Assert.AreEqual(y, rightHand.Y);
            //Assert.AreEqual(true, right_ear.IsTurnOnLight());

        }
        [TestMethod]
        public void Check_robot_has_open_eye ()
        {
            var head = new Head();
            var body = new Body();
            var hands = new List<Hand>();
            var foots = new List<Foot>();
            var leftEye = new Eye()
            {
                Type = "Close",
            };
            var rightEye = new Eye()
            {
                Type = "Close"
            };
            var robot = new Robot(head, body, foots, hands);
            robot.head.Face.Eyes.Add(leftEye);
            robot.head.Face.Eyes.Add(rightEye);

            leftEye.OpenEye();
            rightEye.OpenEye();

            Assert.AreEqual(true, leftEye.IsHasOpen());
            Assert.AreEqual(true, rightEye.IsHasOpen());
            

        }

        //      29/06/2023

        [TestMethod]
        public void Check_robot_Mouth_create_sound_when_hand_move()
        {
            var robot = new Robot();

            double x = 3.4;
            double y = -7.6;
            var type = "right";
            robot.MoveHand(x, y, type);

            var result = robot.GetTypeHand(type);
            Assert.AreEqual(x, result.X);
            Assert.AreEqual(y, result.Y);
            
            Assert.AreEqual(true, robot.head.Face.Mouth.IsHasSound());

        }

        [TestMethod]
        public void Check_robot_hand_move_when_feet_move()
        {
            var robot = new Robot();

            double x = 3.4;
            double y = -7.6;

            robot.MoveFoot(x, y);

            foreach (var item in robot.foots)
            {
                var type = item.Type;

                Assert.AreEqual(x, item.X);
                Assert.AreEqual(y, item.Y);

                var typeHand = robot.GetTypeHand(type);

                Assert.AreEqual(x, typeHand.X);
                Assert.AreEqual(y, typeHand.Y);
                Assert.AreEqual(true, robot.head.GetTypeEar(type).IsTurnOnLight());              
            }
        }
    }
}