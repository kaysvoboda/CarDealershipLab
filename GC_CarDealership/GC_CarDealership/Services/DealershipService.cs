using System;
using GC_CarDealership.Services.Models;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;


namespace GC_CarDealership.Services
{
    public class DealershipService : IDealershipService
    {
        private readonly HttpClient _client;

        public DealershipService(HttpClient client)
        {
            _client = client;
        }

        public async Task<APIResponse> QueryDealershipAsync(string name)
        {
            return await _client.GetFromJsonAsync<APIResponse>($"{name}/.json");
        }
    }
}
