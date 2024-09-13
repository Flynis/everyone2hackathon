using Everyone2Hackathon;

List<Developer> juniors = Helper.ReadDevsFromCsv("resourses/Juniors20.csv");
List<Developer> teamleads = Helper.ReadDevsFromCsv("resourses/Teamleads20.csv");

Console.WriteLine("Juniors");
juniors.ForEach(Console.WriteLine);
Console.WriteLine("Teamleads");
teamleads.ForEach(Console.WriteLine);
