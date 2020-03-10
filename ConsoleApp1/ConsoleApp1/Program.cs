using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using static System.Environment;
using static System.Environment.SpecialFolder;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var records = new List<Foo>
            {
                new Foo { Id = 1, Name = "one" },
            };

            using (var writer = new StreamWriter(Path.Combine(GetFolderPath(DesktopDirectory), "file.csv")))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }

    public class Foo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

