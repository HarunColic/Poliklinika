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
        public async Task<T> GetById<T>(object id)
        {
            var result =  $"{Properties.Settings.Default.APIurl}/{_route}/{id}";

            return await result.GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var result = $"{Properties.Settings.Default.APIurl}/{_route}";

            return await result.PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(object id,object request)
        {
            var result = $"{Properties.Settings.Default.APIurl}/{_route}/{id}";

            return await result.PutJsonAsync(request).ReceiveJson<T>();
        }
    }
}
