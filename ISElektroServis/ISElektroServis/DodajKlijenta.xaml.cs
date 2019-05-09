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
    /// Interaction logic for DodajKlijenta.xaml
    /// </summary>
    public partial class DodajKlijenta : UserControl
    {
        public DodajKlijenta()
        {
            InitializeComponent();
        }

        public void ResetFields()
        {
            idKlijentaTextBox.Text = "";
            imeKlijentaTextBox.Text = "";
            adresaTextBox.Text = "";
            pibTextBox.Text = "";
            kontaktBrojTextBox.Text = "";
            emailTextBox.Text = "";
            
           


        }

        private void OcistiDugme_Click(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }
    }
}
