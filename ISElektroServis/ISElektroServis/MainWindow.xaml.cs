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

namespace ISElektroServis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_Izlaz_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

      

        private void MenuSvetlaTema_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries[1].Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml", UriKind.RelativeOrAbsolute);
        }

        private void MenuTamnaTema_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources.MergedDictionaries[1].Source = new Uri("pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Dark.xaml", UriKind.RelativeOrAbsolute);
        }

        private void Menu_Faktura_Izrada_Click(object sender, RoutedEventArgs e)
        {
            
            IzradaFakture.Visibility = Visibility.Visible;

            SlikaLogo.Visibility = Visibility.Hidden;
            ListaFaktura.Visibility = Visibility.Hidden;
            DodajKlijenta.Visibility = Visibility.Hidden;
        }

        private void Menu_Lista_faktura_Click(object sender, RoutedEventArgs e)
        {
            ListaFaktura.Visibility = Visibility.Visible;

            SlikaLogo.Visibility = Visibility.Hidden;
            IzradaFakture.Visibility = Visibility.Hidden;
            DodajKlijenta.Visibility = Visibility.Hidden;

        }

        private void Menu_Dodaj_klijenta_Click(object sender, RoutedEventArgs e)
        {
            DodajKlijenta.Visibility = Visibility.Visible;

            ListaFaktura.Visibility = Visibility.Hidden;
            SlikaLogo.Visibility = Visibility.Hidden;
            IzradaFakture.Visibility = Visibility.Hidden;

        }


    }
}
