namespace Ejercicio3.AreaCalculator
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
            PalelogramoButton = new Button();
            ElipseButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 81);
            label1.Name = "label1";
            label1.Size = new Size(417, 31);
            label1.TabIndex = 0;
            label1.Text = "CALCULADOR DE AREA Y PERIMETRO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 154);
            label2.Name = "label2";
            label2.Size = new Size(395, 31);
            label2.TabIndex = 1;
            label2.Text = "Seleccione que  figura desea calcular";
            // 
            // PalelogramoButton
            // 
            PalelogramoButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PalelogramoButton.Location = new Point(196, 228);
            PalelogramoButton.Name = "PalelogramoButton";
            PalelogramoButton.Size = new Size(206, 44);
            PalelogramoButton.TabIndex = 2;
            PalelogramoButton.Text = "PALELOGRAMO";
            PalelogramoButton.UseVisualStyleBackColor = true;
            PalelogramoButton.Click += PalelogramoButton_Click;
            // 
            // ElipseButton
            // 
            ElipseButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ElipseButton.Location = new Point(450, 228);
            ElipseButton.Name = "ElipseButton";
            ElipseButton.Size = new Size(163, 44);
            ElipseButton.TabIndex = 3;
            ElipseButton.Text = "ELIPSE";
            ElipseButton.UseVisualStyleBackColor = true;
            ElipseButton.Click += ElipseButton_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(297, 341);
            button1.Name = "button1";
            button1.Size = new Size(206, 44);
            button1.TabIndex = 4;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ElipseButton);
            Controls.Add(PalelogramoButton);
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
        private Button PalelogramoButton;
        private Button ElipseButton;
        private Button button1;
    }
}