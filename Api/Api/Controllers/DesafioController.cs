using Api.Models.Desafios;
using Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
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
                List<DesafioViewModel> desafios = new List<DesafioViewModel>();
                var dados = await _gitHubService.GetRepositorioGitAsync();

                foreach (var item in dados.Where(x => (!String.IsNullOrEmpty(x.language)) && (x.language.ToUpper().Equals("C#"))))
                {
                    DesafioViewModel obj = new DesafioViewModel();

                    obj.Titulo = item.full_name;
                    obj.SubTitulo = item.description;
                    obj.ImgUrl = item.owner.avatar_url;
                    obj.DataDeCriacao = item.created_at;

                    desafios.Add(obj);
                }

                return Ok(desafios.OrderBy(d => d.DataDeCriacao));
            }
            catch (Exception)
            {

                return NotFound();
            }




        }
    }
}
