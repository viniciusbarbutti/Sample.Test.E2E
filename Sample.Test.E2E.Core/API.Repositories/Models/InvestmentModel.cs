using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Test.E2E.Core.API.Repositories.Models
{
    public class InvestmentModel
    {

        [JsonProperty("investmentId")]
        public string InvestimentId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("investimentValue")]
        public string InvestimentValue { get; set; }
    }
}
