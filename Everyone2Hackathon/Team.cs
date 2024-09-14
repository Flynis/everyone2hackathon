using System.Diagnostics.CodeAnalysis;

namespace Everyone2Hackathon;

internal record Team
{
    public required int Junior { get; init; }
    public required int Teamlead { get; init; }

    public Team() { }

    [SetsRequiredMembers]
    public Team(int junior, int teamlead)
    {
        Junior = junior;
        Teamlead = teamlead;
    }
}
