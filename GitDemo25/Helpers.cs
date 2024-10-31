using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo25
{
    internal class Helpers
    {
        public static double CalculateFine(double overTime, double fineAmount)
        {
            return overTime * fineAmount;
        }

        public static void PrintText(string text)
        {
            Console.WriteLine(text);
        }
    }
}
