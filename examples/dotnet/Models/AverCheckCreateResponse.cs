﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aver.ApiIntegration.Models
{
    public class AverCheckCreateResponse
    {
        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
    }
}
