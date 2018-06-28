using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Search_Library
{
    public static class Insertion
    {
        public static List<int> Sort(List<int> list)
        {
            for (int i = 1; i < list.Count(); i++)
            {
                int value = list[i];
                int readIndex = i - 1;
                while (list[readIndex] > value)
                {
                    readIndex--;
                    if (readIndex < 0) break;
                }
                list.RemoveAt(i);
                list.Insert(readIndex+1, value);
            }
            return list;
        }
    }
}
