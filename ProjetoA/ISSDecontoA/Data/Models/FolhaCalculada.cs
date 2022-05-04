using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSDecontoA.Data.Models
{
    public class FolhaCalculada
    {
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int horas { get; set; }
        public int valor { get; set; }
        public FuncionarioDTO funcionario { get; set; }

        //calculados
        public double bruto { get; set; }
        public double irrf { get; set; }
        public double inss { get; set; }
        public double fgts { get; set; }
        public double liquido { get; set; }

        public FolhaCalculada(int mes, int ano, int horas, int valor, FuncionarioDTO funcionario, double bruto, double irrf, double inss, double fgts, double liquido)
        {
            Mes = mes;
            Ano = ano;
            this.horas = horas;
            this.valor = valor;
            this.funcionario = funcionario;
            this.bruto = bruto;
            this.irrf = irrf;
            this.inss = inss;
            this.fgts = fgts;
            this.liquido = liquido;
        }
    }
}
