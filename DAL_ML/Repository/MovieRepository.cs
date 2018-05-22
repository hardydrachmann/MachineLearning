using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace DAL_ML.Repository
{
    public class MovieRepository : IRepository<string>
    {
        MachineLearningDBEntities MLcontext = new MachineLearningDBEntities();

        public MovieRepository(MachineLearningDBEntities context)
        {
            MLcontext = context;
        }

        public List<string> GetAll()
        {
            List<string> movieList = new List<string>();
            foreach (var movie in MLcontext.Movie)
            {
                movieList.Add(movie.Name);
            }
            return  movieList;
        }
    }
}