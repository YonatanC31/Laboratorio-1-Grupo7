using Ejercicio6.Ejercicio3.BACKEND.ConversorTemperatura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6.Ejercicio3.UI
{
    public partial class FahrenheitForm : Form
    {
        private ConversorTemperatura conversor;
        public FahrenheitForm()
        {
            InitializeComponent();
            conversor = new ConversorTemperatura();
        }

        private void ConvertiraFahrenheit_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double kelvin = Convert.ToDouble(DatosTexboxKelvin.Text);
                    double fahrenheit = conversor.ConvertirKelvinAFahrenheit(kelvin);
                    ResultadoKelvin.Text = fahrenheit.ToString("F2") + " °F";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, introduce un valor válido para Kelvin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
