using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button1.Click += Button_click;
        }
        void Button_click(object sender, EventArgs e)
        {
            string r = MetodBox.Text;
            double a = double.Parse(Text1.Text);
            double b = double.Parse(Text2.Text);
            int n = int.Parse(Text3.Text);
            Func<double, double> f = x => x * Math.Log2(x) - 17 + 47 * Math.Log2(27 * x);
            if (r == "метод прямоугольников")
            {
                Metod_Rectangular Resh = new Metod_Rectangular();
                Stopwatch sw = new Stopwatch();
                
                Answer.Text = Convert.ToString(Math.Round( Resh.Resh(f, a, b, n),3));
                
                sw.Start();
                var norm = Resh.Resh(f,a, b, n);
                sw.Stop();
                Time1.Text = sw.Elapsed.ToString();
                Stopwatch sw1 = new Stopwatch();
                sw1.Start();
                var Parallel = Resh.Resh_Paralel(f,a,b,n);
                sw1.Stop();
                Time2.Text = sw1.Elapsed.ToString();
            }
            else
            {
                Metod_Trapezoid Resh = new Metod_Trapezoid();
                Stopwatch sw2 = new Stopwatch();
                
                Answer.Text = Convert.ToString(Math.Round(Resh.Resh(f, a, b, n),3));
                sw2 .Start();
                var Norm = Resh.Resh(f, a, b, n);
                sw2 .Stop();
                Time1.Text = sw2.Elapsed.ToString();
                Stopwatch sw3 = new Stopwatch();
                sw3.Start();
                var Par = Resh.Resh_Paralel(f,a,b,n);
                sw3 .Stop();
                Time2.Text = sw3.Elapsed.ToString();
            }
        }  
    }
}