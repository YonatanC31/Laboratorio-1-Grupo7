namespace MCMtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcularMCM_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNum1.Text) && !string.IsNullOrEmpty(textBoxNum2.Text) && !string.IsNullOrEmpty(textBoxNum3.Text))
            {
                try
                {
                    //obtiendo valores
                    int num1 = Convert.ToInt32(textBoxNum1.Text);
                    int num2 = Convert.ToInt32(textBoxNum2.Text);
                    int num3 = Convert.ToInt32(textBoxNum3.Text);

                    //Calculando MCM
                    int resultado = CalcularMCM(num1, CalcularMCM(num2, num3));

                    //Mostrando resultado
                    resultLabel.Text = resultado.ToString();
                }
                catch
                {
                    MessageBox.Show($"Ingrese numeros validos", "Advertencia");
                }
            }
            else
            {
                MessageBox.Show($"Rellene todos los campos", "Advertencia");
            }
        }

        // Método para calcular el MCD
        private int CalcularMCD(int num2, int num3)
        {
            while (num3 != 0)
            {
                int temp = num3;
                num3 = num2 % num3;
                num2 = temp;
            }
            return num2;
        }

        // Metodo para calcular el MCM usando el MCD
        private int CalcularMCM(int a, int b)
        {
            return (a * b) / CalcularMCD(a, b);
        }
    }
}
