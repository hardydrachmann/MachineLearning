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

        // Sends a request to the Azure ML web service with inputted data using an InputDTO object
        // Returns posibilities from the web service
        // POST: api/inputs
        [HttpPost]
        public async Task<HttpResponseMessage> Post([FromBody]InputDTO inputDTO)
        {
            var result = await azureDAO.InvokeRequestResponseService(inputDTO);
            return result;
        }
    }
}
