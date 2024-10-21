using lab1;

namespace TestNormalDataRect
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestNormalDataRect()
        {
            int lower = 1;
            int upper = 100;
            int count = 10000;
            Func<double, double> Func = x => 10 * x - Math.Log(14 * x);
            double expect =49372.216;

            Metod_Rectangular rectangular = new Metod_Rectangular();
            double a = rectangular.Resh(Func,lower, upper, count);

            Assert.AreEqual(expect, a, 0.1);

        }
    }
}