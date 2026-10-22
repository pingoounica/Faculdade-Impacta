using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Produto
    {
        // Campos / fields
        private string nome;
        private decimal preco;

        public string Fornecedor { get; set; }

        // Propriedades
        public string Nome
        {
            get 
            {
                return nome;
            }
            set 
            {
                if (value.Length < 3)
                {
                    nome =  "Error";
                }
                else
                {
                    nome = value;
                }
            }

        }
        public decimal Preco
        {
            get
            {
                return preco;
            }
            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
                else
                {
                    preco = 0;
                }
            }
          
        }
    }
}
