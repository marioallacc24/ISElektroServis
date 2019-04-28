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
    /// Interaction logic for IzradaFakture.xaml
    /// </summary>
    public partial class IzradaFakture : UserControl
    {
        public IzradaFakture()
        {
            InitializeComponent();
        }

        public void ResetFields()
        {
            brojFaktureTextBox.Text = "";
            idKlijentTextBox.Text = "";
            adresaTextBox.Text = "";
            pibTextBox.Text = "";
            popravkaTextBox.Text = "";
            opisTextBox.Text = "";
            brojMeseci.Text = "";
            iznosSlovimaTextBox.Text = "";
            iznosTextBox.Text = "";
            datumFakture.SelectedDate = null;


        }

        private void OcistiDugme_Click(object sender, RoutedEventArgs e)
        {
            ResetFields();
        }
    }
}
