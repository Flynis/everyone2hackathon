namespace Everyone2Hackathon;

internal class HrDirector
{
    private int juniorsCount;
    private int teamleadsCount;

    public HrDirector(Config config)
    {
        juniorsCount = config.JuniorsCount;
        teamleadsCount = config.TeamleadsCount;
    }

    public double CalculateHarmony(List<Wishlist> wishlists, List<Team> teams)
    {
        var harmonyIndexes = new int[wishlists.Count];

        for (int i = 0; i < teams.Count; i++)
        {
            Team team = teams[i];
            harmonyIndexes[i * 2] = GetHarmonyIndex(team.Junior, team.Teamlead, teamleadsCount, wishlists);
            harmonyIndexes[i * 2 + 1] = GetHarmonyIndex(team.Teamlead, team.Junior, juniorsCount, wishlists);
        }

        return Helper.HarmonicMean(harmonyIndexes);
    }

    private int GetHarmonyIndex(Developer dev, Developer teammate, int teammatesCount, List<Wishlist> wishlists)
    {
        Wishlist? wishlist = wishlists.Find(w => w.Owner.Id == dev.Id);
        int teammateIndex = Array.IndexOf(wishlist.Priorities, teammate);
        return teammatesCount - teammateIndex;
    }
}
