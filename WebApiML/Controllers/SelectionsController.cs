using System;
using System.Data.Entity.Core;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApiML.DAL;
using WebApiML.DTO;

namespace WebApiML.Controllers
{
    public class SelectionsController : ApiController
    {
        private Facade DALFacade = new Facade();
        private SelectionDTO selectionDTO;
        
        // Return a SelectionDTO object containing lists of Sex, ClubMemeber, Movie and Genre
        // GET: api/selections
        [HttpGet]
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
