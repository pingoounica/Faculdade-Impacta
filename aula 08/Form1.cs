namespace aula_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bem-vindo ao Curso de C#";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bem-vindo ao Curso de C#";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
