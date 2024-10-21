using lab1;

namespace TestRectWrongBorder
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
            Metod_Rectangular rectangular = new Metod_Rectangular();
            double Proverca = rectangular.Resh(func, lower, upper, count);
        }
    }
}