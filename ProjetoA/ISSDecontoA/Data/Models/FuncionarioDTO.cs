using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSDecontoA.Data.Models
{
    public class FuncionarioDTO
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public FuncionarioDTO(string nome, string cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }
    }
}
