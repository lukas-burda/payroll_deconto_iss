using ISSDecontoB.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ISSDecontoB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolhaController : ControllerBase
    {
        [HttpGet]
        //[Route("consultar/{cpf}/{mes}/{ano}")]
        [Route("consultar")]
        public async Task<List<Folha>> Consultar()
        {
            using var client = new HttpClient();

            var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:5001/api/Folha/calcular");

            var response = await client.SendAsync(request);

            var data = response.Content.ReadAsStringAsync();

            List<Folha> folhas = JsonConvert.DeserializeObject<List<Folha>>(data.Result);

            return folhas;
        }

    }
}
