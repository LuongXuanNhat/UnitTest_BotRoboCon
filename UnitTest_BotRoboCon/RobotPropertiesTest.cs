namespace UnitTest_BotRoboCon
{
    [TestClass]
    public class RobotPropertiesTest
    {
        [TestMethod]
        public void Check_Robot_Head_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasHead();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Has_Face_Test()
        {

            var head = new Head();
            var body = new Body();
            var foots = new List<Foot>();
            var hands = new List<Hand>();

            var robot = new Robot(head,body,foots,hands);
            var result = robot.IsHasFace();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Has_Mouth_Test()
        {

            var head = new Head();
            var body = new Body();
            var foots = new List<Foot>();
            var hands = new List<Hand>();

            var robot = new Robot(head,body,foots,hands);
            var result = robot.IsHasMouth();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Has_Eye_Test()
        {

            var head = new Head();
            var body = new Body();
            var foots = new List<Foot>();
            var hands = new List<Hand>();

            var robot = new Robot(head,body,foots,hands);
            var result = robot.IsHasEye();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Body_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasBody();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Body_Neck_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasNeck();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Body_Chest_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasChest();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Body_Waist_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasWaist();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Hand_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasHand();
            Assert.IsNotNull(robot.hands);
        }
        [TestMethod]
        public void Check_Robot_Hand_Finger_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasFinger();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Foot_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasFoot();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Foot_Feet_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasFeet();
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Check_Robot_Foot_Toe_Test()
        {
            var robot = new Robot()
            {
                head = new Head(),
                body = new Body(),
                foots = new List<Foot>(),
                hands = new List<Hand>()

            };
            var result = robot.IsHasToe();
            Assert.AreEqual(true, result);
        }

    }
}