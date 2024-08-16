using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio1.Ejercicio1Calculadora
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            // Suscribirse al evento TextChanged de los TextBox
            FirstNumberTexbox.TextChanged += new EventHandler(TextBoxes_TextChanged);
            SecondNumberTexbox.TextChanged += new EventHandler(TextBoxes_TextChanged);
            // Inicializar el estado de los botones
            UpdateButtonStates();
        }

        private void SumaButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out int firstNumber, out int secondNumber))
            {
                int result = firstNumber + secondNumber;
                ResultLabel.Text = $"La sumatoria de {firstNumber} + {secondNumber} = {result}";
            }
        }

        private void RestButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out int firstNumber, out int secondNumber))
            {
                int result = firstNumber - secondNumber;
                ResultLabel.Text = $"La resta de {firstNumber} - {secondNumber} = {result}";
            }
        }

        private void MultiplierButton_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out int firstNumber, out int secondNumber))
            {
                int result = firstNumber * secondNumber;
                ResultLabel.Text = $"La multiplicación de {firstNumber} * {secondNumber} = {result}";
            }
        }

        private bool ValidateInputs(out int firstNumber, out int secondNumber)
        {
            firstNumber = 0;
            secondNumber = 0;
            bool valid = true;

            if (!int.TryParse(FirstNumberTexbox.Text, out firstNumber))
            {
                valid = false;
                MessageBox.Show("Por favor, ingrese un número válido en el primer campo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!int.TryParse(SecondNumberTexbox.Text, out secondNumber))
            {
                valid = false;
                MessageBox.Show("Por favor, ingrese un número válido en el segundo campo.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valid;
        }

        private void MultiplierButton_MouseUp(object sender, MouseEventArgs e)
        {
            MultiplierButton.BackColor = Color.Yellow;
        }

        private void SumaButton_MouseEnter(object sender, EventArgs e)
        {
            SumaButton.BackColor = Color.LightGreen;
        }

        private void RestButton_MouseLeave(object sender, EventArgs e)
        {
            RestButton.BackColor = Color.LightBlue;
        }

        private void MultiplierButton_MouseDown(object sender, MouseEventArgs e)
        {
            MultiplierButton.BackColor = Color.Yellow;
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            bool enableButtons = !string.IsNullOrWhiteSpace(FirstNumberTexbox.Text) &&
                                 !string.IsNullOrWhiteSpace(SecondNumberTexbox.Text);

            SumaButton.Enabled = enableButtons;
            RestButton.Enabled = enableButtons;
            MultiplierButton.Enabled = enableButtons;
        }
    }
}