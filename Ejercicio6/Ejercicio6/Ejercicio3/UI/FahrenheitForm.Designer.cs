namespace Ejercicio6.Ejercicio3.UI
{
    partial class FahrenheitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            DatosTexboxKelvin = new TextBox();
            ConvertiraFahrenheit = new Button();
            ResultadoKelvin = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(49, 75);
            label1.Name = "label1";
            label1.Size = new Size(727, 37);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO AL CONVERSOR DE KELVIN A FAHRENHEIT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 143);
            label2.Name = "label2";
            label2.Size = new Size(421, 31);
            label2.TabIndex = 2;
            label2.Text = "Ingrese la cantidad de grados en Kelvin:";
            // 
            // DatosTexboxKelvin
            // 
            DatosTexboxKelvin.Location = new Point(225, 196);
            DatosTexboxKelvin.Name = "DatosTexboxKelvin";
            DatosTexboxKelvin.Size = new Size(356, 27);
            DatosTexboxKelvin.TabIndex = 3;
            // 
            // ConvertiraFahrenheit
            // 
            ConvertiraFahrenheit.BackColor = SystemColors.ActiveCaptionText;
            ConvertiraFahrenheit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConvertiraFahrenheit.ForeColor = SystemColors.ControlLightLight;
            ConvertiraFahrenheit.Location = new Point(242, 262);
            ConvertiraFahrenheit.Name = "ConvertiraFahrenheit";
            ConvertiraFahrenheit.Size = new Size(306, 42);
            ConvertiraFahrenheit.TabIndex = 5;
            ConvertiraFahrenheit.Text = "CALCULAR";
            ConvertiraFahrenheit.UseVisualStyleBackColor = false;
            ConvertiraFahrenheit.Click += ConvertiraFahrenheit_Click;
            // 
            // ResultadoKelvin
            // 
            ResultadoKelvin.AutoSize = true;
            ResultadoKelvin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResultadoKelvin.Location = new Point(176, 374);
            ResultadoKelvin.Name = "ResultadoKelvin";
            ResultadoKelvin.Size = new Size(0, 31);
            ResultadoKelvin.TabIndex = 10;
            // 
            // FahrenheitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultadoKelvin);
            Controls.Add(ConvertiraFahrenheit);
            Controls.Add(DatosTexboxKelvin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FahrenheitForm";
            Text = "FahrenheitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox DatosTexboxKelvin;
        private Button ConvertiraFahrenheit;
        private Label ResultadoKelvin;
    }
}