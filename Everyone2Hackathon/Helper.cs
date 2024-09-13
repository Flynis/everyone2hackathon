using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace Everyone2Hackathon;

internal class Helper
{
    private class CsvRecord
    {
        public required int Id {  get; set; }
        public required string Name { get; set; }
    }

    public static List<Developer> ReadDevsFromCsv(string filename)
    {
        var result = new List<Developer>();

        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";",
            HasHeaderRecord = true,
        };

        using (var reader = new StreamReader(filename))
        using (var csv = new CsvReader(reader, config))
        {
            var records = csv.GetRecords<CsvRecord>();
            foreach (var record in records)
            {
                result.Add(new Developer { Id = record.Id, Name = record.Name });
            }
        }

        return result;
    }
}
