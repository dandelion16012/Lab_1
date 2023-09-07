

using System.Drawing;
using System.Reflection;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double side1 = 5; 
            double side2=3;
            Rectangle a = new Rectangle(side1, side2);
            double ar = a.Area;
            double per = a.Perimeter;
            Assert.AreEqual(ar, 15);
            Assert.AreEqual(per, 16);

        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = 4;
            int b=5;        
            int c=6;
            int d=7;
            int e=8;
            int f=9;
            Point[] points = new Point[3];
            points[0] = new Point(a, b);
            points[1] = new Point(c, d);
            points[2] = new Point(e, f);
            Figure qwe = new Figure("treug", 3, points);
            string name = qwe.Name;
            double per = qwe.PerimeterCalculate(points);
            Assert.AreEqual(name, "treug");
            Assert.AreEqual(per, 11,313708498984761);

        }
    }
}