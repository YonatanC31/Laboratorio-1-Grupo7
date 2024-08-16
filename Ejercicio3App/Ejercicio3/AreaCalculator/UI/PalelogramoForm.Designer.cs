namespace Ejercicio3.AreaCalculator.Views
{
    partial class PalelogramoForm
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
            label3 = new Label();
            BaseTexbox = new TextBox();
            AlturaTexbox = new TextBox();
            label4 = new Label();
            OpcionesComboBox = new ComboBox();
            label5 = new Label();
            CalcularPalelogramaButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 52);
            label1.Name = "label1";
            label1.Size = new Size(595, 31);
            label1.TabIndex = 1;
            label1.Text = "BIENVENIDO AL CALCULADOR DE AREA Y PERIMETRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 152);
            label2.Name = "label2";
            label2.Size = new Size(175, 31);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el base:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 214);
            label3.Name = "label3";
            label3.Size = new Size(187, 31);
            label3.TabIndex = 3;
            label3.Text = "Ingrese la altura:";
            // 
            // BaseTexbox
            // 
            BaseTexbox.Location = new Point(291, 158);
            BaseTexbox.Name = "BaseTexbox";
            BaseTexbox.Size = new Size(405, 27);
            BaseTexbox.TabIndex = 4;
            // 
            // AlturaTexbox
            // 
            AlturaTexbox.Location = new Point(291, 214);
            AlturaTexbox.Name = "AlturaTexbox";
            AlturaTexbox.Size = new Size(405, 27);
            AlturaTexbox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(157, 102);
            label4.Name = "label4";
            label4.Size = new Size(491, 31);
            label4.TabIndex = 6;
            label4.Text = "ESTAMOS CALCULANDO UN PALELOGRAMO";
            // 
            // OpcionesComboBox
            // 
            OpcionesComboBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OpcionesComboBox.FormattingEnabled = true;
            OpcionesComboBox.Items.AddRange(new object[] { "Area", "Perimetro" });
            OpcionesComboBox.Location = new Point(416, 258);
            OpcionesComboBox.Name = "OpcionesComboBox";
            OpcionesComboBox.Size = new Size(147, 36);
            OpcionesComboBox.TabIndex = 7;
            OpcionesComboBox.Text = "Seleccione";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(182, 259);
            label5.Name = "label5";
            label5.Size = new Size(228, 31);
            label5.TabIndex = 8;
            label5.Text = "¿Que desea calcular?";
            // 
            // CalcularPalelogramaButton
            // 
            CalcularPalelogramaButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CalcularPalelogramaButton.Location = new Point(291, 300);
            CalcularPalelogramaButton.Name = "CalcularPalelogramaButton";
            CalcularPalelogramaButton.Size = new Size(206, 44);
            CalcularPalelogramaButton.TabIndex = 9;
            CalcularPalelogramaButton.Text = "CALCULAR";
            CalcularPalelogramaButton.UseVisualStyleBackColor = true;
            CalcularPalelogramaButton.Click += CalcularPalelogramaButton_Click;
            CalcularPalelogramaButton.MouseClick += CalcularPalelogramaButton_MouseClick;
            // 
            // PalelogramoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CalcularPalelogramaButton);
            Controls.Add(label5);
            Controls.Add(OpcionesComboBox);
            Controls.Add(label4);
            Controls.Add(AlturaTexbox);
            Controls.Add(BaseTexbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PalelogramoForm";
            Text = "Palelogramo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox BaseTexbox;
        private TextBox AlturaTexbox;
        private Label label4;
        private ComboBox OpcionesComboBox;
        private Label label5;
        private Button CalcularPalelogramaButton;
    }
}