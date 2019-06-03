using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;
using System.IO;

namespace R7_DataGrid_XML
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private string plik1 = @"..\..\dane\Produkty.xml";     // plik źródłowy
        private string plik2 = @"..\..\dane\Produkty2.xml";   // plik wynikowy
        private XElement wykazProduktow;
        public MainWindow()
        {
            InitializeComponent();
            WykonajWiazanie();
        }
        private void WykonajWiazanie()
        {
            if(File.Exists(plik1))
                wykazProduktow = XElement.Load(plik1);  // załadowanie danych z pliku źródłowego
            
            gridProdukty.DataContext = wykazProduktow;

            ObservableCollection<string> ListaMagazynow =
                new ObservableCollection<string>() { "Katowice 1", "Katowice 2", "Gliwice 1" };
            nazwaMagazynu.ItemsSource = ListaMagazynow;
        }
        private void btnZapisz_Click(object sender, RoutedEventArgs e)
        {
            wykazProduktow.Save(plik2);  // zapisanie danych do pliku wynikowego
            MessageBox.Show("Pomyślnie zapisano dane do pliku");
        }
    }
}
