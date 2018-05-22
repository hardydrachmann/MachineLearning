using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL_ML.Repository
{
    public class SexRepository : IRepository<string>
    {
        MachineLearningDBEntities MLcontext = new MachineLearningDBEntities();

        public SexRepository(MachineLearningDBEntities context)
        {
            MLcontext = context;
        }

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