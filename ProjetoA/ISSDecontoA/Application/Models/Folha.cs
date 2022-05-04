using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSDecontoA.Application.Models
{
    public class Folha
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int horas{ get; set; }
        public int valor { get; set; }
        public Funcionario Funcionario { get; set; }

    }
}
