namespace Atividade_Visualizador_de_imagens
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
            ImagemListBox = new ListBox();
            FavoritosListBox = new ListBox();
            AdicionarButton = new Button();
            ImagemPictureBox = new PictureBox();
            removerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ImagemPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ImagemListBox
            // 
            ImagemListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ImagemListBox.FormattingEnabled = true;
            ImagemListBox.Location = new Point(12, 12);
            ImagemListBox.Name = "ImagemListBox";
            ImagemListBox.Size = new Size(333, 94);
            ImagemListBox.TabIndex = 0;
            ImagemListBox.SelectedIndexChanged += ImagemListBox_SelectedIndexChanged;
            // 
            // FavoritosListBox
            // 
            FavoritosListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FavoritosListBox.FormattingEnabled = true;
            FavoritosListBox.Location = new Point(12, 121);
            FavoritosListBox.Name = "FavoritosListBox";
            FavoritosListBox.Size = new Size(333, 94);
            FavoritosListBox.TabIndex = 1;
            FavoritosListBox.SelectedIndexChanged += FavoritosListBox_SelectedIndexChanged;
            // 
            // AdicionarButton
            // 
            AdicionarButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AdicionarButton.Location = new Point(12, 252);
            AdicionarButton.Name = "AdicionarButton";
            AdicionarButton.Size = new Size(156, 23);
            AdicionarButton.TabIndex = 2;
            AdicionarButton.Text = "Adicionar aos Favoritos";
            AdicionarButton.UseVisualStyleBackColor = true;
            AdicionarButton.Click += AdicionarButton_Click;
            // 
            // ImagemPictureBox
            // 
            ImagemPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ImagemPictureBox.BorderStyle = BorderStyle.FixedSingle;
            ImagemPictureBox.Location = new Point(12, 304);
            ImagemPictureBox.Name = "ImagemPictureBox";
            ImagemPictureBox.Size = new Size(333, 268);
            ImagemPictureBox.TabIndex = 3;
            ImagemPictureBox.TabStop = false;
            // 
            // removerButton
            // 
            removerButton.Location = new Point(174, 252);
            removerButton.Name = "removerButton";
            removerButton.Size = new Size(171, 23);
            removerButton.TabIndex = 4;
            removerButton.Text = "Remover dos Favoritos";
            removerButton.UseVisualStyleBackColor = true;
            removerButton.Click += removerButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 584);
            Controls.Add(removerButton);
            Controls.Add(ImagemPictureBox);
            Controls.Add(AdicionarButton);
            Controls.Add(FavoritosListBox);
            Controls.Add(ImagemListBox);
            Name = "Form1";
            Text = "Visualizador de Imagens";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ImagemPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ImagemListBox;
        private ListBox FavoritosListBox;
        private Button AdicionarButton;
        private PictureBox ImagemPictureBox;
        private Button removerButton;
    }
}
