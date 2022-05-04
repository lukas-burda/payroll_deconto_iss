using ISSDecontoA.Application.Interfaces;
using ISSDecontoA.Application.Models;
using ISSDecontoA.Data.Interfaces;
using ISSDecontoA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSDecontoA.Application.Services
{
    public class FolhaServices : IFolhaServices
    {
        private readonly IFolhaRepository _repository;
        private readonly ICalculoServices _calculoservices;
        public FolhaServices(IFolhaRepository folhaRepository, ICalculoServices calculoservices)
        {
            _repository = folhaRepository;
            _calculoservices = calculoservices;
        }

        public Folha Cadastar(Folha folha)
        {
            try
            {
                if (folha != null)
                {
                    _repository.Cadastrar(folha);
                }
                return folha;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<FolhaCalculada> ListarTodas()
        {
            return this.CalcularListaDeFolhas(_repository.ListarTodas());
        }

        public List<FolhaCalculada> CalcularListaDeFolhas(List<Folha> folhas)
        {
            try
            {
                var folhasCalculadas = new List<FolhaCalculada>();

                foreach (var f in folhas)
                {
                    var bruto = _calculoservices.SalarioBruto(f.horas, f.valor);
                    folhasCalculadas.Add(new FolhaCalculada(
                        f.Mes,
                        f.Ano,
                        f.horas,
                        f.valor,
                        new FuncionarioDTO(f.Funcionario.Nome, f.Funcionario.Cpf),
                        bruto,
                        _calculoservices.ImpostoDeRenda(bruto),
                        _calculoservices.INSS(bruto), 
                        _calculoservices.FGTS(bruto),
                        _calculoservices.SalarioLiquido(
                            bruto,
                            _calculoservices.ImpostoDeRenda(bruto),
                            _calculoservices.INSS(bruto)))
                       );
                }

                return folhasCalculadas;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
