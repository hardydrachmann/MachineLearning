using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL_ML.Repository
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