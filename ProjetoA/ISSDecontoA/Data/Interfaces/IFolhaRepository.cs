using ISSDecontoA.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSDecontoA.Data.Interfaces
{
    public interface IFolhaRepository
    {
        public void Cadastrar(Folha folha);
        public List<Folha> ListarTodas();
    }
}
