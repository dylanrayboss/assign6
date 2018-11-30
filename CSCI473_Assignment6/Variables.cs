using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSCI473_Assignment6
{
    static class Variables
    {
        public static List<string[]> people = new List<string[]>();
        public static List<string[]> crickets = new List<string[]>();
        public static string[] series;
        public static string[] seriesLizard;
        public static int limit = 4;
        public static void ReadData()
        {
            using (var reader = new StreamReader(@"C:\Users\z1802435\Source\Repos\assign6\CSCI473_Assignment6\iris.csv"))
            {
                var buffer = reader.ReadLine();
                series = buffer.Split(',');
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    people.Add(values);
                }
            }

            using (var reader = new StreamReader(@"C:\Users\z1802435\Source\Repos\assign6\CSCI473_Assignment6\lizard.txt"))
            {
                var buffer = reader.ReadLine();
                seriesLizard = buffer.Split(',');
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    crickets.Add(values);
                }
            }
        }
    }
}
