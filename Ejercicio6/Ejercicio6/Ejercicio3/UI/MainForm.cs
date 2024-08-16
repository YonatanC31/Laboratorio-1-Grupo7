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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConvertirAFahrenheit_Click(object sender, EventArgs e)
        {
            FahrenheitForm fahrenheitForm = new FahrenheitForm();
            fahrenheitForm.Show();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConvertirAKelvinButton_Click(object sender, EventArgs e)
        {
            KelvinForm kelvinForm = new KelvinForm();
            kelvinForm.Show();
        }

        private void ConvertirAKelvinButton_MouseClick(object sender, MouseEventArgs e)
        {
            BackColor = Color.Gold;
        }

        private void ConvertirAFahrenheit_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Color.Green;
        }
    }
}
