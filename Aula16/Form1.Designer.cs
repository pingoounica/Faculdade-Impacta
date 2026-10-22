namespace Aula16
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
            ConectarButton = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            CommandButton = new Button();
            InsertButton = new Button();
            Updatebutton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // ConectarButton
            // 
            ConectarButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ConectarButton.Location = new Point(139, 54);
            ConectarButton.Name = "ConectarButton";
            ConectarButton.Size = new Size(121, 43);
            ConectarButton.TabIndex = 0;
            ConectarButton.Text = "Conectar";
            ConectarButton.UseVisualStyleBackColor = true;
            ConectarButton.Click += ConectarButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 167);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(629, 259);
            listBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 26);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 2;
            label1.Text = "Clique para conectar ao Banco";
            // 
            // CommandButton
            // 
            CommandButton.Location = new Point(12, 54);
            CommandButton.Name = "CommandButton";
            CommandButton.Size = new Size(121, 39);
            CommandButton.TabIndex = 3;
            CommandButton.Text = "Select";
            CommandButton.UseVisualStyleBackColor = true;
            CommandButton.Click += CommandButton_Click;
            // 
            // InsertButton
            // 
            InsertButton.Location = new Point(266, 54);
            InsertButton.Name = "InsertButton";
            InsertButton.Size = new Size(121, 38);
            InsertButton.TabIndex = 4;
            InsertButton.Text = "Insert";
            InsertButton.UseVisualStyleBackColor = true;
            InsertButton.Click += InsertButton_Click;
            // 
            // Updatebutton
            // 
            Updatebutton.Location = new Point(393, 54);
            Updatebutton.Name = "Updatebutton";
            Updatebutton.Size = new Size(121, 38);
            Updatebutton.TabIndex = 5;
            Updatebutton.Text = "Update";
            Updatebutton.UseVisualStyleBackColor = true;
            Updatebutton.Click += Updatebutton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(520, 55);
            button1.Name = "button1";
            button1.Size = new Size(121, 38);
            button1.TabIndex = 6;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 441);
            Controls.Add(button1);
            Controls.Add(Updatebutton);
            Controls.Add(InsertButton);
            Controls.Add(CommandButton);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(ConectarButton);
            Name = "Form1";
            Text = "Conectar ao Banco de Dados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConectarButton;
        private ListBox listBox1;
        private Label label1;
        private Button CommandButton;
        private Button InsertButton;
        private Button Updatebutton;
        private Button button1;
    }
}
