using ISSDecontoA.Application.Interfaces;
using ISSDecontoA.Application.Models;
using ISSDecontoA.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ISSDecontoA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolhaController : ControllerBase
    {
        private readonly IFolhaServices _folhaService;
        public FolhaController(IFolhaServices folhaservices)
        {
            _folhaService = folhaservices;
        }

        [HttpPost]
        [Route("cadastrar")]
        public Folha Post([FromBody] Folha folha)
        {
            return _folhaService.Cadastar(folha);
        }

        [HttpGet]
        [Route("calcular")]
        public List<FolhaCalculada> Get()
        {
            return _folhaService.ListarTodas();
        }
    }
}
