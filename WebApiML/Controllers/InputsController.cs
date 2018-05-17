using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiML.BE;
using WebApiML.DAL;
using WebApiML.DTO;

namespace WebApiML.Controllers
{
    public class InputsController : ApiController
    {
        private AzureDAO azureDAO = new AzureDAO();
        //private InputDTO InputDTO;

        // POST api/inputs
        public async Task<HttpResponseMessage> Post([FromBody]InputDTO inputDTO)
        {
            var result = await azureDAO.InvokeRequestResponseService(inputDTO);
            return result;
        }
    }
}
