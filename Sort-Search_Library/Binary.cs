using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Search_Library
{
    public class Binary
    {
        public static int? Search(List<int> list, int item)
        {
            //Algorithm sourced from: https://rosettacode.org/wiki/Binary_search

            int low = 0;
            int mid;
            int high = list.Count - 1;
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (list[mid] > item)
                {
                    high = mid - 1;
                }
                else if (list[mid] < item)
                {
                    low = mid + 1;
                }
                else if (list[mid] == item)
                {
                    return mid;
                }
            }
            return null;
        }
    }
}
