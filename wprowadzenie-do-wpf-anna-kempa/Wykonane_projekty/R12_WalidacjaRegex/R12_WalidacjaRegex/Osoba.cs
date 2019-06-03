using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;   //!!!

namespace R12_WalidacjaRegex
{
    class Osoba: IDataErrorInfo
    {
        public string Nazwisko { get; set; }
        public string Imiona { get; set; }
        public string Pesel { get; set; }
        public string KodPocztowy { get; set; }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string this[string nazwaWlasciwosciOsoby]
        {
            get
            {
                string komunikat = String.Empty;
                switch (nazwaWlasciwosciOsoby)
                {
                    case "Nazwisko":
                        if (string.IsNullOrEmpty(Nazwisko)) komunikat = "Nazwisko musi być wpisane!";
                        else if (!Regex.IsMatch(Nazwisko, "^[A-Z][a-z]+$")) komunikat = "Nazwisko z dużej litery i minimum 2 znaki!";
                        //else if (!Regex.IsMatch(Nazwisko, @"^\p{Lu}\p{Ll}+$")) 
                        //    komunikat = "Nazwisko z dużej litery i minimum 2 znaki!";  // wariant z polskimi znakami
                        break;
                    case "Imiona":
                        if (string.IsNullOrEmpty(Imiona)) komunikat = "Należy wpisać imię lub imiona!";
                        else if (!Regex.IsMatch(Imiona, @"^[A-Z][a-z]+(\s[A-Z][a-z]+)*$"))
                            komunikat = "Imiona z dużej litery i minimum 2 znaki";
                        break;
                    case "Pesel":
                        if (string.IsNullOrEmpty(Pesel)) komunikat = "Pesel musi być wpisany!";
                        else if (!Regex.IsMatch(Pesel, @"^\d{11}$"))
                            komunikat = "Numer PESEL musi mieć 11 znaków";
                        break;
                    case "KodPocztowy":
                        if (string.IsNullOrEmpty(KodPocztowy)) komunikat = "Kod pocztowy musi być wpisany!";
                        else if (!Regex.IsMatch(KodPocztowy, @"^\d{2}-\d{3}$"))
                            komunikat = "Kod pocztowy ma mieć format 99-999";
                        break;
                };
                return komunikat;
            }
        }
    }
}
