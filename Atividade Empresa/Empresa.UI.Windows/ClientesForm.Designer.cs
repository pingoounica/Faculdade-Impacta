namespace Empresa.UI.Windows
{
    partial class ClientesForm
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            novoButton = new Button();
            alterarButton = new Button();
            excluirButton = new Button();
            sairButton = new Button();
            confirmarIncluirButton = new Button();
            confirmarAlterarButton = new Button();
            confirmarExcluirButton = new Button();
            voltarButton = new Button();
            conteudoPanel = new Panel();
            fichaPanel = new Panel();
            telefoneTextBox = new TextBox();
            telefoneLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            nomeTextBox = new TextBox();
            nomeLabel = new Label();
            idTextBox = new TextBox();
            idLabel = new Label();
            listaDataGridView = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            conteudoPanel.SuspendLayout();
            fichaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 59);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(novoButton);
            flowLayoutPanel1.Controls.Add(alterarButton);
            flowLayoutPanel1.Controls.Add(excluirButton);
            flowLayoutPanel1.Controls.Add(sairButton);
            flowLayoutPanel1.Controls.Add(confirmarIncluirButton);
            flowLayoutPanel1.Controls.Add(confirmarAlterarButton);
            flowLayoutPanel1.Controls.Add(confirmarExcluirButton);
            flowLayoutPanel1.Controls.Add(voltarButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 7, 0, 0);
            flowLayoutPanel1.Size = new Size(1020, 59);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // novoButton
            // 
            novoButton.Location = new Point(13, 10);
            novoButton.Name = "novoButton";
            novoButton.Size = new Size(75, 23);
            novoButton.TabIndex = 0;
            novoButton.Text = "Novo";
            novoButton.UseVisualStyleBackColor = true;
            novoButton.Click += novoButton_Click;
            // 
            // alterarButton
            // 
            alterarButton.Location = new Point(94, 10);
            alterarButton.Name = "alterarButton";
            alterarButton.Size = new Size(75, 23);
            alterarButton.TabIndex = 1;
            alterarButton.Text = "Alterar";
            alterarButton.UseVisualStyleBackColor = true;
            alterarButton.Click += alterarButton_Click;
            // 
            // excluirButton
            // 
            excluirButton.Location = new Point(175, 10);
            excluirButton.Name = "excluirButton";
            excluirButton.Size = new Size(75, 23);
            excluirButton.TabIndex = 2;
            excluirButton.Text = "Excluir";
            excluirButton.UseVisualStyleBackColor = true;
            excluirButton.Click += excluirButton_Click;
            // 
            // sairButton
            // 
            sairButton.Location = new Point(256, 10);
            sairButton.Name = "sairButton";
            sairButton.Size = new Size(75, 23);
            sairButton.TabIndex = 3;
            sairButton.Text = "Sair";
            sairButton.UseVisualStyleBackColor = true;
            sairButton.Click += sairButton_Click;
            // 
            // confirmarIncluirButton
            // 
            confirmarIncluirButton.Location = new Point(337, 10);
            confirmarIncluirButton.Name = "confirmarIncluirButton";
            confirmarIncluirButton.Size = new Size(75, 23);
            confirmarIncluirButton.TabIndex = 4;
            confirmarIncluirButton.Text = "Gravar";
            confirmarIncluirButton.UseVisualStyleBackColor = true;
            confirmarIncluirButton.Click += confirmarIncluirButton_Click;
            // 
            // confirmarAlterarButton
            // 
            confirmarAlterarButton.Location = new Point(418, 10);
            confirmarAlterarButton.Name = "confirmarAlterarButton";
            confirmarAlterarButton.Size = new Size(75, 23);
            confirmarAlterarButton.TabIndex = 5;
            confirmarAlterarButton.Text = "Alterar";
            confirmarAlterarButton.UseVisualStyleBackColor = true;
            confirmarAlterarButton.Click += confirmarAlterarButton_Click;
            // 
            // confirmarExcluirButton
            // 
            confirmarExcluirButton.Location = new Point(499, 10);
            confirmarExcluirButton.Name = "confirmarExcluirButton";
            confirmarExcluirButton.Size = new Size(123, 23);
            confirmarExcluirButton.TabIndex = 6;
            confirmarExcluirButton.Text = "Confirmar Exclusão";
            confirmarExcluirButton.UseVisualStyleBackColor = true;
            confirmarExcluirButton.Click += confirmarExcluirButton_Click;
            // 
            // voltarButton
            // 
            voltarButton.Location = new Point(628, 10);
            voltarButton.Name = "voltarButton";
            voltarButton.Size = new Size(75, 23);
            voltarButton.TabIndex = 7;
            voltarButton.Text = "Voltar";
            voltarButton.UseVisualStyleBackColor = true;
            voltarButton.Click += voltarButton_Click;
            // 
            // conteudoPanel
            // 
            conteudoPanel.Controls.Add(fichaPanel);
            conteudoPanel.Controls.Add(listaDataGridView);
            conteudoPanel.Dock = DockStyle.Fill;
            conteudoPanel.Location = new Point(0, 0);
            conteudoPanel.Name = "conteudoPanel";
            conteudoPanel.Padding = new Padding(10);
            conteudoPanel.Size = new Size(1020, 410);
            conteudoPanel.TabIndex = 1;
            // 
            // fichaPanel
            // 
            fichaPanel.Controls.Add(telefoneTextBox);
            fichaPanel.Controls.Add(telefoneLabel);
            fichaPanel.Controls.Add(emailTextBox);
            fichaPanel.Controls.Add(emailLabel);
            fichaPanel.Controls.Add(nomeTextBox);
            fichaPanel.Controls.Add(nomeLabel);
            fichaPanel.Controls.Add(idTextBox);
            fichaPanel.Controls.Add(idLabel);
            fichaPanel.Location = new Point(24, 21);
            fichaPanel.Name = "fichaPanel";
            fichaPanel.Size = new Size(496, 352);
            fichaPanel.TabIndex = 1;
            // 
            // telefoneTextBox
            // 
            telefoneTextBox.Location = new Point(84, 106);
            telefoneTextBox.Name = "telefoneTextBox";
            telefoneTextBox.Size = new Size(138, 23);
            telefoneTextBox.TabIndex = 15;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new Point(20, 106);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new Size(58, 15);
            telefoneLabel.TabIndex = 14;
            telefoneLabel.Text = "Telefone: ";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(84, 77);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(304, 23);
            emailTextBox.TabIndex = 13;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(20, 80);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(44, 15);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "E-mail:";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Location = new Point(84, 48);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(304, 23);
            nomeTextBox.TabIndex = 11;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(20, 46);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(46, 15);
            nomeLabel.TabIndex = 10;
            nomeLabel.Text = "Nome: ";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(84, 19);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(138, 23);
            idTextBox.TabIndex = 9;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(20, 22);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 8;
            idLabel.Text = "ID:";
            // 
            // listaDataGridView
            // 
            listaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaDataGridView.Location = new Point(543, 21);
            listaDataGridView.Name = "listaDataGridView";
            listaDataGridView.Size = new Size(451, 352);
            listaDataGridView.TabIndex = 0;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 469);
            Controls.Add(conteudoPanel);
            Controls.Add(panel1);
            Name = "ClientesForm";
            Text = "Clientes";
            Load += ClientesForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            conteudoPanel.ResumeLayout(false);
            fichaPanel.ResumeLayout(false);
            fichaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button novoButton;
        private Button alterarButton;
        private Button excluirButton;
        private Button sairButton;
        private Button confirmarIncluirButton;
        private Button confirmarAlterarButton;
        private Button confirmarExcluirButton;
        private Panel conteudoPanel;
        private Panel fichaPanel;
        private DataGridView listaDataGridView;
        private TextBox telefoneTextBox;
        private Label telefoneLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox nomeTextBox;
        private Label nomeLabel;
        private TextBox idTextBox;
        private Label idLabel;
        private Button voltarButton;
    }
}