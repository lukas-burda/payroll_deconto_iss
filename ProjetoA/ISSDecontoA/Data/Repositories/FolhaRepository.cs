using ISSDecontoA.Application.Models;
using ISSDecontoA.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISSDecontoA.Data.Repositories
{
    public class FolhaRepository : IFolhaRepository
    {
        private new List<Folha> folhas = new List<Folha>();

        public void Cadastrar(Folha folha)
        {
            try
            {
                if (folha != null)
                {
                    this.folhas.Add(folha);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Folha> ListarTodas()
        {
            return this.folhas;
        }
    }
}
