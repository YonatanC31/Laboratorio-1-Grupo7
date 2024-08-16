namespace Ejercicio1.Ejercicio1Calculadora
{
    partial class CalculatorForm
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
            FirstNumberTexbox = new TextBox();
            SecondNumberTexbox = new TextBox();
            SumaButton = new Button();
            RestButton = new Button();
            MultiplierButton = new Button();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(287, 81);
            label1.Name = "label1";
            label1.Size = new Size(236, 41);
            label1.TabIndex = 0;
            label1.Text = "CALCULADORA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(139, 152);
            label2.Name = "label2";
            label2.Size = new Size(235, 28);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el primer numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(139, 193);
            label3.Name = "label3";
            label3.Size = new Size(258, 28);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el segundo  numero:";
            // 
            // FirstNumberTexbox
            // 
            FirstNumberTexbox.Location = new Point(380, 153);
            FirstNumberTexbox.Name = "FirstNumberTexbox";
            FirstNumberTexbox.Size = new Size(272, 27);
            FirstNumberTexbox.TabIndex = 3;
            // 
            // SecondNumberTexbox
            // 
            SecondNumberTexbox.Location = new Point(409, 193);
            SecondNumberTexbox.Name = "SecondNumberTexbox";
            SecondNumberTexbox.Size = new Size(243, 27);
            SecondNumberTexbox.TabIndex = 4;
            // 
            // SumaButton
            // 
            SumaButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SumaButton.Location = new Point(139, 284);
            SumaButton.Name = "SumaButton";
            SumaButton.Size = new Size(145, 44);
            SumaButton.TabIndex = 5;
            SumaButton.Text = "SUMAR";
            SumaButton.UseVisualStyleBackColor = true;
            SumaButton.Click += SumaButton_Click;
            SumaButton.MouseEnter += SumaButton_MouseEnter_1;
            // 
            // RestButton
            // 
            RestButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RestButton.Location = new Point(307, 284);
            RestButton.Name = "RestButton";
            RestButton.Size = new Size(147, 44);
            RestButton.TabIndex = 6;
            RestButton.Text = "RESTAR";
            RestButton.UseVisualStyleBackColor = true;
            RestButton.Click += RestButton_Click;
            RestButton.MouseLeave += RestButton_MouseLeave_1;
            // 
            // MultiplierButton
            // 
            MultiplierButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MultiplierButton.Location = new Point(472, 284);
            MultiplierButton.Name = "MultiplierButton";
            MultiplierButton.Size = new Size(180, 44);
            MultiplierButton.TabIndex = 7;
            MultiplierButton.Text = "MULTIPLICAR";
            MultiplierButton.UseVisualStyleBackColor = true;
            MultiplierButton.Click += MultiplierButton_Click;
            MultiplierButton.MouseDown += MultiplierButton_MouseDown_1;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResultLabel.Location = new Point(284, 383);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(0, 31);
            ResultLabel.TabIndex = 8;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultLabel);
            Controls.Add(MultiplierButton);
            Controls.Add(RestButton);
            Controls.Add(SumaButton);
            Controls.Add(SecondNumberTexbox);
            Controls.Add(FirstNumberTexbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox FirstNumberTexbox;
        private TextBox SecondNumberTexbox;
        private Button SumaButton;
        private Button RestButton;
        private Button MultiplierButton;
        private Label ResultLabel;
    }
}