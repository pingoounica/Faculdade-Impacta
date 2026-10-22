namespace Empresa.Db
{
    // Helper para acesso a dados
    public static class Db
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EmpresaDb;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
            }
        }
    }
}