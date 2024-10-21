using lab1;

namespace TestNormalDataTrap
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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