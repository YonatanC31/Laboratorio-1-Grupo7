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
    public partial class KelvinForm : Form
    {
        private ConversorTemperatura conversor;
        public KelvinForm()
        {
            InitializeComponent();
            conversor = new ConversorTemperatura();
        }
        

        private void ConvertiraKelvin_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double fahrenheit = Convert.ToDouble(DatosTexboxFahrenheit.Text);
                    double kelvin = conversor.ConvertirFahrenheitAKelvin(fahrenheit);
                    Resultadof.Text = kelvin.ToString("F2") + " K";
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, introduce un valor válido para Fahrenheit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
