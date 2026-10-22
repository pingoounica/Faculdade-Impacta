namespace Aula14
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
            CompraLabel = new Label();
            valorCompraTextBox = new TextBox();
            okButton = new Button();
            valorLabel = new Label();
            valorCompralabel = new Label();
            SuspendLayout();
            // 
            // CompraLabel
            // 
            CompraLabel.AutoSize = true;
            CompraLabel.Location = new Point(22, 45);
            CompraLabel.Name = "CompraLabel";
            CompraLabel.Size = new Size(98, 15);
            CompraLabel.TabIndex = 0;
            CompraLabel.Text = "Valor da Compra:";
            // 
            // valorCompraTextBox
            // 
            valorCompraTextBox.Location = new Point(149, 42);
            valorCompraTextBox.Name = "valorCompraTextBox";
            valorCompraTextBox.Size = new Size(100, 23);
            valorCompraTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            okButton.Location = new Point(93, 106);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new Point(43, 77);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(0, 15);
            valorLabel.TabIndex = 3;
            // 
            // valorCompralabel
            // 
            valorCompralabel.AutoSize = true;
            valorCompralabel.Location = new Point(35, 76);
            valorCompralabel.Name = "valorCompralabel";
            valorCompralabel.Size = new Size(0, 15);
            valorCompralabel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 223);
            Controls.Add(valorCompralabel);
            Controls.Add(valorLabel);
            Controls.Add(okButton);
            Controls.Add(valorCompraTextBox);
            Controls.Add(CompraLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CompraLabel;
        private TextBox valorCompraTextBox;
        private Button okButton;
        private Label valorLabel;
        private Label valorCompralabel;
    }
}
