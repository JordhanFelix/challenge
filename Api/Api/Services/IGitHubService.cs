using Api.Models.GitHub;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface IGitHubService
    {        
        [Get("/users/takenet/repos")]
        Task<IList<GitHubViewModelResponse>> GetRepositorioGitAsync();
    }
}
