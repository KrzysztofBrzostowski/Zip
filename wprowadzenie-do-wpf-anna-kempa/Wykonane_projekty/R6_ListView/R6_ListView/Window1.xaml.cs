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
using System.ComponentModel;

namespace R6_ListView
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private MainWindow mainWindow = null;        // Obiekt dla okna głównego

        public Window1()
        {
            InitializeComponent();
        }

        // Poniżej jest przeładowana wersja konstruktora z obiektem dla głównego okna (jako argumentem). 
        // Posłużymy się tym argumentem w celu sprawdzenia, jaki produkt wybrano w ListView w oknie głównym
        public Window1(MainWindow mainWin)
        {
            InitializeComponent();
            mainWindow = mainWin;
            Produkt produktZListy = mainWindow.lstProdukty.SelectedItem as Produkt;
            if (produktZListy != null)
            {
                gridProdukt.DataContext = produktZListy;   // wybrany produkt z listy
            }
        }

        private void btnPotwierdz_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();      // zamknięcie bieżącego okna
            this.DialogResult = true;
        }
    }
}
