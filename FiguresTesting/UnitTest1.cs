using Figures;

namespace FiguresTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(6,113.1)]
        [TestCase(1,Math.PI)]
        public void CirlceArea(double radius, double res)
        {
            Assert.AreEqual(res, new Circle() { Radius = radius }.Area, 0.01);
        }

        [Test]
        [TestCase(3, 4, 5, 6)]
        [TestCase(15, 10, 12, 59.811)]
        [TestCase(7, 4, 9, 13.416)]
        public void TriangleArea(double a, double b, double c, double res)
        {
            // Предпологается что треугольник существует
            Assert.AreEqual(res, new Triangle() { A = a, B = b, C = c }.Area, 0.01);
            Assert.AreEqual(res, new Triangle() { A = a, B = c, C = b }.Area, 0.01);
            Assert.AreEqual(res, new Triangle() { A = b, B = a, C = c }.Area, 0.01);
            Assert.AreEqual(res, new Triangle() { A = b, B = c, C = a }.Area, 0.01);
            Assert.AreEqual(res, new Triangle() { A = c, B = a, C = b }.Area, 0.01);
            Assert.AreEqual(res, new Triangle() { A = c, B = b, C = a }.Area, 0.01);
        }

        [Test]
        [TestCase(3,4,5,true)]
        [TestCase(6,8,10,true)]
        [TestCase(3,14,12,false)]
        public void RightTriangle(double a,double b,double c,bool res)
        {
            Assert.AreEqual(res, new Triangle() { A = a, B = b, C = c }.IsRight());
            Assert.AreEqual(res, new Triangle() { A = a, B = c, C = b }.IsRight());
            Assert.AreEqual(res, new Triangle() { A = b, B = a, C = c }.IsRight());
            Assert.AreEqual(res, new Triangle() { A = b, B = c, C = a }.IsRight());
            Assert.AreEqual(res, new Triangle() { A = c, B = a, C = b }.IsRight());
            Assert.AreEqual(res, new Triangle() { A = c, B = b, C = a }.IsRight());
        }
    }
}