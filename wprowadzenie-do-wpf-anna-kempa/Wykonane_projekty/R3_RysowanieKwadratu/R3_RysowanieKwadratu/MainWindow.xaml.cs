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

namespace R3_RysowanieKwadratu
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

        private void txtBok_TextChanged(object sender, TextChangedEventArgs e)
        {
            double bok;  // wartość tej zmiennej będzie ustalona w metodzie TryParse (argument out)
            if (double.TryParse(txtBok.Text, out bok) && bok >= 0)
            {
                txtPole.Text = Math.Pow(bok, 2.0).ToString();
                txtObwod.Text = (bok * 4).ToString();
                lblKomunikat.Content = String.Empty;
            }
            else
            {
                lblKomunikat.Content = "Wpisz liczbę dodatnią";
            }
        }

        private void btnWyczysc_Click(object sender, RoutedEventArgs e)
        {
            txtBok.Text = String.Empty;
            txtPole.Text = String.Empty;
            txtObwod.Text = String.Empty;
            lblKomunikat.Content = "Wpisz wymiar boku";
        }

        private void btnRysuj_Click(object sender, RoutedEventArgs e)
        {
            double bok; // Maksymalny bok 380 (większy się nie zmieści w zadanym oknie)
            if (double.TryParse(txtBok.Text, out bok) && bok <= 380)
            {
                rectangle1.Height = bok;
                rectangle1.Width = bok;
                SolidColorBrush color = (SolidColorBrush)new BrushConverter().ConvertFromString(cmbKolory.Text); // Konwersja koloru z typu string
                rectangle1.Stroke = color; // Przypisanie wybranego koloru dla konturu
                rectangle1.Fill = color; // Przypisanie wybranego koloru dla wypełnienia
                                         // IsChecked.Value jest typu bool, do sprawdzenia użyjemy operatora warunkowego(?:)
                                         // (jeśli ma wartość true, to ustawiamy Opacity na 50%, w przeciwnym razie 100 %)
                rectangle1.Opacity = (cbPrzezroczysty.IsChecked.Value) ? 0.5 : 1;
            }
            else
            {
                lblKomunikat.Content = "Brak danych lub zbyt duży bok";
            }
        }
    }
}
