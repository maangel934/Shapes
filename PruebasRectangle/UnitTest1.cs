using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
namespace PruebasRectangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow]
        public void areaRectangle(double width, double height)
        {
            Assert.AreEqual(Shapes.rectangle(height, width));
    }
}
