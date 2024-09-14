using System.Diagnostics.CodeAnalysis;

namespace Everyone2Hackathon;

internal record Wishlist
{
    public required int Owner { get; init; }
    public required int[] Priorities { get; init; }

    public Wishlist() { }

    [SetsRequiredMembers]
    public Wishlist(int owner, int[] priorities)
    {
        Owner = owner;
        Priorities = priorities;
    }
}
