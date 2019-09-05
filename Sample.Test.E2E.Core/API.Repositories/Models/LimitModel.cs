using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Test.E2E.Core.API.Repositories.Models
{
    public class LimitModel
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("limit")]
        public string UserLimit { get; set; }
    }
}
