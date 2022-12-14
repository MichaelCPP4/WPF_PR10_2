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
using LibMas;

namespace WPF_PR10_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = TempData.ToDataTable(tovar, productionCosts, prices).DefaultView;
        }

        List<string> tovar = new List<string>()
        {
            "Посудомойка",
            "Стиральная машина",
            "Лампа",
            "Чайник",
            "Миксер",
            "Компьютер",
            "Мониор"
        };

        List<double> prices = new List<double>()
        {
            44000.50,
            35000.99,
            2666.99,
            1133.45,
            3444.55,
            66777.99,
            21250.99

        };
        List<double> productionCosts = new List<double>()
        {
            32000.50,
            31000.99,
            1337.99,
            800.45,
            1488.55,
            80228.99,
            16250.99
        };


        private void ToFind_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < prices.Count; i++)
            {
                if (productionCosts[i] > prices[i])
                {
                    textBoxresult.Text = $"{i+1} - номер товара затраты производства которого превышают его цену";
                    break;
                }
                else
                {
                    textBoxresult.Text = "Нет товаров затраты производства которого превышают его цену";
                }
            }
        }
    }
}