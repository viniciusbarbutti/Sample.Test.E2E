using Newtonsoft.Json;
using Sample.Test.E2E.Core.API.Repositories.Parameters;
using Sample.Test.E2E.Core.API.Repositories.Models;
using Sample.Test.E2E.Core.Utils;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Sample.Test.E2E.Core.API.Repositories
{
    public class InvestmentRepository
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<InvestmentModel> MakeInvestment (Investment investment)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var url = $"{Constants.URL}{Constants.ENDPOINT_INVESTMENT}";

            var requestBody = new StringContent(JsonConvert.SerializeObject(investment));

            HttpResponseMessage response = await client.PostAsync(url, requestBody);

            InvestmentModel investmentModel = null;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                investmentModel = JsonConvert.DeserializeObject<InvestmentModel>(responseBody);
            }

            return investmentModel;
        }
    }
}
