using lab1;

namespace TestOtric
{
    [TestClass]
    public class TestOtric
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectOtric()
        {
            double lower = 1;
            double upper = 100;
            int count = -10000;
            Func<double, double> func = x => 10 * x + Math.Log(14 * x);
            Metod_Rectangular rectangular = new Metod_Rectangular();
            double Proverca = rectangular.Resh(func, lower, upper, count);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapOtric()
        {
            double lower = 1;
            double upper = 100;
            int count = -10000;
            Func<double, double> func = x => 10 * x + Math.Log(14 * x);
            Metod_Trapezoid trapezoid = new Metod_Trapezoid();
            double Proverca = trapezoid.Resh(func, lower, upper, count);
        }
    }
}