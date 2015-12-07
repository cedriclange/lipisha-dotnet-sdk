﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lipisha.Response
{
    public class User
    {
        [JsonProperty("user_name")]
        public string userName { get; set; }
        [JsonProperty("email")]
        public string email { get; set; }
    }
}