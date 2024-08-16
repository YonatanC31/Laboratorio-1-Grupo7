namespace Ejercicio3.AreaCalculator.Views
{
    partial class ElipseForm
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
            ElipseButton = new Button();
            label5 = new Label();
            OpcionesElipseTexbox = new ComboBox();
            label4 = new Label();
            EjeMenorTexbox = new TextBox();
            EjeMayorTexbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // ElipseButton
            // 
            ElipseButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ElipseButton.Location = new Point(281, 298);
            ElipseButton.Name = "ElipseButton";
            ElipseButton.Size = new Size(206, 44);
            ElipseButton.TabIndex = 18;
            ElipseButton.Text = "CALCULAR";
            ElipseButton.UseVisualStyleBackColor = true;
            ElipseButton.Click += ElipseButton_Click;
            ElipseButton.MouseClick += ElipseButton_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(175, 247);
            label5.Name = "label5";
            label5.Size = new Size(228, 31);
            label5.TabIndex = 17;
            label5.Text = "¿Que desea calcular?";
            // 
            // OpcionesElipseTexbox
            // 
            OpcionesElipseTexbox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OpcionesElipseTexbox.FormattingEnabled = true;
            OpcionesElipseTexbox.Items.AddRange(new object[] { "Area", "Perimetro" });
            OpcionesElipseTexbox.Location = new Point(409, 246);
            OpcionesElipseTexbox.Name = "OpcionesElipseTexbox";
            OpcionesElipseTexbox.Size = new Size(147, 36);
            OpcionesElipseTexbox.TabIndex = 16;
            OpcionesElipseTexbox.Text = "Seleccione";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(237, 100);
            label4.Name = "label4";
            label4.Size = new Size(353, 31);
            label4.TabIndex = 15;
            label4.Text = "ESTAMOS CALCULANDO ELIPSE";
            // 
            // EjeMenorTexbox
            // 
            EjeMenorTexbox.Location = new Point(310, 202);
            EjeMenorTexbox.Name = "EjeMenorTexbox";
            EjeMenorTexbox.Size = new Size(388, 27);
            EjeMenorTexbox.TabIndex = 14;
            // 
            // EjeMayorTexbox
            // 
            EjeMayorTexbox.Location = new Point(310, 146);
            EjeMayorTexbox.Name = "EjeMayorTexbox";
            EjeMayorTexbox.Size = new Size(388, 27);
            EjeMayorTexbox.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 196);
            label3.Name = "label3";
            label3.Size = new Size(209, 31);
            label3.TabIndex = 12;
            label3.Text = "Ingrese Eje Menor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 140);
            label2.Name = "label2";
            label2.Size = new Size(208, 31);
            label2.TabIndex = 11;
            label2.Text = "Ingrese Eje Mayor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 59);
            label1.Name = "label1";
            label1.Size = new Size(595, 31);
            label1.TabIndex = 10;
            label1.Text = "BIENVENIDO AL CALCULADOR DE AREA Y PERIMETRO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(378, 358);
            label6.Name = "label6";
            label6.Size = new Size(0, 31);
            label6.TabIndex = 19;
            // 
            // ElipseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(ElipseButton);
            Controls.Add(label5);
            Controls.Add(OpcionesElipseTexbox);
            Controls.Add(label4);
            Controls.Add(EjeMenorTexbox);
            Controls.Add(EjeMayorTexbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ElipseForm";
            Text = "ElipseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ElipseButton;
        private Label label5;
        private ComboBox OpcionesElipseTexbox;
        private Label label4;
        private TextBox EjeMenorTexbox;
        private TextBox EjeMayorTexbox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}