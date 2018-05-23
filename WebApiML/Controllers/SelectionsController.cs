using System.Web.Http;
using WebApiML.DAL;
using WebApiML.DTO;

namespace WebApiML.Controllers
{
    public class SelectionsController : ApiController
    {
        private Facade DALFacade = new Facade();
        private SelectionDTO selectionDTO;

        // GET api/selections
        public SelectionDTO GetAll()
        {
            selectionDTO = new SelectionDTO
            {
                Sex = DALFacade.GetSexRepository().GetAll(),
                ClubMember = DALFacade.GetClubMemberRepository().GetAll(),
                Movie = DALFacade.GetMovieRepository().GetAll(),
                Genre = DALFacade.GetGenreRepository().GetAll()
            };
            return selectionDTO;
        }

    }
}
