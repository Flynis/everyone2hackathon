using System.Diagnostics.CodeAnalysis;

namespace Everyone2Hackathon;

internal class Developer
{
    public required int Id { get; init; }
    public required string Name { get; init; }

    public Developer() { }

    [SetsRequiredMembers]
    public Developer(int id, string name) 
    {
        Id = id;
        Name = name;
    }

    public Wishlist GetWishlist(List<Developer> teammates)
    {
        int[] wishlist = teammates
                                .Select(t => t.Id)
                                .ToArray();
        var rand = new Random();

        for (int i = 0; i < wishlist.Length - 1; i++)
        {
            int j = rand.Next(0, teammates.Count);

            (wishlist[j], wishlist[i]) = (wishlist[i], wishlist[j]);
        }

        return new Wishlist(this, wishlist);
    }

    public override string ToString()
    {
        return $"{{{Id}, {Name}}}";
    }
}
