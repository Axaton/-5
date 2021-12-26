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

namespace Практическая__5
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

        private void IncreaseBy1_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(firstTriad1.Text) > 0 || int.Parse(secondTriad1.Text) > 0 || int.Parse(thirdTriad1.Text) > 0)
            {
                MessageBox.Show("Значения должны быть отрицательными");
            }
            else
            {
                Triad firstTriad = new Triad(int.Parse(firstTriad1.Text), int.Parse(secondTriad1.Text), int.Parse(thirdTriad1.Text));
                Triad result = firstTriad.Add();
                firstTriad1.Text = result.First.ToString();
                secondTriad1.Text = result.Second.ToString();
                thirdTriad1.Text = result.Third.ToString();
            }
        }

        private void IncreaseBy10_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(firstTriad1.Text) > 0 || int.Parse(secondTriad1.Text) > 0 || int.Parse(thirdTriad1.Text) > 0)
            {
                MessageBox.Show("Значения должны быть отрицательными");
            }
            else
            {
                Triad firstTriad = new Triad(int.Parse(firstTriad1.Text), int.Parse(secondTriad1.Text), int.Parse(thirdTriad1.Text));
                Triad result = firstTriad.SetParams();
                firstTriad1.Text = result.First.ToString();
                secondTriad1.Text = result.Second.ToString();
                thirdTriad1.Text = result.Third.ToString();
            }
        }

        private void SetParams_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(first.Text) > 0 || int.Parse(second.Text) > 0 || int.Parse(third.Text) > 0)
            {
                MessageBox.Show("Значения должны быть отрицательными");
            }
            else
            {
                Triad firstTriad = new Triad(int.Parse(firstTriad1.Text), int.Parse(secondTriad1.Text), int.Parse(thirdTriad1.Text));
                Triad result = firstTriad.SetParams(int.Parse(first.Text), int.Parse(second.Text), int.Parse(third.Text));
                firstTriad1.Text = result.First.ToString();
                secondTriad1.Text = result.Second.ToString();
                thirdTriad1.Text = result.Third.ToString();
            }
        }

      
        private void TaskInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Triad (тройка отрицательных чисел). Создать необходимые методы и " +
            "свойства.Определить метод увеличения полей на 1.Создать перегруженные методы SetParams, " +
               "для установки параметров объекта, в том числе увеличения всех чисел на 10.", "Задание");
        }


        private void DeveloperInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Харенко Кирилл  ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
