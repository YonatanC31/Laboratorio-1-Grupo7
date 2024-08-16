using Ejercicio3.AreaCalculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3.AreaCalculator.Views
{
    public partial class PalelogramoForm : Form
    {
        public PalelogramoForm()
        {
            InitializeComponent();
        }

        private void CalcularPalelogramaButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(BaseTexbox.Text) || string.IsNullOrWhiteSpace(AlturaTexbox.Text))
                {
                    MessageBox.Show("Por favor, ingrese valores para la base y la altura.");
                    return;
                }

                
                if (!double.TryParse(BaseTexbox.Text, out double basePalelogramo) || !double.TryParse(AlturaTexbox.Text, out double alturaPalelogramo))
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
                    return;
                }

                
                if (basePalelogramo <= 0 || alturaPalelogramo <= 0)
                {
                    MessageBox.Show("Los valores de la base y la altura deben ser positivos.");
                    return;
                }

                Palelogramo palelogramo = new Palelogramo(basePalelogramo, alturaPalelogramo);

                double resultado = 0;

                if (OpcionesComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una opción (Área o Perímetro).");
                    return;
                }

                if (OpcionesComboBox.SelectedItem.ToString() == "Area")
                {
                    resultado = palelogramo.CalcularArea();
                }
                else if (OpcionesComboBox.SelectedItem.ToString() == "Perimetro")
                {
                    resultado = palelogramo.CalcularPerimetro();
                }
                else
                {
                    MessageBox.Show("Opción no válida. Por favor, seleccione 'Área' o 'Perímetro'.");
                    return;
                }

                MessageBox.Show("El resultado es: " + resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void CalcularPalelogramaButton_MouseClick(object sender, MouseEventArgs e)
        {
            CalcularPalelogramaButton.BackColor = Color.Green;
        }
    }
}
