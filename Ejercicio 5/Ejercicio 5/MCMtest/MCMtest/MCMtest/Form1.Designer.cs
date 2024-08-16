namespace MCMtest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNum1 = new TextBox();
            textBoxNum2 = new TextBox();
            textBoxNum3 = new TextBox();
            buttonCalcularMCM = new Button();
            resultLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxNum1
            // 
            textBoxNum1.Location = new Point(190, 93);
            textBoxNum1.Name = "textBoxNum1";
            textBoxNum1.Size = new Size(125, 27);
            textBoxNum1.TabIndex = 0;
            // 
            // textBoxNum2
            // 
            textBoxNum2.Location = new Point(321, 93);
            textBoxNum2.Name = "textBoxNum2";
            textBoxNum2.Size = new Size(125, 27);
            textBoxNum2.TabIndex = 1;
            // 
            // textBoxNum3
            // 
            textBoxNum3.Location = new Point(452, 93);
            textBoxNum3.Name = "textBoxNum3";
            textBoxNum3.Size = new Size(125, 27);
            textBoxNum3.TabIndex = 2;
            // 
            // buttonCalcularMCM
            // 
            buttonCalcularMCM.Font = new Font("Stencil", 9F);
            buttonCalcularMCM.Location = new Point(335, 176);
            buttonCalcularMCM.Name = "buttonCalcularMCM";
            buttonCalcularMCM.Size = new Size(94, 29);
            buttonCalcularMCM.TabIndex = 3;
            buttonCalcularMCM.Text = "Calcular";
            buttonCalcularMCM.UseVisualStyleBackColor = true;
            buttonCalcularMCM.Click += buttonCalcularMCM_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Stencil", 9F);
            resultLabel.Location = new Point(338, 241);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(91, 18);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "Resultado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(295, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 5;
            label1.Text = "Calcular MCM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(resultLabel);
            Controls.Add(buttonCalcularMCM);
            Controls.Add(textBoxNum3);
            Controls.Add(textBoxNum2);
            Controls.Add(textBoxNum1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNum1;
        private TextBox textBoxNum2;
        private TextBox textBoxNum3;
        private Button buttonCalcularMCM;
        private Label resultLabel;
        private Label label1;
    }
}
