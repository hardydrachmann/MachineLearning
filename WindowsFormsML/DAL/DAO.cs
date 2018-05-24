using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using WindowsFormsML.Models;

namespace WindowsFormsML.DAL
{
    public class DAO
    {
        HttpClient client;

        public Selection GetSelections()
        {
            getClient();
            var response = client.GetStringAsync("http://localhost:5000/api/selections/");
            Selection selection = new Selection();
            selection = JsonConvert.DeserializeObject<Selection>(response.Result);
            return selection;
        }

        public string GetPredictions(InputDTO inputDTO)
        {
            getClient();

            var myContent = JsonConvert.SerializeObject(inputDTO);
            var buffer = Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = client.PostAsync("http://localhost:5000/api/inputs/", byteContent).Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                return result;
            }
            else
            {
                return "Error: " + response.Headers.ToString();
            }
        }

        private void getClient()
        {
            if (client == null)
            {
                client = new HttpClient();
            }
        }
    }
}
