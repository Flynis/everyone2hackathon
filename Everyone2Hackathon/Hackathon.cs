namespace Everyone2Hackathon;

internal class Hackathon
{
    private readonly List<Developer> juniors;
    private readonly List<Developer> teamleads;

    public Hackathon(List<Developer> juniors, List<Developer> teamleads, Config config)
    {
        if (juniors.Count != config.JuniorsCount)
        {
            throw new ArgumentException("Expected number of juniors is not equal to actual.");
        }
        if (teamleads.Count != config.TeamleadsCount)
        {
            throw new ArgumentException("Expected number of teamleads is not equal to actual.");
        }

        this.juniors = juniors;
        this.teamleads = teamleads;
    }

    public List<Wishlist> HoldEvent()
    {
        var wishlists = new List<Wishlist>();

        foreach(var junior in juniors)
        {
            Developer[] wishlist = junior.FormWishlist(teamleads);
            wishlists.Add(new Wishlist(junior, wishlist));
        }

        foreach (var teamlead in teamleads)
        {
            Developer[] wishlist = teamlead.FormWishlist(juniors);
            wishlists.Add(new Wishlist(teamlead, wishlist));
        }

        return wishlists;
    }
}
