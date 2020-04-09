using System;
using System.Diagnostics;

namespace MLDataParser
{
    class Program
    {
        static void Main(string[] args)
        {
            //heders
            string headers = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine(headers);
            string input = "";
            int lineCounter = 0;

            Stopwatch timer = new Stopwatch();
            timer.Start();

            do
            {
                input = Console.ReadLine();
                //lineCounter++;
                //if (lineCounter % 1000000 == 0) Console.WriteLine(lineCounter+" lines done");
                if (input == "") continue;
                #region substring
                var code = input.Substring(0, 41).Trim()+';';
                var createDate = input.Substring(41, 24).Trim() + ';';
                var firstDate = input.Substring(65, 24).Trim() + ';';
                var lastDate = input.Substring(89, 24).Trim() + ';';
                var receiverZip= input.Substring(113, 33).Trim() + ';';
                var receiverCountry= input.Substring(146, 20).Trim() + ';';
                var senderZip = input.Substring(168, 33).Trim() + ';';
                var senderCountry = input.Substring(201, 20).Trim() + ';';
                var weight = input.Substring(221, 10).Trim() + ';';
                var contract = input.Substring(261, 24).Trim() + ';';
                var xlid = input.Substring(322).Trim();
                #endregion

                Console.WriteLine(code+createDate+firstDate+lastDate+receiverZip+receiverCountry+senderZip+senderCountry+weight+contract+xlid);
            } while (input != null && lineCounter < 10);

            timer.Stop();
            Console.WriteLine("Time elapsed " + timer.Elapsed);

            //Console.WriteLine("Done");
            //Console.Read();
        }
    }
}
