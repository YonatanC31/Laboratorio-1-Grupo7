using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.AreaCalculator.Models
{
    public class Elipse
    {
        public double EjeMayor { get; set; }
        public double EjeMenor { get; set; }

        public Elipse(double ejeMayor, double ejeMenor)
        {
            EjeMayor = ejeMayor;
            EjeMenor = ejeMenor;
        }

        public double CalcularArea()
        {
            return Math.PI * EjeMayor * EjeMenor;
        }

        public double CalcularPerimetro()
        {
            double h = Math.Pow((EjeMayor - EjeMenor), 2) / Math.Pow((EjeMayor + EjeMenor), 2);
            return Math.PI * (EjeMayor + EjeMenor) * (1 + (3 * h) / (10 + Math.Sqrt(4 - 3 * h)));
        }
    }

}
