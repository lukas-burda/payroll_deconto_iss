using ISSDecontoA.Application.Models;
using ISSDecontoA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSDecontoA.Application.Interfaces
{
    public interface IFolhaServices
    {
        public Folha Cadastar(Folha folha);
        public List<FolhaCalculada> ListarTodas();
    }
}
