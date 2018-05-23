using System.Collections.Generic;

namespace WebApiML.DAL.Repository
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