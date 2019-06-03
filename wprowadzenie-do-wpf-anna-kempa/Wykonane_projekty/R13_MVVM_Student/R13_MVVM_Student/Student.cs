using System;
using System.ComponentModel;   // !! INotifyPropertyChanged

namespace R13_MVVM_Student
{
    public class Student : INotifyPropertyChanged
    {
        private string imie;
        private string nazwisko;
        private int rokPrzyjeciaNaStudia;

        public string Imie
        {
            get
            {
                return imie;
            }
            set
            {
                if (imie != value)
                {
                    imie = value;
                    OnPropertyChanged("Imie");
                }
            }
        }

        public string Nazwisko
        {
            get
            {
                return nazwisko;
            }
            set
            {
                if (nazwisko != value)
                {
                    nazwisko = value;
                    OnPropertyChanged("Nazwisko");
                }
            }
        }

        public int RokPrzyjeciaNaStudia
        {
            get
            {
                return rokPrzyjeciaNaStudia;
            }
            set
            {
                if (rokPrzyjeciaNaStudia != value)
                {
                    rokPrzyjeciaNaStudia = value;
                    OnPropertyChanged("RokPrzyjeciaNaStudia");
                    OnPropertyChanged("CzasStudiowania");
                }
            }
        }

        public string CzasStudiowania
        {
            get
            {
                return (DateTime.Now.Year - RokPrzyjeciaNaStudia).ToString();
            }
        }

        // Implementacja interfejsu INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
