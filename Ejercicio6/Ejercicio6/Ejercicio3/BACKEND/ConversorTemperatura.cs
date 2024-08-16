using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6.Ejercicio3.BACKEND
{
    namespace ConversorTemperatura
    {
        public class ConversorTemperatura
        {
            
            public double ConvertirFahrenheitAKelvin(double fahrenheit)
            {
                return (fahrenheit - 32) * 5 / 9 + 273.15;
            }

            
            public double ConvertirKelvinAFahrenheit(double kelvin)
            {
                return (kelvin - 273.15) * 9 / 5 + 32;
            }
        }
    }

}
