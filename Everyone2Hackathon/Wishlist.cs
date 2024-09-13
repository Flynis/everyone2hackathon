using System.Diagnostics.CodeAnalysis;

namespace Everyone2Hackathon;

internal record Wishlist
{
    public required Developer Owner { get; init; }
    public required int[] Priorities { get; init; }

    public Wishlist() { }

    [SetsRequiredMembers]
    public Wishlist(Developer owner, int[] priorities)
    {
        Owner = owner;
        Priorities = priorities;
    }
}
