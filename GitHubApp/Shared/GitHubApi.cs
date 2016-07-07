using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace Shared
{
    public class GitHubApi
    {
        public async Task<IEnumerable<string>> GetAsync(string user)
        {
            var url = $"https://api.github.com/users/{user}/repos";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "Other");

            var response = await client.GetAsync(url);

            var content = await response.Content.ReadAsStringAsync();
            var json = JArray.Parse(content);

            var repositories = json.Select(x => x.Value<string>("full_name"));

            return repositories;
        }
    }
}
