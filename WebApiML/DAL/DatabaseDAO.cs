using System.Collections.Generic;

namespace WebApiML.DAL
{
    public class DatabaseDAO
    {
            MachineLearningDBEntities MLcontext = new MachineLearningDBEntities();

        public List<string> GetAllMovies()
        {
            List<string> movieList = new List<string>();
            foreach (var movie in MLcontext.Movies)
            {
                movieList.Add(movie.Name);
            }
            return movieList;
        }

        public List<string> GetAllGenres()
        {
            List<string> genreList = new List<string>();
            foreach (var genre in MLcontext.Genres)
            {
                genreList.Add(genre.Name);
            }
            return genreList;
        }

        public List<Sex> GetAllSexes()
        {
            List<Sex> sexesList = new List<Sex>();
            foreach (var sex in MLcontext.Sexes)
            {
                sexesList.Add(sex);
            }
            return sexesList;
        }

        public List<ClubMember> GetAllClubMembers()
        {
            List<ClubMember> clubMembersList = new List<ClubMember>();
            foreach (var clubMember in MLcontext.ClubMembers)
            {
                clubMembersList.Add(clubMember);
            }
            return clubMembersList;
        }
    }
}