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
        // Gets all ClubMember from database and returns it
        public List<string> GetAll()
        {
            List<string> clubMembersList = new List<string>();
            try
            {
                    foreach (var clubMember in MLcontext.ClubMember)
                    {
                        clubMembersList.Add(clubMember.IsMember);
                    }
                    return clubMembersList;
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