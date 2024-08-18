using GameServerApi.RestClient.Interfaces;
using GameServerApi.RestClient.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace GameServerApi.RestClient
{
    public class BattleMetricsRestClient : IBattleMetricsRestClient
    {
        protected readonly string urlBase;
        public BattleMetricsRestClient(IConfiguration configuration) 
        {
            urlBase = configuration.GetSection("BattleMetrics:Host").Value;
        }


        public async Task<ServerModelGetResponse> GetServers(string name, int page)
        {
            return await SendRequestAsync<ServerModelGetResponse>($"/servers?filter[search]={name}&page[offset]={page}", HttpMethod.Get);
        }

        private async Task<T> SendRequestAsync<T>(string url, HttpMethod method)
        {
            using (var request = new HttpRequestMessage(method, urlBase + url))
            {

                var response = await new HttpClient().SendAsync(request);

                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(jsonResponse);
            }
        }


    }
}
