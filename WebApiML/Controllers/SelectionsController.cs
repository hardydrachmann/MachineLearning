using System.Web.Http;
using WebApiML.DAL;
using WebApiML.DTO;

namespace WebApiML.Controllers
{
    public class SelectionsController : ApiController
    {
        private DatabaseDAO databaseDAO = new DatabaseDAO();
        private SelectionDTO selectionDTO;

        // GET api/selections
        public SelectionDTO GetAll()
        {
            selectionDTO = new SelectionDTO
            {
                Sex = databaseDAO.GetAllSexes(),
                isClubMember = databaseDAO.GetAllClubMembers(),
                Movie = databaseDAO.GetAllMovies(),
                Genre = databaseDAO.GetAllGenres()
            };
            return selectionDTO;
        }

    }
}
