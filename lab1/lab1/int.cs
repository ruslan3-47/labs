using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace lab1
{
    public abstract class Solv() 
    {
        public abstract double resh(Func<double,double> f,double a,double b, int n);
    }
    public class Metod_Trapezoid: Solv
    {
        public override double resh(Func<double, double> f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double area = 0.0;
            for (int i = 0; i<n;i++)
            {
                area += f(((i + 0.5) * h + a) * h);
            }
            return area;
        }
    }
    public class Metod_Rectangular() : Solv
    {
        public override double resh(Func<double, double> f, double a, double b, int n)
        {
            double h = (b - a) / n;
            double area = 0.0;
            for (int i = 0;i<n;i++)
            {
                area += f(a + i * h) * h;
            }
            return area;
        }
    }
    //next class Trapezoid
}
