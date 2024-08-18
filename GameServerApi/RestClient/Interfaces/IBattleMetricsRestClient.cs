using GameServerApi.RestClient.Models;

namespace GameServerApi.RestClient.Interfaces
{
    public interface IBattleMetricsRestClient
    {
        Task<ServerModelGetResponse> GetServers(string name, int page);
    }
}
