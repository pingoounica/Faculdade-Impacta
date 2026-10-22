namespace produto
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
            valorLabel = new Label();
            quantidadeLabel = new Label();
            valorTextBox = new TextBox();
            quantidadeTextBox = new TextBox();
            okButton = new Button();
            totalLabel = new Label();
            totalTextBox = new TextBox();
            SuspendLayout();
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new Point(31, 18);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new Size(39, 15);
            valorLabel.TabIndex = 0;
            valorLabel.Text = "Valor :";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new Point(31, 42);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new Size(75, 15);
            quantidadeLabel.TabIndex = 1;
            quantidadeLabel.Text = "Quantidade :";
            // 
            // valorTextBox
            // 
            valorTextBox.Location = new Point(109, 12);
            valorTextBox.Name = "valorTextBox";
            valorTextBox.Size = new Size(100, 23);
            valorTextBox.TabIndex = 2;
            // 
            // quantidadeTextBox
            // 
            quantidadeTextBox.Location = new Point(109, 39);
            quantidadeTextBox.Name = "quantidadeTextBox";
            quantidadeTextBox.Size = new Size(100, 23);
            quantidadeTextBox.TabIndex = 3;
            // 
            // okButton
            // 
            okButton.Location = new Point(58, 120);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 4;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(31, 71);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(39, 15);
            totalLabel.TabIndex = 5;
            totalLabel.Text = "Total :";
            // 
            // totalTextBox
            // 
            totalTextBox.Location = new Point(109, 68);
            totalTextBox.Name = "totalTextBox";
            totalTextBox.Size = new Size(100, 23);
            totalTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 204);
            Controls.Add(totalTextBox);
            Controls.Add(totalLabel);
            Controls.Add(okButton);
            Controls.Add(quantidadeTextBox);
            Controls.Add(valorTextBox);
            Controls.Add(quantidadeLabel);
            Controls.Add(valorLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label valorLabel;
        private Label quantidadeLabel;
        private TextBox valorTextBox;
        private TextBox quantidadeTextBox;
        private Button okButton;
        private Label totalLabel;
        private TextBox totalTextBox;
    }
}
