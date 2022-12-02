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

namespace DeliveryApp
{
    /// <summary>
    /// Логика взаимодействия для Ord.xaml
    /// </summary>
    public partial class Ord : Window
    {
        public Ord()
        {
            InitializeComponent();
        }

        private void AuthBack(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void SendForm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ оформлен");
        }
    }
}
