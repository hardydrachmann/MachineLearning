using System.Collections.Generic;

namespace WebApiML.DAL.Repository
{
    public class GenreRepository : IRepository<string>
    {
        MachineLearningDBEntities MLcontext = new MachineLearningDBEntities();

        public GenreRepository(MachineLearningDBEntities context)
        {
            MLcontext = context;
        }

        public List<string> GetAll()
        {
            List<string> genreList = new List<string>();
            foreach (var genre in MLcontext.Genre)
            {
                genreList.Add(genre.Name);
            }
            return genreList;
        }
    }
}