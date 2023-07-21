using MindBoxTask.Lib;

namespace MindBoxTask.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void Square_8_Return_201_062()
        {
            Circle circle = new Circle(3);

            double expected = 500.15;

            double result = circle.CalcArea();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_2_Return_12_566()
        {
            Circle circle = new Circle(2);

            double expected = 12.090;

            double result = circle.CalcArea();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Square_6_Return_113_097()
        {
            Circle circle = new Circle(6);

            double expected = 110.120;

            double result = circle.CalcArea();

            Assert.AreEqual(expected, result);
        }
    }
}