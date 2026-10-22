namespace ProdutoForm
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
            CalcularButton = new Button();
            valorLabel = new Label();
            quantidadeLabel = new Label();
            totalLabel = new Label();
            valorTextBox = new TextBox();
            quantidadeTextBox = new TextBox();
            totalTextBox = new TextBox();
            SuspendLayout();
            // 
            // CalcularButton
            // 
            CalcularButton.Location = new Point(93, 156);
            CalcularButton.Name = "CalcularButton";
            CalcularButton.Size = new Size(75, 23);
            CalcularButton.TabIndex = 0;
            CalcularButton.Text = "Calcular";
            CalcularButton.UseVisualStyleBackColor = true;
            CalcularButton.Click += button1_Click;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new Point(38, 23);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(39, 15);
            valorLabel.TabIndex = 1;
            valorLabel.Text = "Valor :";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new Point(27, 58);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new Size(69, 15);
            quantidadeLabel.TabIndex = 2;
            quantidadeLabel.Text = "Quantidade";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(38, 98);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(39, 15);
            totalLabel.TabIndex = 3;
            totalLabel.Text = "Total :";
            // 
            // valorTextBox
            // 
            valorTextBox.Location = new Point(124, 20);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.Size = new Size(100, 23);
            valorTextBox.TabIndex = 4;
            // 
            // quantidadeTextBox
            // 
            quantidadeTextBox.Location = new Point(124, 55);
            quantidadeTextBox.Name = "quantidadeTextBox";
            quantidadeTextBox.Size = new Size(100, 23);
            quantidadeTextBox.TabIndex = 5;
            // 
            // totalTextBox
            // 
            totalTextBox.Location = new Point(124, 90);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(100, 23);
            totalTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 220);
            Controls.Add(totalTextBox);
            Controls.Add(quantidadeTextBox);
            Controls.Add(valorTextBox);
            Controls.Add(totalLabel);
            Controls.Add(quantidadeLabel);
            Controls.Add(valorLabel);
            Controls.Add(CalcularButton);
            Name = "Form1";
            Text = "ValorxQuantidade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalcularButton;
        private Label valorLabel;
        private Label quantidadeLabel;
        private Label totalLabel;
        private TextBox valorTextBox;
        private TextBox quantidadeTextBox;
        private TextBox totalTextBox;
    }
}
