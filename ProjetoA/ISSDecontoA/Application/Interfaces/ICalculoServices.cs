using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSDecontoA.Application.Interfaces
{
    public interface ICalculoServices
    {
        public double SalarioBruto(int horas, int valorhora);
        public double SalarioLiquido(double salarioBruto, double IR, double INSS);
        public double ImpostoDeRenda(double salarioBruto);
        public double INSS(double salarioBruto);
        public double FGTS(double salarioBruto);
    }
}
