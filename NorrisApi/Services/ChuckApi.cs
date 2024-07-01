using Newtonsoft.Json;
using NorrisApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NorrisApi.Models.ResourceList;

namespace NorrisApi.Services
{
    internal class ChuckApi
    {
        public HttpClient HttpClient;

        public ChuckApi()
        {
            HttpClient = new HttpClient();
        }

        public async Task<List<ChuckResponse>> ChuckList()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=40&offset=0";
            string json = await HttpClient.GetStringAsync(url);

            RosourceList resourceListPok = JsonConvert.DeserializeObject<RosourceList>(json);
            return resourceListPok.results;
        }

        public async Task<CaracteristicasPokemon> PokeCharacteristics(string url)
        {
            string json = await HttpClient.GetStringAsync(url);
            CaracteristicasPokemon pokeCharact = JsonConvert.DeserializeObject<CaracteristicasPokemon>(json);
            return pokeCharact;
        }

    }
}
