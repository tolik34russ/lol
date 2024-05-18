using _15;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            NavigationService.Navigate(mainPage);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (log.Text != "" & pas.Text != "")
            {
                MessageBox.Show("Вы зашли");
                MainPage mainPage = new MainPage();
                NavigationService.Navigate(mainPage);

            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
