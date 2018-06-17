using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;

namespace WebApiML.DAL.Repository
{
    public class GenreRepository : IRepository<string>
    {
        MachineLearningDBEntities MLcontext;

        public GenreRepository(MachineLearningDBEntities context)
        {
            MLcontext = context;
        }

        // Implementation of IRepository<T> interface
        // Returns a list of genres from the database
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