﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalTest.Tools.Connectivity
{
    public interface IApiService
    {
        Task<T> Invoke<T>(HttpMethod httpMethod, string baseUri);
    }
}
