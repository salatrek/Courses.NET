using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EleventhLesson_Http_.Models;

namespace EleventhLesson_Http_.Services
{
    public class PlayerService
    {
        private readonly string _token;
        public PlayerService(string token)
        {
            _token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public async Task<PlayerResponce> GetPlayers()
        {
            HttpResponseMessage responseMessage;
            PlayerResponce playersResponce;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);

                responseMessage = await client.GetAsync("http://dev.trainee.dex-it.ru/api/Player/GetPlayers");
                responseMessage.EnsureSuccessStatusCode();

                string serializedMessage = await responseMessage.Content.ReadAsStringAsync();

                playersResponce = JsonConvert.DeserializeObject<PlayerResponce>(serializedMessage);
            }

            return playersResponce;
        }

        public async Task Add(Player player)
        {
            string seriaizedPlayer = JsonConvert.SerializeObject(player);

            var content = new StringContent(seriaizedPlayer, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);

                var response = await client.PostAsync("http://dev.trainee.dex-it.ru/api/Player/Add", content);
            }
        }
    }

    
}
