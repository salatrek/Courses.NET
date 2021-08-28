using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using EleventhLesson_Http_.Models;
using Newtonsoft.Json;

namespace EleventhLesson_Http_.Services
{
    public class TeamService
    {
        private readonly string _token;
        public TeamService(string token)
        {
            _token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public async Task Add(Team team)
        {
            string seriaizedTeam = JsonConvert.SerializeObject(team);

            var content = new StringContent(seriaizedTeam, Encoding.UTF8, "application/json");

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);

                var response = await client.PostAsync("http://dev.trainee.dex-it.ru/api/Team/Add", content);
            }
        }

        public async Task<TeamResponce> GetTeams()
        {
            HttpResponseMessage responseMessage;
            TeamResponce teamResponce;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);

                responseMessage = await client.GetAsync("http://dev.trainee.dex-it.ru/api/Team/GetTeams");
                responseMessage.EnsureSuccessStatusCode();

                string serializedMessage = await responseMessage.Content.ReadAsStringAsync();

                teamResponce = JsonConvert.DeserializeObject<TeamResponce>(serializedMessage);
            }

            return teamResponce;
        }

    }
}
