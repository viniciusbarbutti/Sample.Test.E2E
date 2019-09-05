using Newtonsoft.Json;

namespace Sample.Test.E2E.Core.API.Repositories.Parameters
{
    public class Investment
    {
        [JsonProperty("userName")]
        public string User { get; set; }

        [JsonProperty("investimentValue")]
        public string InvestimentValue { get; set; }
    }
}
