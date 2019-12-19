using HealthApp.Common;
using HealthApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HealthApp.Service
{
    public class HospitalService
    {
        HttpClient _client;

        const string extendUri = "hospital";

        public List<Hospital> hospitals { get; private set; }

        public HospitalService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Hospital>> RefreshDataAsync()
        {
            hospitals = new List<Hospital>();

            var uri = new Uri(AppSetting.serverUri + extendUri);

            try
            {
                var respone = await _client.GetAsync(uri);
                if (respone.IsSuccessStatusCode)
                {
                    var content = await respone.Content.ReadAsStringAsync();
                    hospitals = JsonConvert.DeserializeObject<List<Hospital>>(content);
                }
            }
            catch(Exception exception)
            {
                Debug.WriteLine(@"\tERROR {0}", exception.Message);
            }

            return hospitals;

        }
    }
}
