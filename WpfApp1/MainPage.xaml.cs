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
using WpfApp1;

namespace _15
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void HomeB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainPage mainPage = new MainPage();
            NavigationService.Navigate(mainPage);
        }

        private void StatB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Stats stats = new Stats();
            NavigationService.Navigate(stats);
        }

        private void ProfileB_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Profile profile = new Profile();
            NavigationService.Navigate(profile);
        }

        private void StatB_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Stats stats = new Stats();
            NavigationService.Navigate(stats);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Stats stats = new Stats();
            NavigationService.Navigate(stats);
        }

        private void prB_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            NavigationService.Navigate(mainPage);
        }

        private void Proff_Click(object sender, RoutedEventArgs e)
        {
            Profile profile = new Profile();
            NavigationService.Navigate(profile);
        }
    }
}
