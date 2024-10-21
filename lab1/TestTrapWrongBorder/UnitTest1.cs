using lab1;

namespace TestTrapWrongBorder
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException (typeof (ArgumentException))]
        public void TestMethod1()
        {
            double lower = 1000;
            double upper = 100;
            int count = 10000;
            Func<double, double> func = x => 10 * x + Math.Log(14 * x);
            Metod_Trapezoid trapezoid = new Metod_Trapezoid();
            double Proverca = trapezoid.Resh(func, lower, upper, count);
        }
    }
}