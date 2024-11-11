using lab1;

namespace TestNormalDAta
{
    [TestClass]
    public class TestNormData
    {
        [TestMethod]
        public void TestNormDataRect()
        {
            double lower = 1;
            double upper = 100;
            int count = 10000;
            Func<double, double> func = x => 10 * x + Math.Log(14 * x);
            double exception = 50617.784;
            Metod_Rectangular rectangular = new Metod_Rectangular();
            double Proverca = rectangular.Resh(func, lower, upper, count);
            Assert.AreEqual(exception, Proverca,0.1);

        }
        [TestMethod]
        public void TestNormDataTrap()
        {
            double lower = 1;
            double upper = 100;
            int count = 100000;
            Func<double, double> func = x => 10 * x + Math.Log(14 * x);
            double exception = 50617.784;
            Metod_Trapezoid trapezoid = new Metod_Trapezoid();
            double Proverca = trapezoid.Resh(func, lower, upper, count);
            Assert.AreEqual(exception, Proverca, 0.1);
        }

    }
}