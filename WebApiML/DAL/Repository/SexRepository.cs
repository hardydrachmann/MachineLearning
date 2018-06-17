using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Net;
using System.Web.Http;

namespace WebApiML.DAL.Repository
{
    public class SexRepository : IRepository<string>
    {
        MachineLearningDBEntities MLcontext;

        public SexRepository(MachineLearningDBEntities context)
        {
            MLcontext = context;
        }

        // Implementation of IRepository<T> interface
        // Returns a list of sexes from the database
        public List<string> GetAll()
        {
            List<string> sexesList = new List<string>();
            foreach (var sex in MLcontext.Sex)
            {
                sexesList.Add(sex.Name);
            }
            return sexesList;

        }

    }
}