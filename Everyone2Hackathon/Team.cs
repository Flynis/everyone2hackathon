using System.Diagnostics.CodeAnalysis;

namespace Everyone2Hackathon;

internal record Team
{
    public required Developer Junior { get; init; }
    public required Developer Teamlead { get; init; }

    public Team() { }

    [SetsRequiredMembers]
    public Team(Developer junior, Developer teamlead)
    {
        Junior = junior;
        Teamlead = teamlead;
    }
}
