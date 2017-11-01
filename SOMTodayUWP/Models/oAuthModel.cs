﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMTodayUWP.Models
{
    public class oAuthModel
    {
       public string access_token { get; set; }

        public string refresh_token { get; set; }

        public string somtoday_api_url { get; set; }

        public string scope { get; set; }

        public string somtoday_tenant { get; set; }

        public string id_token { get; set; }

        public string token_type { get; set; }

        public int expires_in { get; set; }
    }
}
