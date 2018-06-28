using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Search_Library
{
    public static class Shell
    {
        public static List<int> Sort(List<int> list)
        {
            for (int i = list.Count/2; i > 0; i /= 2)
            {
                list = sort(list, i);
            }
            return Insertion.Sort(list);
        }

        private static List<int> sort(List<int> list, int gap)
        {
            for (int i = 0; i < list.Count()-gap; i++)
            {
                int value = list[i];
                int readIndex = i + gap;

                if (value > list[readIndex])
                {
                    int readValue = list[readIndex];

                    list.Insert(readIndex, value);
                    list.RemoveAt(readIndex+1);

                    list.RemoveAt(i);
                    list.Insert(i, readValue);
                }
            }
            return list;
        }
    }
}
