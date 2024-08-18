using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using GameServerApi.RestClient.Interfaces;
using GameServerApi.Models;

namespace GameServerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServerController : ControllerBase
    {
        protected readonly IBattleMetricsRestClient _battleMetricsRestClient;
        public ServerController(IBattleMetricsRestClient battleMetricsRestClient)
        {
            _battleMetricsRestClient = battleMetricsRestClient;
        }

        [HttpGet]
        public async Task<ActionResult<List<ServerModel>>> GetServer([Required] string game, int page = 1)
        {
            try
            {
                if (string.IsNullOrEmpty(game))
                {
                    throw new ArgumentNullException(nameof(game));
                }

                var result = await _battleMetricsRestClient.GetServers(game, page);
                var listServer = new List<ServerModel>();
                foreach (var item in result.Data)
                {
                    listServer.Add(new ServerModel
                    {
                        NameServer = item.Attributes.Name,
                        Ip = item.Attributes.Ip,
                        Rank = item.Attributes.Rank,
                        MaxPlayers = item.Attributes.MaxPlayers,
                        Players = item.Attributes.Players,
                        Port = item.Attributes.Port,
                        Status = item.Attributes.Status
                    });
                }
                return listServer;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
