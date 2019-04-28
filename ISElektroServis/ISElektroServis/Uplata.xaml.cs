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

namespace ISElektroServis
{
    /// <summary>
    /// Interaction logic for Uplata.xaml
    /// </summary>
    public partial class Uplata : Window
    {
        public Uplata()
        {
            InitializeComponent();
        }

        private void OtkaziDugme_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
