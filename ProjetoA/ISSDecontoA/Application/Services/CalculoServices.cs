using ISSDecontoA.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSDecontoA.Application.Services
{
    public class CalculoServices : ICalculoServices
    {
        public double FGTS(int salarioBruto)
        {
            try
            {
                return (salarioBruto / 0.08);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double FGTS(double salarioBruto)
        {
            return salarioBruto / 0.08;
        }

        public double ImpostoDeRenda(double salarioBruto)
        {
            try
            {
                if (salarioBruto >= 1903.99 && salarioBruto <= 2826.65)
                {
                    var valor = (salarioBruto * 0.075);
                    valor -= 142.80;
                    return valor;
                }
                else if (salarioBruto >= 2826.66 && salarioBruto <= 3751.05)
                {
                    var valor = (salarioBruto * 0.15);
                    valor -= 354.80;
                    return valor;
                }
                else if (salarioBruto >= 3751.06 && salarioBruto <= 4664.68)
                {
                    var valor = (salarioBruto * 0.225);
                    valor -= 636.13;
                    return valor;
                }
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double INSS(double salario) //salariobruto
        {
            try
            {
                if (salario <= 1693.72)
                {
                    return (salario - (salario / 0.08));
                }
                else if (salario >= 1693.73 && salario <= 2822.90) {
                    return (salario - (salario / 0.09));
                }
                else if (salario >= 2822.91 && salario <= 5645.80)
                {
                    return (salario - (salario / 0.11));
                }
                else if (salario >= 5645.81)
                {
                    return (621.03);
                }
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double SalarioBruto(int horas, int valorhora)
        {
            try
            {
                return (horas * valorhora);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public double SalarioLiquido(double salarioBruto, double IR, double INSS)
        {
            return (salarioBruto - ( IR + INSS));
        }
    }
}
