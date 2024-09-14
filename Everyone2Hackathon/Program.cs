using Everyone2Hackathon;

var sandbox = new Sandbox();

var experimentsCount = 1000;
double averageHarmony = sandbox.ConductExperiment(experimentsCount);

Console.WriteLine($"Average harmony: {averageHarmony}");
