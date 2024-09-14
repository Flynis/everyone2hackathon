namespace Everyone2Hackathon;

internal interface ITeamBuildingStrategy
{
    List<Team> BuildTeams(List<Wishlist> wishlists);
}
