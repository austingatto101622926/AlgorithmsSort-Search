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

            //INSERTION SORT
            pre = System.DateTime.Now;
            List<int> insertionSorted = Insertion.Sort(numbers);
            post = System.DateTime.Now;
            TimeSpan insertionTime = post - pre;

            //SHELL SORT
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
            

            //LINEAR SEACRHING(sorted)
            Console.WriteLine("\nLinear Searching(sorted):");
            pre = System.DateTime.Now;
            foreach (int num in numsToSearch)
            {
                int? LinearIndex = Linear.Search(insertionSorted, num);
                Console.WriteLine($"num {num} found at index {LinearIndex}");
            }
            post = System.DateTime.Now;
            TimeSpan linearSortedTime = post - pre;
            Console.WriteLine($"Linear search time(milliseconds): {linearSortedTime.TotalMilliseconds}");

            //LINEAR SEACRHING(unsorted)
            Console.WriteLine("\nLinear Searching(unsorted):");
            pre = System.DateTime.Now;
            foreach (int num in numsToSearch)
            {
                int? LinearIndex = Linear.Search(numbers, num);
                Console.WriteLine($"num {num} found at index {LinearIndex}");
            }
            post = System.DateTime.Now;
            TimeSpan linearUnsortedTime = post - pre;
            Console.WriteLine($"Linear search time(milliseconds): {linearUnsortedTime.TotalMilliseconds}");

            //BINARY SEARCH
            Console.WriteLine("\nBinary Searching:");
            pre = System.DateTime.Now;
            foreach (int num in numsToSearch)
            {
                int? BinaryIndex = Binary.Search(insertionSorted, num);
                Console.WriteLine($"num {num} found at index {BinaryIndex}");
            }
            post = System.DateTime.Now;
            TimeSpan binaryTime = post - pre;
            Console.WriteLine($"Binary search time(milliseconds): {binaryTime.TotalMilliseconds}");

            //SEARCHING A LIST OF 1 to 10,000,000
            List<int> TestList = Enumerable.Range(0, 10000000).ToList();

            numsToSearch = new int[]
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
                TestList.Last(),
                9999283,
                12345678,
                10,
                0,
                568
            };

            Console.WriteLine("\nSEARCHING A LIST OF 1 to 10,000,000");

            //LINEAR SEACRHING(sorted)
            Console.WriteLine("\nLinear Searching(sorted):");
            pre = System.DateTime.Now;
            foreach (int num in numsToSearch)
            {
                int? LinearIndex = Linear.Search(TestList, num);
                Console.WriteLine($"num {num} found at index {LinearIndex}");
            }
            post = System.DateTime.Now;
            linearSortedTime = post - pre;
            Console.WriteLine($"Linear search time(milliseconds): {linearSortedTime.TotalMilliseconds}");

            //BINARY SEARCH
            Console.WriteLine("\nBinary Searching:");
            pre = System.DateTime.Now;
            foreach (int num in numsToSearch)
            {
                int? BinaryIndex = Binary.Search(TestList, num);
                Console.WriteLine($"num {num} found at index {BinaryIndex}");
            }
            post = System.DateTime.Now;
            binaryTime = post - pre;
            Console.WriteLine($"Binary search time(milliseconds): {binaryTime.TotalMilliseconds}");

            Console.ReadLine();
        }
    }
}
