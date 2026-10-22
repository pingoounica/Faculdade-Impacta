namespace Tabuada_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            tabuadaListBox.Items.Clear();
            int tabuada = Convert.ToInt32(tabuadaTextBox.Text);
            for (int i = 1; i <= 10; i++)
            {
                string linha = string.Format($"{tabuada} X {i} = {i * tabuada}");
                tabuadaListBox.Items.Add(linha);
            }
        }
    }
}
