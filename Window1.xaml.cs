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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
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
            int min = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                int m = Convert.ToInt32(ListBoxData.Items[i]);
                if (m % 10 == 4 && m < min )
                {
                    min = m;
                }
            }

            TextBlockAnswer.Text = $" Минимальное число {min}";

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
    }
}
