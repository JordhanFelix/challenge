using Api.Models.GitHub;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Services
{
    public interface IGitHubService
    {        
        [Get("/orgs/takenet/repos")]
        Task<IList<GitHubViewModelResponse>> GetRepositorioGitAsync();
        Task<IList<GitHubViewModelResponse>> GetFiveElements();
    }
}
