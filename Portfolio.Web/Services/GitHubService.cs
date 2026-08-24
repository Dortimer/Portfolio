using Portfolio.Core.DTO.GitHub;

namespace Portfolio.Web.Services
{
	public interface IGitHubService
	{
		Task<List<GitHubContent>> GetRepoDetailsAsync(string path);
		Task<GitHubContent> GetFileDetailsAsync(string path);
	}

	public class GitHubService : IGitHubService
	{
		private readonly HttpClient _httpClient;

		private static string Owner = "Dortimer";
		private static string Repo = "Portfolio";

		public GitHubService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<List<GitHubContent>> GetRepoDetailsAsync(string path = "")
		{
			var url = $"repos/{Owner}/{Repo}/contents/{path}";

			var result = await _httpClient.GetFromJsonAsync<List<GitHubContent>>(url);

			return result ?? new List<GitHubContent>();
		}

		public async Task<GitHubContent> GetFileDetailsAsync(string path)
		{
			var url = $"repos/{Owner}/{Repo}/contents/{path}";

			var result = await _httpClient.GetFromJsonAsync<GitHubContent>(url);

			return result ?? new GitHubContent();
		}
	}
}
