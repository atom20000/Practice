using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PR12_1_1;

namespace PR12_1_1Test
{
    [TestClass]
    public class GeometryTesta
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3;
            int b = 5;
            int expected = 15;
            Geometry g = new Geometry();
            int actual = g.RectangleArea(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
