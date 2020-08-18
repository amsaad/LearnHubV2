namespace LearnHub.Repository
{
    public class LkRepository : RepositoryBase<LkRepository>
    {
        public LkRepository(ILearnHubDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}