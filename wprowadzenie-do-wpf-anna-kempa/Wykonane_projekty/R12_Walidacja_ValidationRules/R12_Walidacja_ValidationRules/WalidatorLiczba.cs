using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace R12_Walidacja_ValidationRules
{
    class WalidatorLiczb : ValidationRule
    {
        public double Min { get; set; }
        public double Max { get; set; }

        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            double sprawdzanaLiczba = 0;

            try
            {
                if (value.ToString().Length > 0)
                    sprawdzanaLiczba = Double.Parse(value.ToString());
            }
            catch (FormatException e)
            {
                return new ValidationResult(false, "Niedozwolone znaki - " +
                    e.Message);
            }

            if (sprawdzanaLiczba < Min || sprawdzanaLiczba > Max)
            {
                return new ValidationResult(false, "Wprowadź liczbę z zakresu: " +
                    Min + " - " + Max);
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }
    }
}
