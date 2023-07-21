using MindBoxTask.Lib;

namespace MindBoxTask.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Square_3_8_9_Return_11_832()
        {
            Triangle triangle = new Triangle(3, 8, 9);

            double expected = 16.832;

            double result = triangle.CalcArea();

            Assert.AreEqual(expected, result);
        }
    }
}
