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
        // Gets all Movie from database and returns it
        public List<string> GetAll()
        {
            List<string> movieList = new List<string>();

            try
            {
                    foreach (var movie in MLcontext.Movie)
                    {
                        movieList.Add(movie.Name);
                    }
                    return movieList;
            }
            catch (EntityException e)
            {
                throw e;
            }
            finally
            {
                MLcontext.Database.Connection.Close();
            }



        }
    }
}