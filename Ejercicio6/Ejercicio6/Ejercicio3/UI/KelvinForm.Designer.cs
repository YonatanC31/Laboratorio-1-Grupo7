namespace Ejercicio6.Ejercicio3.UI
{
    partial class KelvinForm
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
            ConvertiraKelvin = new Button();
            DatosTexboxFahrenheit = new TextBox();
            label2 = new Label();
            Resultadof = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(38, 69);
            label1.Name = "label1";
            label1.Size = new Size(727, 37);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO AL CONVERSOR DE FAHRENHEIT A KELVIN";
            // 
            // ConvertiraKelvin
            // 
            ConvertiraKelvin.BackColor = SystemColors.ActiveCaptionText;
            ConvertiraKelvin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConvertiraKelvin.ForeColor = SystemColors.ControlLightLight;
            ConvertiraKelvin.Location = new Point(246, 262);
            ConvertiraKelvin.Name = "ConvertiraKelvin";
            ConvertiraKelvin.Size = new Size(306, 42);
            ConvertiraKelvin.TabIndex = 8;
            ConvertiraKelvin.Text = "CALCULAR";
            ConvertiraKelvin.UseVisualStyleBackColor = false;
            ConvertiraKelvin.Click += ConvertiraKelvin_Click;
            // 
            // DatosTexboxFahrenheit
            // 
            DatosTexboxFahrenheit.Location = new Point(229, 196);
            DatosTexboxFahrenheit.Name = "DatosTexboxFahrenheit";
            DatosTexboxFahrenheit.Size = new Size(356, 27);
            DatosTexboxFahrenheit.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 139);
            label2.Name = "label2";
            label2.Size = new Size(467, 31);
            label2.TabIndex = 6;
            label2.Text = "Ingrese la cantidad de grados en Fahrenheit:";
            // 
            // Resultadof
            // 
            Resultadof.AutoSize = true;
            Resultadof.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Resultadof.Location = new Point(159, 350);
            Resultadof.Name = "Resultadof";
            Resultadof.Size = new Size(0, 31);
            Resultadof.TabIndex = 9;
            // 
            // KelvinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Resultadof);
            Controls.Add(ConvertiraKelvin);
            Controls.Add(DatosTexboxFahrenheit);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "KelvinForm";
            Text = "KelvinForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button ConvertiraKelvin;
        private TextBox DatosTexboxFahrenheit;
        private Label label2;
        private Label Resultadof;
    }
}