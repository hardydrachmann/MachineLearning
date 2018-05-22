using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL_ML.Repository
{
    public class ClubMemberRepository : IRepository<string>
    {
        private MachineLearningDBEntities MLcontext;

        public ClubMemberRepository(MachineLearningDBEntities context)
        {
            MLcontext = context;
        }

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