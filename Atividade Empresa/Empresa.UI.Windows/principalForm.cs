namespace Empresa.UI.Windows
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new ClientesForm();
            f.ShowDialog();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteIncluirForm f = new ClienteIncluirForm();
            f.ShowDialog();
        }
    }
}
