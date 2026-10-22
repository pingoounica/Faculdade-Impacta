namespace ProdutoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            decimal valor = Convert.ToDecimal(valorTextBox.Text);
            int quantidade = Convert.ToInt32(quantidadeTextBox.Text);

            totalTextBox.Text = $"{valor * quantidade:c2}";
        }
    }
}