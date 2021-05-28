using System;
using System.Collections.Generic;
using System.Text;
using Flurl.Http;
using Flurl;
using System.Threading.Tasks;
using PoliklinikaAPI.ViewModels;
using PoliklinikaAPI.Helpers;

namespace PoliklinikaDesktop
{
    public class APIService
    {
        private string _route=null;
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object search)
        {

            var result = $"{Properties.Settings.Default.APIurl}/{_route}";

            if (search != null)
            {
                result += "?";
                result += await search.ToQueryString();
            }

            return await result.GetJsonAsync<T>();

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
        public async Task<T> Update<T>(object request)
        {
            var result = $"{Properties.Settings.Default.APIurl}/{_route}";

            return await result.PutJsonAsync(request).ReceiveJson<T>();
        }
    }
}
