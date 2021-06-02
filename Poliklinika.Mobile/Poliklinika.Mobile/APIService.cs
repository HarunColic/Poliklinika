using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Poliklinika.Mobile
{
    class APIService
    {
        private string _route = null;
        public APIService(string route)
        {
            _route = route;
        }
#if DEBUG
        private string _apiUrl = "https://localhost:44381/api";
#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.com/api/";
#endif
        public async Task<T> Get<T>(object search)
        {

            var result = $"{_apiUrl}/{_route}";

            if (search != null)
            {
                result += "?";
                result += await search.ToQueryString();
            }

            return await result.GetJsonAsync<T>();

        }
        public async Task<T> GetById<T>(object id)
        {
            var result = $"{_apiUrl}/{_route}/{id}";

            return await result.GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var result = $"{_apiUrl}/{_route}";

            return await result.PostJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Update<T>(object request)
        {
            var result = $"{_apiUrl}/{_route}";

            return await result.PutJsonAsync(request).ReceiveJson<T>();
        }
        public async Task<T> Delete<T>(object id)
        {
            var result = $"{_apiUrl}/{_route}/{id}";

            return await result.DeleteAsync().ReceiveJson<T>();
        }

        public async void UpdatePassword<T>(object request)
        {
            var result = $"{_apiUrl}/{_route}/update-password";

            await result.PostJsonAsync(request);
        }
    }
}
}
