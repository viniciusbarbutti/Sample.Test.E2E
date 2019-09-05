using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Test.E2E.Core.API.Repositories.Parameters
{
    public class Limit
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("newLimit")]
        public string UserLimit { get; set; }
    }
}
