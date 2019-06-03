using System;
using System.ComponentModel;   // !! INotifyPropertyChanged
using System.Windows;   // !!

namespace R13_MVVM_Student
{
    class StudentViewModel : INotifyPropertyChanged
    {
        private Student _kursant;
        public Student Kursant
        {
            get { return _kursant; }
            set
            {
                _kursant = value;
                OnPropertyChanged("Kursant");
            }
        }
        public MyCommand Wyczysc { get; set; }

        public StudentViewModel()
        {
            Kursant = new Student { Imie = "Jan", Nazwisko = "Kowalski",
                RokPrzyjeciaNaStudia = 2014 };
            Wyczysc = new MyCommand(WyczyscDane);
        }

        private void WyczyscDane()
        {
            if (MessageBox.Show("Czy wyczyścić dane studenta?", "Pytanie", 
                MessageBoxButton.YesNo, MessageBoxImage.Question) == 
                MessageBoxResult.Yes)
            {
                Kursant.Imie = String.Empty;
                Kursant.Nazwisko = String.Empty;
                Kursant.RokPrzyjeciaNaStudia = DateTime.Now.Year;
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
