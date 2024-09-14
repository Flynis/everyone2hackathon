namespace Everyone2Hackathon;

internal class HrManager
{
    private readonly ITeamBuildingStrategy teamBuildingStrategy;

    public HrManager(Config config)
    {
        teamBuildingStrategy = config.TeamBuildingStrategy;
    }

    public List<Team> BuildTeams(List<Wishlist> wishlists)
    {
        if (wishlists.Count % 2 != 0)
        {
            throw new ArgumentException("Number of wishlists is odd, which means teams cannot be compiled");
        }
        return teamBuildingStrategy.BuildTeams(wishlists);
    }
}
