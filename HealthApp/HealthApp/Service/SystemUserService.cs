using HealthApp.Common;
using HealthApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service
{
    public class SystemUserService
    {
        HttpClient _client;

        const string extendUri = "User";

        public SystemUserService()
        {
            _client = new HttpClient();
        }

        public async Task<bool> RegisterUser(SystemUsers user)
        {
            var uri = new Uri(AppSetting.serverUri + extendUri);

            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var respone = await _client.PostAsync(uri, content);

            return respone.IsSuccessStatusCode;
        }

    }
}
