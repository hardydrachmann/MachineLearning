using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WindowsFormsML.Models;

namespace WindowsFormsML.DAL
{
    public class DAO
    {
        HttpClient client;

        // Get request to local api
        // Returns selection object which contains lists of Sex, ClubMember, Genre and Movie
        public Selection GetSelections()
        {
            getClient();
            HttpResponseMessage response = new HttpResponseMessage();
            Selection selection = new Selection();
            response = client.GetAsync("http://localhost:5000/api/selections/").Result;

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                selection = JsonConvert.DeserializeObject<Selection>(result);
                return selection;
            }
            else
            {
                selection = null;
                return selection;
            }
        }

        // Post request to local api with InputDTO
        // Returns a string of posibilites
        public string GetPredictions(InputDTO inputDTO)
        {
            getClient();
            HttpResponseMessage response = new HttpResponseMessage();
            var result = "";
            try
            {
                var myContent = JsonConvert.SerializeObject(inputDTO);
                var buffer = Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                response = client.PostAsync("http://localhost:5000/api/inputs/", byteContent).Result;
                result = response.Content.ReadAsStringAsync().Result;
            }
            catch (WebException ex)
            {
                switch (response.StatusCode)
                {
                    case HttpStatusCode.NotFound: // 404
                        break;

                    case HttpStatusCode.InternalServerError: // 500
                        break;

                    default:
                        throw;
                }
            }

            return result;
            //if (response.IsSuccessStatusCode)
            //{
            //    var result = response.Content.ReadAsStringAsync().Result;
            //    return result;
            //}
            //else
            //{
            //    return "Error: " + response.Headers.ToString();
            //}
        }

        // Sets client if null
        private void getClient()
        {
            if (client == null)
            {
                client = new HttpClient();
            }
        }
    }
}
