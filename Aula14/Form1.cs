namespace Aula14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try 
            {
                decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
                if (valorCompra <0 )
                {
                    throw new ApplicationException("Erro. Valor negativo não é aceito.");
                }
                if (valorCompra > 9000)
                {
                    throw new ApplicationException("Valor máximo é 9000 reais");
                }
                valorCompralabel.Text = valorCompra.ToString("c");
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Número muito grande.");
            }

            catch (FormatException)
            {
                MessageBox.Show("Valor de compra inválido,.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
