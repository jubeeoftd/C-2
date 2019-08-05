using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting Variables
            string strPlayerName;
            int nHits, nAtBats;
            double dblBattingAverage;

            // prompt for name and recieve
            Console.WriteLine("~ This Program calculates a Baseball player's batting average ~");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Enter Player's Name:");
            strPlayerName = Console.ReadLine();

            // prompt for hits
            Console.WriteLine("Enter Player's # of Hits: ");
            nHits = Convert.ToInt32(Console.ReadLine());
        }
    }
}
