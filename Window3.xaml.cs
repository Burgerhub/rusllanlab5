using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ruslanprackt5var10
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(vod.Text);
            int b = int.Parse(vod1.Text);

            double sum = 0.0;
            double pow = 1.0;

            for (int i = 0; i < b; i++)
            {
                sum += pow;
                pow *= a;
            }
            otv.Text = $"Сумма {sum}";
        }
    }
}
