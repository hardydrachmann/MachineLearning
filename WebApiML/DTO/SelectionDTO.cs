using System.Collections.Generic;

namespace WebApiML.DTO
{
    public class SelectionDTO
    {
        public List<Sex> Sex { get; set; }
        public List<ClubMember> isClubMember { get; set; }
        public List<string> Movie { get; set; }
        public List<string> Genre { get; set; }
    }
}