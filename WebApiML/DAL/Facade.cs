using WebApiML.DAL.Repository;

namespace WebApiML.DAL
{
    public class Facade
    {
        private MachineLearningDBEntities context;

        public Facade()
        {
            context = new MachineLearningDBEntities();
        }

        public IRepository<string> GetMovieRepository()
        {
            return new MovieRepository(context);
        }

        public IRepository<string> GetGenreRepository()
        {
            return new GenreRepository(context);
        }

        public IRepository<string> GetSexRepository()
        {
            return new SexRepository(context);
        }

        public IRepository<string> GetClubMemberRepository()
        {
            return new ClubMemberRepository(context);
        }
    }
}
