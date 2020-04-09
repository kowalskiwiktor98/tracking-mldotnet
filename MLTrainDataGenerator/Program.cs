using System;

namespace MLTrainDataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("begin;zipFrom;zipTo;duration");
            Console.ReadLine();
            string input = "";
            int lineCounter = 0;
            do
            {
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;
                if (input.Contains("NULL")) continue;
                lineCounter++;
                //if (lineCounter % 1000000 == 0) Console.WriteLine(lineCounter+" lines done");
                var fields = input.Split(';');
                var begin = DateTime.Parse(fields[2]);
                var zipFrom = fields[6];
                var zipTo = fields[4];
                var duration = (float)DateTime.Parse(fields[3]).Subtract(begin).TotalHours;
                if (duration < 1) continue;
                Console.WriteLine(begin + ";" + zipFrom.Replace(' ', '-') + ";" + zipTo.Replace(' ', '-') + ";" + duration.ToString().Replace(',', '.'));


            } while (input != null && lineCounter < 2_000_000);
        }
    }
}
