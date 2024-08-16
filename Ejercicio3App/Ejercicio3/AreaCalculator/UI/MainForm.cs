using Ejercicio3.AreaCalculator.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3.AreaCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PalelogramoButton_Click(object sender, EventArgs e)
        {
            PalelogramoForm PalelogramoForm = new PalelogramoForm();
            PalelogramoForm.ShowDialog();
        }

        private void ElipseButton_Click(object sender, EventArgs e)
        {
            ElipseForm elipseForm = new ElipseForm();
            elipseForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
