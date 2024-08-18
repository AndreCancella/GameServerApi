namespace GameServerApi.Models
{
    public class ServerModel
    {
        public string NameServer { get; set; }
        public int? Rank { get; set; }
        public string Status { get; set; }
        public string Ip { get; set; }
        public int? Port { get; set; }
        public int? Players { get; set; }
        public int? MaxPlayers { get; set; }
    }
}
