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
    public partial class ElipseForm : Form
    {
        public ElipseForm()
        {
            InitializeComponent();
        }

        private void ElipseButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(EjeMayorTexbox.Text) || string.IsNullOrWhiteSpace(EjeMenorTexbox.Text))
                {
                    MessageBox.Show("Por favor, ingrese valores para ambos ejes.");
                    return;
                }

                
                if (!double.TryParse(EjeMayorTexbox.Text, out double ejeMayor) || !double.TryParse(EjeMenorTexbox.Text, out double ejeMenor))
                {
                    MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
                    return;
                }

                
                if (ejeMayor <= 0 || ejeMenor <= 0)
                {
                    MessageBox.Show("Los valores de los ejes deben ser positivos.");
                    return;
                }

                Elipse elipse = new Elipse(ejeMayor, ejeMenor);

                double resultado = 0;

                if (OpcionesElipseTexbox.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una opción (Área o Perímetro).");
                    return;
                }

                if (OpcionesElipseTexbox.SelectedItem.ToString() == "Area")
                {
                    resultado = elipse.CalcularArea();
                }
                else if (OpcionesElipseTexbox.SelectedItem.ToString() == "Perimetro")
                {
                    resultado = elipse.CalcularPerimetro();
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

        private void ElipseButton_MouseClick(object sender, MouseEventArgs e)
        {
            ElipseButton.BackColor = Color.Gold;
        }
    }
}
