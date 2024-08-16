namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SUMA
        private void calcularSumsabutton_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrEmpty(primernumerotextBox1.Text) || !string.IsNullOrEmpty(segundonumerotextBox2.Text) || !string.IsNullOrEmpty(tercernumerotextBox3.Text))
            {

                try
                {
                    int primernumero = Convert.ToInt32(primernumerotextBox1.Text);
                    int segundonumero = Convert.ToInt32(segundonumerotextBox2.Text);
                    int tercernumero = Convert.ToInt32(tercernumerotextBox3.Text);

                    int result = primernumero + segundonumero + tercernumero;

                    Resultadolabel.Text = $"{result}";
                }
                catch
                {
                    MessageBox.Show($"Solo se admiten numeros", "Advertencia");
                }
            }
            else
            {
                MessageBox.Show("Rellene los tres campos", "Advertencia");
            }

        }
        //HOVER
        private void calcularRestarbutton_MouseHover(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(primernumerotextBox1.Text) || !string.IsNullOrEmpty(segundonumerotextBox2.Text) || !string.IsNullOrEmpty(tercernumerotextBox3.Text))
            {

                try
                {
                    int primernumero = Convert.ToInt32(primernumerotextBox1.Text);
                    int segundonumero = Convert.ToInt32(segundonumerotextBox2.Text);
                    int tercernumero = Convert.ToInt32(tercernumerotextBox3.Text);

                    int result = primernumero - segundonumero - tercernumero;

                    Resultadolabel.Text = $"{result}";
                }
                catch
                {
                    MessageBox.Show($"Solo se admiten numeros", "Advertencia");
                }
            }
            else
            {
                MessageBox.Show("Rellene los tres campos", "Advertencia");
            }
        }
        private void calcularMultiplicarbutton_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(primernumerotextBox1.Text) || !string.IsNullOrEmpty(segundonumerotextBox2.Text) || !string.IsNullOrEmpty(tercernumerotextBox3.Text))
            {

                try
                {
                    int primernumero = Convert.ToInt32(primernumerotextBox1.Text);
                    int segundonumero = Convert.ToInt32(segundonumerotextBox2.Text);
                    int tercernumero = Convert.ToInt32(tercernumerotextBox3.Text);

                    int result = primernumero * segundonumero * tercernumero;

                    Resultadolabel.Text = $"{result}";
                }
                catch
                {
                    MessageBox.Show($"Solo se admiten numeros", "Advertencia");
                }
            }
            else
            {
                MessageBox.Show("Rellene los tres campos", "Advertencia");
            }
        }
    }
}
