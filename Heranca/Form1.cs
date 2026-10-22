namespace Heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exemploButton_Click(object sender, EventArgs e)
        {
            // adiciona novo aluno
            Aluno aluno = new Aluno();
            aluno.Matricula = "2026/2018";
            aluno.Nome = "José da Silva";
            aluno.Email = "jose.silva@email.com";

            // adiciona funcionario
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Maria da Silva";
            funcionario.Email = "maria.silva@email.com";
            funcionario.Cargo = "Professora";
            funcionario.Salario = 6700;

            // exibe os dados do aluno no alunoListbox
            alunoListBox.Items.Add(aluno.Matricula);
            alunoListBox.Items.Add(aluno.Nome);
            alunoListBox.Items.Add(aluno.Email);

            // exibe os dados do funcionario no funcionarioListbox
            funcionarioListBox.Items.Add(funcionario.Nome);
            funcionarioListBox.Items.Add(funcionario.Email);
            funcionarioListBox.Items.Add(funcionario.Cargo);
            funcionarioListBox.Items.Add(funcionario.Salario);
        }

        private void EnviarEmail(CadastroBase dados)
        {
            // Enviando email
            string mensagem = string.Format($"Enviando email para{dados.Nome}");
            alunoListBox.Items.Add(mensagem);
        }

        private void exemplo2Button_Click(object sender, EventArgs e)
        {
            CadastroBase aluno = new Aluno();
            aluno.Nome = "Joaquim Silva";
            CadastroBase funcionario = new Funcionario();
            funcionario.Nome = "Antonio Silva";
            EnviarEmail(aluno);
            EnviarEmail(funcionario);
            
        }
    }
}
