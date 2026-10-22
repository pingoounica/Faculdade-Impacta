using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Funcionario:CadastroBase
    {
        public string Cargo { get; set;}
        public decimal Salario { get; set;}
    }
}
