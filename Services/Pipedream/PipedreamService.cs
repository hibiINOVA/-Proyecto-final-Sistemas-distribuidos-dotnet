using System.Text;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Distribuidos.Api.Models.Pipedream;

namespace Distribuidos.Api.Services.Pipedream
{
    public class PipedreamService : IPipedreamService
    {
            public async Task<bool> setWelcomeData(WelcomeModel body)
            {
                string EndPoint = "https://eolugzfnml9ajpu.m.pipedream.net";

                var client = new HttpClient();
                var byteData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new { name = body.UserName, email = body.Email }));

                using (var content = new ByteArrayContent(byteData))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var response = await client.PostAsync(EndPoint, content);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    return false;
                }
            }
    
        public async Task<bool> setCode(WelcomeModel body)
        {
            string EndPoint = "https://eom3ukr8evuncqu.m.pipedream.net";
            var client = new HttpClient();
            var byteData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new { name = body.UserName, email = body.Email }));

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(EndPoint, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }
        public async Task<bool> checkCode(CheckCodeModel body)
        {
            string EndPoint = "https://eoacjpwrzgm1af9.m.pipedream.net";
            var client = new HttpClient();
            var byteData = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new { key = body.Key, value = body.Value }));

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(EndPoint, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
