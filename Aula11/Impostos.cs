namespace Aula11
{
    public class Impostos
    {
        private decimal _porcentagemIndividual;

        public Impostos()
        {
            _porcentagemIndividual = 0.01m;
        }

        public Impostos(decimal porcentagemIndividual)
        {
            _porcentagemIndividual = porcentagemIndividual;
        }

        // Método com dois parâmetros
        public decimal CalcularISS(string estado, decimal valorServico)
        {
            decimal porcentagem;

            if (estado == "SP")
            {
                porcentagem = 0.06m;
            }
            else
            {
                porcentagem = 0.05m;
            }

            decimal valorImposto = valorServico * porcentagem;

            return valorImposto;
        }

        // Método com três parâmetros
        public decimal CalcularISS(string estado, decimal valorServico, bool empresaIndividual)
        {
            if (empresaIndividual)
            {
                return valorServico * _porcentagemIndividual;
            }

            return CalcularISS(estado, valorServico);
        }
    }
}