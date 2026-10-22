namespace Heranca
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
            exemploButton = new Button();
            alunoListBox = new ListBox();
            funcionarioListBox = new ListBox();
            exemplo2Button = new Button();
            SuspendLayout();
            // 
            // exemploButton
            // 
            exemploButton.Location = new Point(53, 29);
            exemploButton.Name = "exemploButton";
            exemploButton.Size = new Size(202, 35);
            exemploButton.TabIndex = 0;
            exemploButton.Text = "Exemplo Herança";
            exemploButton.UseVisualStyleBackColor = true;
            exemploButton.Click += exemploButton_Click;
            // 
            // alunoListBox
            // 
            alunoListBox.FormattingEnabled = true;
            alunoListBox.Location = new Point(53, 111);
            alunoListBox.Name = "alunoListBox";
            alunoListBox.Size = new Size(202, 94);
            alunoListBox.TabIndex = 1;
            // 
            // funcionarioListBox
            // 
            funcionarioListBox.FormattingEnabled = true;
            funcionarioListBox.Location = new Point(53, 220);
            funcionarioListBox.Name = "funcionarioListBox";
            funcionarioListBox.Size = new Size(201, 94);
            funcionarioListBox.TabIndex = 2;
            // 
            // exemplo2Button
            // 
            exemplo2Button.Location = new Point(53, 70);
            exemplo2Button.Name = "exemplo2Button";
            exemplo2Button.Size = new Size(202, 35);
            exemplo2Button.TabIndex = 3;
            exemplo2Button.Text = "Exemplo Herança 2";
            exemplo2Button.UseVisualStyleBackColor = true;
            exemplo2Button.Click += exemplo2Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 413);
            Controls.Add(exemplo2Button);
            Controls.Add(funcionarioListBox);
            Controls.Add(alunoListBox);
            Controls.Add(exemploButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button exemploButton;
        private ListBox alunoListBox;
        private ListBox funcionarioListBox;
        private Button exemplo2Button;
    }
}
