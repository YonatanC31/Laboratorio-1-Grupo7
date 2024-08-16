using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.AreaCalculator.Models
{
    public class Palelogramo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Palelogramo(double basePalelogramo, double altura)
        {
            Base = basePalelogramo;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}


