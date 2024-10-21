using lab1;

namespace TestRectWrongBorder
{
    [TestClass]
    public class WrongBorder
    {
        [TestMethod]
        [ExpectedException (typeof (ArgumentException))]
        public void RectWrongBorder()
        {
            double lower = 1000;
            double upper = 100;
            int count = 10000;
            Func<double, double> func = x => 10 * x + Math.Log(14 * x);
            Metod_Rectangular rectangular = new Metod_Rectangular();
            double Proverca = rectangular.Resh(func, lower, upper, count);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapWrongBorder()
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