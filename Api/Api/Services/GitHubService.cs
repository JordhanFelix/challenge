using Api.Models.GitHub;
using Newtonsoft.Json;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Services
{
    public class GitHubService : IGitHubService
    {

        HttpClient cliente = new HttpClient();

        private readonly IGitHubService _githubService;
        private readonly string _apiUrl = "https://api.github.com";

        public GitHubService()
        {
            cliente.BaseAddress = new Uri(_apiUrl);
            cliente.DefaultRequestHeaders.Accept.Clear();
            cliente.DefaultRequestHeaders.Add("User-Agent", "request");
            cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _githubService = RestService.For<IGitHubService>(cliente);
        }

        public async Task<IList<GitHubViewModelResponse>> GetRepositorioGitAsync()
        {
            return await _githubService.GetRepositorioGitAsync();
        }


        public async Task<IList<GitHubViewModelResponse>> GetFiveElements()
        {
            var dados = await _githubService.GetRepositorioGitAsync();
            var resultado = dados.Where(x => (!String.IsNullOrEmpty(x.language)) && (x.language.ToUpper().Equals("C#"))).Take(5).ToList();

            return resultado;
        }
    }
}
