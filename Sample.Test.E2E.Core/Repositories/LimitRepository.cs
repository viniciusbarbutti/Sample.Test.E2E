using Newtonsoft.Json;
using Sample.Test.E2E.Core.Entities;
using Sample.Test.E2E.Core.Models;
using Sample.Test.E2E.Core.Utils;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Sample.Test.E2E.Core.Repositories
{
    public class LimitRepository
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<LimitModel> UpdateLimit (Limit newLimit)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var url = $"{Constants.URL}{Constants.ENDPOINT_LIMIT}";

            var requestBody = new StringContent(JsonConvert.SerializeObject(newLimit));
            
            HttpResponseMessage response = await client.PostAsync(url,requestBody);

            LimitModel limit = null;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                limit = JsonConvert.DeserializeObject<LimitModel>(responseBody);
            }

            return limit;
        }

        public static async Task<LimitModel> FindByUser (string userName)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //var url = $"{Constants.URL}{Constants.ENDPOINT_LIMIT}";

            var url = new UriBuilder($"{Constants.URL}{Constants.ENDPOINT_LIMIT}")
            {
                Query = "user=Frederico"
            };
            
            HttpResponseMessage response = await client.GetAsync(url.Uri);

            LimitModel limit = null;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                limit = JsonConvert.DeserializeObject<LimitModel>(responseBody);
            }

            return limit;
        }
    }
}