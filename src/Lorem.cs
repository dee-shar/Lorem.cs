using System.Net.Http;

namespace LoremApi
{
    public class Lorem
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://lorem-api.com/api";
        public Lorem()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetLoremText()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/lorem");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetArticle(string slug)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/article/{slug}");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetRandomNumber()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/number");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
