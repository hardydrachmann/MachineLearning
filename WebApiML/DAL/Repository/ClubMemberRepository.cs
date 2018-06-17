using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Net;
using System.Web.Http;

namespace WebApiML.DAL.Repository
{
    public class ClubMemberRepository : IRepository<string>
    {
        private MachineLearningDBEntities MLcontext;

        public ClubMemberRepository(MachineLearningDBEntities context)
        {
            MLcontext = context;
        }

        // Implementation of IRepository<T> interface
        // Returns a list of club members from the database
        public List<string> GetAll()
        {
            List<string> clubMembersList = new List<string>();
            foreach (var clubMember in MLcontext.ClubMember)
            {
                clubMembersList.Add(clubMember.IsMember);
            }
            return clubMembersList;

        }

    }
}