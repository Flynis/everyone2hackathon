namespace Everyone2Hackathon;

internal class OnlyJuniorWishTeamBuildingStrategy : ITeamBuildingStrategy
{
    public List<Team> BuildTeams(List<Wishlist> wishlists)
    {
        var chosenTeamleads = new HashSet<int>();
        var teams = new List<Team>();

        foreach (Wishlist wishlist in wishlists)
        {
            Developer owner = wishlist.Owner;
            if (owner.Job != Jobs.Junior)
            {
                continue;
            }

            var teamleadIndex = 0;
            int[] priorities = wishlist.Priorities;
            while (chosenTeamleads.Contains(priorities[teamleadIndex]))
            {
                teamleadIndex++;
            }

            int teamlead = priorities[teamleadIndex];
            chosenTeamleads.Add(teamlead);

            teams.Add(new Team(owner.Id, teamlead));
        }

        return teams;
    }
}
