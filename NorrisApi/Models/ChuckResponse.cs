﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorrisApi.Models
{
    internal class ChuckResponse
    {

        public class Rootobject
        {
            public string icon_url { get; set; }
            public string id { get; set; }
            public string url { get; set; }
            public string value { get; set; }
        }

    }
}
