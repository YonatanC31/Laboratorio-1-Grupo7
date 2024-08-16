namespace Ejercicio6.Ejercicio3.UI
{
    partial class MainForm
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
            ConvertirAFahrenheit = new Button();
            ConvertirAKelvinButton = new Button();
            CerrarButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.8F, FontStyle.Bold);
            label1.Location = new Point(140, 65);
            label1.Name = "label1";
            label1.Size = new Size(483, 45);
            label1.TabIndex = 0;
            label1.Text = "CONVERSOR DE EMPERATURA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(261, 151);
            label2.Name = "label2";
            label2.Size = new Size(251, 32);
            label2.TabIndex = 1;
            label2.Text = "¿Que desea convertir?";
            // 
            // ConvertirAFahrenheit
            // 
            ConvertirAFahrenheit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConvertirAFahrenheit.Location = new Point(65, 216);
            ConvertirAFahrenheit.Name = "ConvertirAFahrenheit";
            ConvertirAFahrenheit.Size = new Size(306, 42);
            ConvertirAFahrenheit.TabIndex = 2;
            ConvertirAFahrenheit.Text = "DE KELVIN A FAHRENHEIT";
            ConvertirAFahrenheit.UseVisualStyleBackColor = true;
            ConvertirAFahrenheit.Click += ConvertirAFahrenheit_Click;
            ConvertirAFahrenheit.MouseDown += ConvertirAFahrenheit_MouseDown;
            // 
            // ConvertirAKelvinButton
            // 
            ConvertirAKelvinButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConvertirAKelvinButton.Location = new Point(412, 216);
            ConvertirAKelvinButton.Name = "ConvertirAKelvinButton";
            ConvertirAKelvinButton.Size = new Size(329, 42);
            ConvertirAKelvinButton.TabIndex = 3;
            ConvertirAKelvinButton.Text = "DE  FAHRENHEIT A KELVIN";
            ConvertirAKelvinButton.UseVisualStyleBackColor = true;
            ConvertirAKelvinButton.Click += ConvertirAKelvinButton_Click;
            ConvertirAKelvinButton.MouseClick += ConvertirAKelvinButton_MouseClick;
            // 
            // CerrarButton
            // 
            CerrarButton.BackColor = SystemColors.ActiveCaptionText;
            CerrarButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CerrarButton.ForeColor = SystemColors.ControlLightLight;
            CerrarButton.Location = new Point(235, 318);
            CerrarButton.Name = "CerrarButton";
            CerrarButton.Size = new Size(306, 42);
            CerrarButton.TabIndex = 4;
            CerrarButton.Text = "SALIR";
            CerrarButton.UseVisualStyleBackColor = false;
            CerrarButton.Click += CerrarButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CerrarButton);
            Controls.Add(ConvertirAKelvinButton);
            Controls.Add(ConvertirAFahrenheit);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button ConvertirAFahrenheit;
        private Button ConvertirAKelvinButton;
        private Button CerrarButton;
    }
}