using Newtonsoft.Json;
using RecrutTask.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;


/// <summary>
/// Im using asynchronous method which take in parameter string our InputString from View and return a translated string.
/// Im using HttpClient to connect with api http://api.funtranslations.com , result im deserialize on Object.
/// </summary>


namespace RecrutTask.Services
{
    public class ApiCaller
    {
        public async Task<string> CallToApi(string text)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://api.funtranslations.com");
            var request = new HttpRequestMessage(HttpMethod.Post, $"/translate/leetspeak.json?text={text}");
            var result = await client.SendAsync(request);
            var stringx = await result.Content.ReadAsStringAsync();
            var deserializedResponse = JsonConvert.DeserializeObject<DataModelObjectDto>(stringx);
            var show = deserializedResponse.Contents.TranslatedString;

            return show;
        }

    }
}
