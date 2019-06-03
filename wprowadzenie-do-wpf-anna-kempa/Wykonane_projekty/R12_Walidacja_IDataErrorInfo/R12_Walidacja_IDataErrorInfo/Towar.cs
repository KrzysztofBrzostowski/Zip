using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace R12_Walidacja_IDataErrorInfo
{
    class Towar : IDataErrorInfo
    {
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string this[string nazwaWlasciwosciTowaru]
        {
            get
            {
                string komunikat = String.Empty;
                switch (nazwaWlasciwosciTowaru)
                {
                    case "Nazwa":
                        if (string.IsNullOrEmpty(Nazwa)) komunikat = "Nazwa musi być wpisana!";
                        else if (Nazwa.Length < 3) komunikat = "Nazwa minimum 3 znaki!";
                        break;
                    case "Cena":
                        if ((Cena < 0.1) || (Cena > 1000)) komunikat = "Cena musi być z zakresu od 0,10 do 1000";
                        break;
                };
                return komunikat;
            }
        }
    }
}
