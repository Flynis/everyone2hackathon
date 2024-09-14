namespace Everyone2Hackathon;

internal class Sandbox
{
    private List<Developer> juniors;
    private List<Developer> teamleads;
    private Config config = new();

    public Sandbox()
    {
        juniors = Helper.ReadDevsFromCsv("resourses/Juniors20.csv", Jobs.Junior);
        teamleads = Helper.ReadDevsFromCsv("resourses/Teamleads20.csv", Jobs.Teamlead);
    }

    public double ConductExperiment(int hackathonsCount)
    {
        var sumHarmony = 0.0;
        var hackathon = new Hackathon(juniors, teamleads, config);
        var hrManager = new HrManager(config);
        var hrDirector = new HrDirector(config);

        for (int i = 0; i < hackathonsCount; i++)
        {
            List<Wishlist> wishlists = hackathon.HoldEvent();
            List<Team> teams = hrManager.BuildTeams(wishlists);
            double harmony = hrDirector.CalculateHarmony(wishlists, teams);
            sumHarmony += harmony;
            Console.WriteLine($"Experiment {i + 1}: {harmony}");
        }

        double averageHarmony = sumHarmony / hackathonsCount;
        return averageHarmony;
    }
}