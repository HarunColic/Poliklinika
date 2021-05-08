using System;
using System.Collections.Generic;
using System.Text;
using Flurl.Http;
using Flurl;

namespace PoliklinikaDesktop
{
    public class APIService
    {
        private string _route=null;
        public APIService(string route)
        {
            _route = route;
        }
        public T Get<T>()
        {
            var result = $"{Properties.Settings.Default.APIurl}/{_route}".GetJsonAsync<T>();

            return result.Result;
        }
    }
}
