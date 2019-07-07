using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Pokedex_XamUIJuly.Models;
using Pokedex_XamUIJuly.Helpers;
using Newtonsoft.Json;

namespace Pokedex_XamUIJuly.Services
{
    public static class PokedexService
    {
        private static readonly HttpClient client = CrearHttpClient();

        private static HttpClient CrearHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }

        public async static Task<List<Pokemon>> GetPokemon()
        {
            var response = await client.GetAsync(Constants.PokedexURL);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<Pokemon>>(json);
                return list;
            }

            return default(List<Pokemon>);
        }
    }
}
