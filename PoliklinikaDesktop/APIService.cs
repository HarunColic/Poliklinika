using System;
using System.Collections.Generic;
using System.Text;
using Flurl.Http;
using Flurl;
using System.Threading.Tasks;

namespace PoliklinikaDesktop
{
    public class APIService
    {
        private string _route=null;
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T>  Get<T>()
        {
            var result = await $"{Properties.Settings.Default.APIurl}/{_route}".GetJsonAsync<T>();

            return result;
        }
    }
}
