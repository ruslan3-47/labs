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
            Func<double, double> f = x => x*x;
            if (r == "метод прямоугольников")
            {
                Metod_Rectangular Resh = new Metod_Rectangular();
                Answer.Text = Convert.ToString(Math.Round( Resh.Resh(f, a, b, n),3));
            }
            else
            {
                Metod_Trapezoid Resh = new Metod_Trapezoid();
                Answer.Text = Convert.ToString(Math.Round(Resh.Resh(f, a, b, n),3));
            }
        }  
    }
}