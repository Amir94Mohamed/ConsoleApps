using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace TestingApp1
{
    [TestClass]
    public class TestDistanceConverter
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = "Miles";
            converter.ToUnit = "Feet";
            converter.FromDistance = 10;
            converter.();

            double expectedDistance = 52800;
            Assert.AreEqual(converter.ToDistance, expectedDistance);
        }

    }
}
