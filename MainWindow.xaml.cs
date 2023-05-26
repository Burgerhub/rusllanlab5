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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ruslanprackt5var10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(ListBoxData.Items[0]);

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                
                int number = Convert.ToInt32(ListBoxData.Items[i]);

                if (number % 4 == 0 && number % 7 != 0)
                {
                    count++;
                }
            }

            TextBlockAnswer.Text = $"Количество чисел кратных 4 и не кратных 7 :{count}";

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
        }
    }
}
