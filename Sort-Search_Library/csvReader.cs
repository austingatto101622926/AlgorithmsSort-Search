using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sort_Search_Library
{
    public static class csvReader
    {
        public static List<int> ReadCSV(string filePath) => File.ReadAllLines(filePath).ToList().Select(S => int.Parse(S)).ToList();
    }
}
