namespace Empresa.UI.Windows
{
    partial class ClienteIncluirForm
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
            idLabel = new Label();
            idTextBox = new TextBox();
            nomeLabel = new Label();
            nomeTextBox = new TextBox();
            telefoneTextBox = new TextBox();
            telefoneLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            incluirButton = new Button();
            voltarButton = new Button();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(31, 24);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(95, 21);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(138, 23);
            idTextBox.TabIndex = 1;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(31, 48);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(46, 15);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome: ";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(95, 50);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(304, 23);
            nomeTextBox.TabIndex = 3;
            // 
            // telefoneTextBox
            // 
            telefoneTextBox.Location = new Point(95, 108);
            telefoneTextBox.Name = "telefoneTextBox";
            telefoneTextBox.Size = new Size(138, 23);
            telefoneTextBox.TabIndex = 7;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new Point(31, 108);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new Size(58, 15);
            telefoneLabel.TabIndex = 6;
            telefoneLabel.Text = "Telefone: ";
            telefoneLabel.Click += telefoneLabel_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(95, 79);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(304, 23);
            emailTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(31, 82);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(44, 15);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "E-mail:";
            // 
            // incluirButton
            // 
            incluirButton.Location = new Point(243, 194);
            incluirButton.Name = "incluirButton";
            incluirButton.Size = new Size(75, 23);
            incluirButton.TabIndex = 8;
            incluirButton.Text = "Incluir";
            incluirButton.UseVisualStyleBackColor = true;
            // 
            // voltarButton
            // 
            voltarButton.Location = new Point(324, 194);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(75, 23);
            voltarButton.TabIndex = 9;
            voltarButton.Text = "Voltar";
            voltarButton.UseVisualStyleBackColor = true;
            // 
            // ClienteIncluirForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 270);
            Controls.Add(voltarButton);
            Controls.Add(incluirButton);
            Controls.Add(telefoneTextBox);
            Controls.Add(telefoneLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(nomeTextBox);
            Controls.Add(nomeLabel);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteIncluirForm";
            Text = "Inclusão de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private TextBox idTextBox;
        private Label nomeLabel;
        private TextBox nomeTextBox;
        private TextBox telefoneTextBox;
        private Label telefoneLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private Button incluirButton;
        private Button voltarButton;
    }
}