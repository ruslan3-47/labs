using lab1;

namespace traptest2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double lower = 1;
            double upper = 100;
            Func<double, double> func = x => 10 * x - Math.Log(14 * x);
            double expect = 49372.216;
            int count = 10000;
            Metod_Trapezoid trapezoid = new Metod_Trapezoid();
            double a = trapezoid.Resh(func,lower, upper,count);
            Assert.AreEqual(expect, a,0.1);
            
        }
    }
}