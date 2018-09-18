using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalTest.Tools.Connectivity
{
    public class ApiService : IApiService
    {
        public async Task<T> Invoke<T>(HttpMethod httpMethod, string baseUri)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response;
                    if (httpMethod == HttpMethod.Get)//Just GET for the Test's sake
                    {
                        response = await client.GetAsync(baseUri);

                        var respBody = await response.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(respBody))
                        {
                            return JsonConvert.DeserializeObject<T>(respBody);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //Log this
            }

            return default(T);
        }
    }
}
