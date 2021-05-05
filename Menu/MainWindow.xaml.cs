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
using System.IO;

namespace Menu
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

        private void antipasto(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("antipasto.txt"))
            {
                List<string> antipasto = new List<string>();
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    antipasto.Add(line);
                    cbx_antipasto.Items.Add(line);
                }
            }
        }

        private void primo(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("primo.txt"))
            {
                List<string> primo = new List<string>();
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    primo.Add(line);
                    Cbx_primo.Items.Add(line);
                }
            }
        }

        private void secondo(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("secondo.txt"))
            {
                List<string> secondo = new List<string>();
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    secondo.Add(line);
                    cbx_secondo.Items.Add(line);
                }
            }
        }

        private void dolce(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("dolce.txt"))
            {
                List<string> dolce = new List<string>();
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    dolce.Add(line);
                    cbx_dolce.Items.Add(line);
                }
            }
        }

        private void aggiungi_Click(object sender, RoutedEventArgs e)
        {
            if (cbx_antipasto.SelectedIndex != -1)
            {
                lbox_selezione.Items.Add(cbx_antipasto.SelectedItem);
                cbx_antipasto.SelectedIndex = -1;
            }
            else
                MessageBox.Show("attenzione selezionare almeno un elemento", "attenzione", MessageBoxButton.OK);
            if (Cbx_primo.SelectedIndex != -1)
            {
                lbox_selezione.Items.Add(Cbx_primo.SelectedItem);
                Cbx_primo.SelectedIndex = -1;
            }
            else
                MessageBox.Show("attenzione selezionare almeno un elemento", "attenzione", MessageBoxButton.OK);
            if (cbx_secondo.SelectedIndex != -1)
            {
                lbox_selezione.Items.Add(cbx_secondo.SelectedItem);
                cbx_secondo.SelectedIndex = -1;
            }
            else
                MessageBox.Show("attenzione selezionare almeno un elemento", "attenzione", MessageBoxButton.OK);
            if (cbx_dolce.SelectedIndex != -1)
            {
                lbox_selezione.Items.Add(cbx_dolce.SelectedItem);
                cbx_dolce.SelectedIndex = -1;
            }
            else
                MessageBox.Show("attenzione selezionare almeno un elemento", "attenzione", MessageBoxButton.OK);
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
