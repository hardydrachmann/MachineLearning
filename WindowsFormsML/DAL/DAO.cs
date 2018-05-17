using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsML.BE;
using WindowsFormsML.DTO;

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

            // LAV DTO HER i stedet for result:
            var result = response.Content.ReadAsStringAsync().Result;

            //JObject json = JObject.Parse(result.Result);
            

            

            //Prediction prediction = new Prediction();
            //prediction = JsonConvert.DeserializeObject<Prediction>(result.Result);

            return result;
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
