using WebApiML.DAL.Repository;

namespace WebApiML.DAL
{
    public class Facade
    {
        private MachineLearningDBEntities context;

        private IRepository<string> movieRepo;
        private IRepository<string> genreRepo;
        private IRepository<string> sexRepo;
        private IRepository<string> clubMemberRepo;


        public Facade()
        {
            context = new MachineLearningDBEntities();
        }

        public IRepository<string> GetMovieRepository()
        {
            return movieRepo ?? (movieRepo = new MovieRepository(context));
        }

        public IRepository<string> GetGenreRepository()
        {
            return genreRepo ?? (genreRepo = new GenreRepository(context));
        }

        public IRepository<string> GetSexRepository()
        {
            return sexRepo ?? (sexRepo = new SexRepository(context));
        }

        public IRepository<string> GetClubMemberRepository()
        {
            return clubMemberRepo ?? (clubMemberRepo = new ClubMemberRepository(context));
        }
    }
}
