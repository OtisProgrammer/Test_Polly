using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Client
{
    public class HttpHelperService : IHttpHelperService
    {
        private readonly HttpClient _httpClient;

        public HttpHelperService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ResponseDto>  Post(string name)
        {
            var data = new {name=name};

            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var url = "/api/Server/Post";

            var response = await _httpClient.PostAsync(url, content);
            var result = await response.Content.ReadAsStringAsync();
            return  JsonConvert.DeserializeObject<ResponseDto>(result);
        }
    }

    public class ResponseDto
    {
        public string result { get; set; }
    }
}
