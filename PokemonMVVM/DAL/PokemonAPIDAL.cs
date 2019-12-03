using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PokemonMVVM.Models;
using System.Linq;

namespace PokemonMVVM.DAL
{
    public static class PokemonAPIDAL
    {
        const string LOADALL_URL = "https://pokeapi.co/api/v2/pokemon";
        

        public static async Task<List<Pokemon>> LoadCharacters()
        {
            WebClient wc = new WebClient();
            byte[] data = await wc.DownloadDataTaskAsync(new Uri(LOADALL_URL));
            string json = Encoding.UTF8.GetString(data);
            CharacterAPIResult result = JsonConvert.DeserializeObject<CharacterAPIResult>(json);

            return result.Results;
            ;
        }
    }
}