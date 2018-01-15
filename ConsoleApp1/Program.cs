using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var michaelMassTerm = new DateRange(new DateTime(2016, 9, 8), 1);
            Console.WriteLine(michaelMassTerm);
            DateTime a = new DateTime(2016, 6, 7);
            Console.WriteLine(michaelMassTerm.Contains(a));
            Console.ReadKey();
        }
    }
    public class DateRange
    {
        private DateTime FromDate;
        private DateTime ToDate;

        public DateRange(DateTime from, DateTime to)
        {
            FromDate = from;
            ToDate = to;
        }

        public DateRange( DateTime from, double no)
        {
            FromDate = from;
            ToDate = from.AddDays(no);

        }


        public override string ToString()
        {
            return FromDate.ToString("d") + " to " + ToDate.ToString("d");
        }

        public bool Contains(DateTime date)
        {
            return date >= FromDate && date <= ToDate;
        }

}
}
