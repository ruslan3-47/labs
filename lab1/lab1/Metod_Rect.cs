using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Metod_Rectangular() : Solv
    {
        public override double Resh(Func<double, double> f, double a, double b, int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Неверно задано число разбиений");
            }
            if((a>=b) | (a == 0)|(b==0))
            {
                throw new ArgumentException("Неверно заданы границы интегрирования");
            }
            double h = (b - a) / n;
            double area = 0.0;
            for (int i = 0; i < n; i++)
            {
                
                area += f(a + 0.5 * h);
                a += h;
            }
            area = area * h;
            return area;
        }
    }
}
