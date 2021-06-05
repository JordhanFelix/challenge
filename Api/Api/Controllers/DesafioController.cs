using Api.Models.Desafios;
using Api.Models.Take;
using Api.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/v1/challenge")]
    [ApiController]
    public class DesafioController : ControllerBase
    {

        private readonly IGitHubService _gitHubService;
        public DesafioController(IGitHubService gitHubService)
        {
            this._gitHubService = gitHubService;
        }

        [SwaggerResponse(statusCode: 200, description: "Sucesso", Type = typeof(DesafioViewModel))]
        [SwaggerResponse(statusCode: 500, description: "Erro interno")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            try
            {
                var resultado = await this.JsonCarrosel();

                return Ok(resultado);
            }
            catch (Exception)
            {

                return NotFound();
            }

        }

        private async Task<string> JsonCarrosel()
        {
            var dados = await _gitHubService.GetFiveElements();

            Carrossel carousel = new Carrossel();

            carousel.itemType = "application/vnd.lime.document-select+json";
            carousel.items = new List<Header>();


            foreach (var repo in dados)
            {
                Body body = new Body();
                Header header = new Header();
                header.header = new Body();

                body.value = new Value();

                body.type = "application/vnd.lime.media-link+json";

                body.value.title = repo.full_name;
                body.value.text = repo.description;
                body.value.type = "image/jpeg";
                body.value.uri = repo.owner.avatar_url;

                header.header = body;
                carousel.items.Add(header);
            }
            string result = JsonConvert.SerializeObject(carousel);

            return result;
        }
    }
}
