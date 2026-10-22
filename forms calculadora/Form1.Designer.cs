namespace forms_calculadora
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
            label1 = new Label();
            numero1TextBox = new TextBox();
            numero2TextBox = new TextBox();
            label2 = new Label();
            somarButton = new Button();
            dividirButton = new Button();
            multiplicarButton = new Button();
            subtrairButton = new Button();
            label3 = new Label();
            respostaLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 17);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Número 1";
            // 
            // numero1TextBox
            // 
            numero1TextBox.Location = new Point(105, 9);
            numero1TextBox.Name = "numero1TextBox";
            numero1TextBox.Size = new Size(100, 23);
            numero1TextBox.TabIndex = 1;
            // 
            // numero2TextBox
            // 
            numero2TextBox.Location = new Point(105, 43);
            numero2TextBox.Name = "numero2TextBox";
            numero2TextBox.Size = new Size(100, 23);
            numero2TextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 46);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Número 2";
            // 
            // somarButton
            // 
            somarButton.Location = new Point(45, 88);
            somarButton.Name = "somarButton";
            somarButton.Size = new Size(75, 23);
            somarButton.TabIndex = 4;
            somarButton.Text = "Somar";
            somarButton.UseVisualStyleBackColor = true;
            somarButton.Click += somarButton_Click;
            // 
            // dividirButton
            // 
            dividirButton.Location = new Point(45, 130);
            dividirButton.Name = "dividirButton";
            dividirButton.Size = new Size(75, 23);
            dividirButton.TabIndex = 5;
            dividirButton.Text = "Dividir";
            dividirButton.UseVisualStyleBackColor = true;
            dividirButton.Click += dividirButton_Click;
            // 
            // multiplicarButton
            // 
            multiplicarButton.Location = new Point(130, 130);
            multiplicarButton.Name = "multiplicarButton";
            multiplicarButton.Size = new Size(75, 23);
            multiplicarButton.TabIndex = 6;
            multiplicarButton.Text = "Multiplicar";
            multiplicarButton.UseVisualStyleBackColor = true;
            multiplicarButton.Click += multiplicarButton_Click;
            // 
            // subtrairButton
            // 
            subtrairButton.Location = new Point(130, 88);
            subtrairButton.Name = "subtrairButton";
            subtrairButton.Size = new Size(75, 23);
            subtrairButton.TabIndex = 7;
            subtrairButton.Text = "Subtrair";
            subtrairButton.UseVisualStyleBackColor = true;
            subtrairButton.Click += subtrairButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 195);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 8;
            label3.Text = "Resposta:";
            // 
            // respostaLabel
            // 
            respostaLabel.AutoSize = true;
            respostaLabel.Location = new Point(86, 195);
            respostaLabel.Name = "respostaLabel";
            respostaLabel.Size = new Size(13, 15);
            respostaLabel.TabIndex = 9;
            respostaLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 271);
            Controls.Add(respostaLabel);
            Controls.Add(label3);
            Controls.Add(subtrairButton);
            Controls.Add(multiplicarButton);
            Controls.Add(dividirButton);
            Controls.Add(somarButton);
            Controls.Add(numero2TextBox);
            Controls.Add(label2);
            Controls.Add(numero1TextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox numero1TextBox;
        private TextBox numero2TextBox;
        private Label label2;
        private Button somarButton;
        private Button dividirButton;
        private Button multiplicarButton;
        private Button subtrairButton;
        private Label label3;
        private Label respostaLabel;
    }
}
