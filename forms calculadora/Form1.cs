namespace forms_calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void somarButton_Click(object sender, EventArgs e)
        {
            int numero1 =Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resultado = numero1 + numero2;
            
            respostaLabel.Text = $"{resultado}";

        }

        private void subtrairButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resultado = numero1 - numero2;

            respostaLabel.Text = $"{resultado}";
        }

        private void dividirButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resultado = numero1 / numero2;

            respostaLabel.Text = $"{resultado}";
        }

        private void multiplicarButton_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(numero1TextBox.Text);
            int numero2 = Convert.ToInt32(numero2TextBox.Text);
            int resultado = numero1 * numero2;

            respostaLabel.Text = $"{resultado}";
        }
    }
}
