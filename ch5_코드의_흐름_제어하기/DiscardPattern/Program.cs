using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace ListPattern
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var GetStatistics = (List<object[]> records) =>
            {
                var statistics = new Dictionary<string, int>();

                foreach (var record in records)
                {
                    var (contentType, contentPrice) = record switch
                    {
                        [_, "COMEDY", .., var price] => ("COMEDY", price),
                        [_, "SF", .., var price] => ("SF", price),
                        [_, "ACTION", .., var price] => ("ACTION", price),
                        [_, .., var price] => ("ETC", price),
                        _ => ("ETC", 0),
                    };

                    if (!statistics.ContainsKey(contentType))
                        statistics.Add(contentType, (int)contentPrice);
                    else
                        statistics[contentType] += (int)contentPrice;
                }
                return statistics;
            };

            List<object[]> MovieRecords = new List<object[]>()
            {
                new object[] {0, "COMEDY", "Spy", 2015, 10_000 },
                new object[] {1, "COMEDY", "Scary Movie", 20_000 },
                new object[] {2, "SF", "Avengers: Infinity War", 100_000 },
                new object[] {3, "DRAMA", "Notting Hill", 1_000 },
                new object[] {4, "ACTION", "Fast & Furious", 80_000 },
            };

            var statistics = GetStatistics(MovieRecords);

            foreach (var s in statistics)
                Console.WriteLine($"{s.Key}: {s.Value:N0}");

        }
    }
}