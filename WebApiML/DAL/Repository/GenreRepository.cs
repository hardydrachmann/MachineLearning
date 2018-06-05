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
        // Gets all Genre from database and returns it
        public List<string> GetAll()
        {
            List<string> genreList = new List<string>();

            try
            {
                    foreach (var genre in MLcontext.Genre)
                    {
                        genreList.Add(genre.Name);
                    }
                    return genreList;
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