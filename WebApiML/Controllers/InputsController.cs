using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiML.DAL;
using WebApiML.DTO;

namespace WebApiML.Controllers
{
    public class InputsController : ApiController
    {
        private AzureDAO azureDAO = new AzureDAO();

        // Sends a request to Azures Service with input data
        // Return posibilities from Azure Service
        // POST: api/inputs
        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody]InputDTO inputDTO)
        {
            var result = await azureDAO.InvokeRequestResponseService(inputDTO);
            return result;
        }
    }
}
