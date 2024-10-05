using lab1;

namespace MSTEST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            double lower = 0;
            double upper = 100;
            int count = 10000;
            Func<double, double >func = x => x*x;
            double expected = 333333.33333;
            //act
            Metod_Rectangular rect = new Metod_Rectangular();
            double a = rect.Resh(func, lower, upper, count);
            Metod_Trapezoid trap = new Metod_Trapezoid();
            double a2 = trap.Resh(func, lower, upper, count);
            //assert
            Assert.AreEqual(expected, a,0.1);
            Assert.AreEqual(expected,a2,0.1);
        }
    }
}