using System;
using System.Collections.Generic;
using System.Linq;

namespace SolarPowerEngineering
{
    public static class StringFilter
    {
        public static IEnumerable<string> FilterWordsStartingWithA(IEnumerable<string> words)
        {
            return words.Where(word => word.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        }
    }
}
