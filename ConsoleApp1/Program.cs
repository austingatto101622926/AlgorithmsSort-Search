using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sort_Search_Library;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = csvReader.ReadCSV(@"F:\Visual Studio Solutions\AlgorithmsSort-Search\unsorted_numbers.csv");

            DateTime preSort;
            DateTime postSort;

            preSort = System.DateTime.Now;
            List<int> insertionSorted = Insertion.Sort(numbers);
            postSort = System.DateTime.Now;
            TimeSpan insertionTime = postSort - preSort;

            preSort = System.DateTime.Now;
            List<int> shellSorted = Shell.Sort(numbers);
            postSort = System.DateTime.Now;
            TimeSpan shellTime = postSort - preSort;

            Console.WriteLine("Time in milliseconds:");
            Console.WriteLine($"insertionSorted: { insertionTime.TotalMilliseconds}");
            Console.WriteLine($"shellSorted: { shellTime.TotalMilliseconds}");

            Console.ReadKey();
        }
    }
}
