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

            DateTime pre;
            DateTime post;

            pre = System.DateTime.Now;
            List<int> insertionSorted = Insertion.Sort(numbers);
            post = System.DateTime.Now;
            TimeSpan insertionTime = post - pre;

            pre = System.DateTime.Now;
            List<int> shellSorted = Shell.Sort(numbers);
            post = System.DateTime.Now;
            TimeSpan shellTime = post - pre;

            Console.WriteLine("Sort time in milliseconds:");
            Console.WriteLine($"insertionSorted: { insertionTime.TotalMilliseconds}");
            Console.WriteLine($"shellSorted: { shellTime.TotalMilliseconds}");

            int[] numsToSearch = new int[]
            {
                insertionSorted[0],
                insertionSorted[1500],
                insertionSorted[3000],
                insertionSorted[4500],
                insertionSorted[6000],
                insertionSorted[7500],
                insertionSorted[9000],
                insertionSorted[10500],
                insertionSorted[12000],
                insertionSorted[13500],
                insertionSorted.Last(),
            };

            Console.WriteLine("\nLinear Searching:");
            pre = System.DateTime.Now;
            foreach (int num in numsToSearch)
            {
                int? index = Linear.Search(insertionSorted, num);
                Console.WriteLine($"num {num} found at index {index}");
            }
            post = System.DateTime.Now;
            TimeSpan linearTime = post - pre;
            Console.WriteLine($"Linear search time(milliseconds): {linearTime.TotalMilliseconds}");


            Console.ReadKey();
        }
    }
}
