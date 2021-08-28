using System;
using EleventhLesson_Http_.Services;
using EleventhLesson_Http_.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EleventhLesson_Http_
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string token = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9." +
                "eyJ1c2VyIjoi0JHQvtCz0LTQsNC9IiwidGVuYW50IjoiNzI5IiwibmJmIj" +
                "oxNjI5OTk1MDk0LCJleHAiOjE2MzAwODE0OTQsImlzcyI6IlRlc3QtQmFja2Vu" +
                "ZC0xIiwiYXVkIjoiQmFza2V0QmFsbENsdWJTYW1wbGUifQ.yIYNI68MSUHmIDIt2Tu" +
                "BPe_BG6MtWbEi3ezRABDb7oM";

            var teamService = new TeamService(token);
            var playerService = new PlayerService(token);

            var team = new Team()
            {
                Id = 123,
                Name = "Arsenal",
                FoundationYear = 2009,
                Division = "A",
                Conference = "Test",
                ImageUrl = "myImage"
            };

            await teamService.Add(team);

            var responce = await teamService.GetTeams();
            List<Team> teams = new List<Team>();
            foreach (var item in responce.Data)
            {
                teams.Add(item);
            }

            var player = new Player()
            {
                Id = 545,
                Name = "Alex",
                Number = 35,
                Birthday = new DateTime(1996, 01, 12),
                Height = 179,
                Weight = 70,
                Team = 826,
                Position = "Guard",
                AvatarUrl = "playerImage"
            };

            var resultPlayers = await playerService.GetPlayers();
            await playerService.Add(player);
        }
    }
}
