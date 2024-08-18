using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GameServerApi.RestClient.Models
{
    public class ServerModelGetResponse
    {
        [JsonProperty("data")]
        public List<Data> Data;

    }
    public class Data
    {
        [JsonProperty("attributes")]
        public Attributes Attributes;
    }

    public class Attributes
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("ip")]
        public string Ip;

        [JsonProperty("port")]
        public int? Port;

        [JsonProperty("players")]
        public int? Players;

        [JsonProperty("maxPlayers")]
        public int? MaxPlayers;

        [JsonProperty("rank")]
        public int? Rank;

        [JsonProperty("status")]
        public string Status;
    }
}
