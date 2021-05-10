using System;
using System.Collections.Generic;
using System.IO;
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


namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> antipasti = new List<string>();
        List<string> secondi = new List<string>();
        List<string> primi = new List<string>();
        List<string> dolci = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CaricaAntipasti(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("antipasto.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    antipasti.Add(line);
                    cbx_antipasto.Items.Add(line);
                }
            }
        }

        private void CaricaPrimi(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("primo.txt"))
            {

                string line;
                while ((line = r.ReadLine()) != null)
                {
                    primi.Add(line);
                    cbx_primo.Items.Add(line);
                }
            }
        }

        private void CaricaSecondi(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("secondo.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    secondi.Add(line);
                    cbx_secondo.Items.Add(line);
                }
            }
        }

        private void CaricaDolci(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("dolce.txt"))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    dolci.Add(line);
                    cbx_dolce.Items.Add(line);
                }
            }
        }

        private void aggiungi_Click(object sender, RoutedEventArgs e)
        {
            if (cbx_antipasto.SelectedIndex != -1 && cbx_primo.SelectedIndex != -1 && cbx_secondo.SelectedIndex != -1 && cbx_dolce.SelectedIndex != -1)
            {
                lbox_selezione.Items.Add(cbx_antipasto.SelectedItem);
                lbox_selezione.Items.Add(cbx_primo.SelectedItem);
                lbox_selezione.Items.Add(cbx_secondo.SelectedItem);
                lbox_selezione.Items.Add(cbx_dolce.SelectedItem);
                cbx_antipasto.SelectedIndex = -1;
                cbx_primo.SelectedIndex = -1;
                cbx_secondo.SelectedIndex = -1;
                cbx_dolce.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Attenzione selezionare tutte e 4 le scelte!", "Attenzione", MessageBoxButton.OK);
                lbox_selezione.Items.Clear();
            }


        }

        private void rimuovi_Click_1(object sender, RoutedEventArgs e)
        {
            if (lbox_selezione.SelectedIndex != -1)
            {
                lbox_selezione.Items.RemoveAt(lbox_selezione.SelectedIndex);
            }
            else
            {
                MessageBox.Show("attenzione selezionare almeno un elemento", "attenzione", MessageBoxButton.OK);
            }
        }

        private void BtnPulisci_Click(object sender, RoutedEventArgs e)
        {
            lbox_selezione.Items.Clear();
        }

        private void BtnChiudi_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
