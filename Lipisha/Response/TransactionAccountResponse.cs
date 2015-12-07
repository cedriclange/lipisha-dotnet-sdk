﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lipisha.Response
{
    public class TransactionAccountResponse : BaseStatusResponse
    {
        [JsonProperty("content")]
        public TransactionAccount transactionAccount { get; set; }
    }
}
