using System;
using System.Linq;
using Tracking.Database;

namespace Tracking
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of using EF6
            using (var dbContext = new MLTrackingContext())
            {
                var record = dbContext.Tracking.First();
                Console.WriteLine(record.Id);
            }
        }
    }
}
