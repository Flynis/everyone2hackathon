namespace Everyone2Hackathon;

internal class Hackathon
{
    private readonly List<Developer> juniors;
    private readonly List<Developer> teamleads;

    public Hackathon(List<Developer> juniors, List<Developer> teamleads)
    {
        this.juniors = juniors;
        this.teamleads = teamleads;
    }

    public double HoldEvent()
    {
        return 0.0; // TODO
    }
}
