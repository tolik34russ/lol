﻿using _15;
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
    /// Логика взаимодействия для Stats.xaml
    /// </summary>
    public partial class Stats : Page
    {
        public Stats()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            NavigationService.Navigate(mainPage);
        }

        private void StatsB_Click(object sender, RoutedEventArgs e)
        {
            Stats stats = new Stats();
            NavigationService.Navigate(stats);
        }

        private void popol_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Баланс пополнен))))");
        }
    }
}
