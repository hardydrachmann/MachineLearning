using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;

namespace WebApiML.DAL.Repository
{
    public class MovieRepository : IRepository<string>
    {
        MachineLearningDBEntities MLcontext;

        public MovieRepository(MachineLearningDBEntities context)
        {
            MLcontext = context;
        }

        // Implementation of IRepository<T> interface
        // Returns a list of movies from database
        public List<string> GetAll()
        {
            List<string> movieList = new List<string>();

            foreach (var movie in MLcontext.Movie)
            {
                movieList.Add(movie.Name);
            }
            return movieList;
        }
    }
}