using System;

namespace Mittwochs
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;
            var start = new DateTime(2015, 03, 25, 00, 0, 0);
            int tage = (today.Date - start.Date).Days;
            int wochen = tage / 7;
            Console.WriteLine(wochen.ToString());
            Console.ReadKey();
        }
    }
}
