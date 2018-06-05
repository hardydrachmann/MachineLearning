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

        // GEts
        // Return selectionDTO with lists of Sex, ClubMemeber, Movie and Genre
        // GET: api/selections
        [HttpGet]
        public SelectionDTO GetAll()
        {
            try { 
            selectionDTO = new SelectionDTO
            {
                Sex = DALFacade.GetSexRepository().GetAll(),
                ClubMember = DALFacade.GetClubMemberRepository().GetAll(),
                Movie = DALFacade.GetMovieRepository().GetAll(),
                Genre = DALFacade.GetGenreRepository().GetAll()
            };
                return selectionDTO;
            }
            catch (EntityException e)
            {
                throw new HttpException("SQL Error" + e.Message);
            }
            //if (selectionDTO != null)
            //{

            //    return selectionDTO;
            //}
            //else
            //{
            //    throw new HttpResponseException(HttpStatusCode.NotFound);
            //}
        }

    }
}
