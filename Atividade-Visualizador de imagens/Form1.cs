namespace Atividade_Visualizador_de_imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\windows\web\wallpaper", "*.jpg", SearchOption.AllDirectories);
            ImagemListBox.Items.AddRange(arquivos);

            // ler do arquivo favoritos
            string path = ObterNomeArquivoConfiguracao();

            if(File.Exists(path))
            {
                var reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                string arquivo = reader.ReadLine();
                FavoritosListBox.Items.Add(arquivo);
                }
                reader.Close();
            }
        }

        private void ImagemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImagemPictureBox.ImageLocation = ImagemListBox.Text;
            ImagemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private string ObterNomeArquivoConfiguracao()
        {
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "imagemConfig.txt";
            string path = Path.Combine(pasta, arquivo);
            return path;
        }

        private void AdicionarButton_Click(object sender, EventArgs e)
        {
            FavoritosListBox.Items.Add(ImagemListBox.Text);
            GravarConfiguracao();
        }
        
        private void GravarConfiguracao()
        {
            string path = ObterNomeArquivoConfiguracao();
            var writer = new StreamWriter(path);
            foreach (string arquivo in FavoritosListBox.Items)
            {
                writer.WriteLine(arquivo);
            }
            writer.Close();
        }

        private void FavoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImagemPictureBox.ImageLocation = FavoritosListBox.Text;
            ImagemPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void removerButton_Click(object sender, EventArgs e)
        {
            if (FavoritosListBox.SelectedItem!=null)
            {
                string itemSelecionado = FavoritosListBox.SelectedItem.ToString();
                FavoritosListBox.Items.Remove(itemSelecionado);
                GravarConfiguracao();
            }
        }
    }
}
