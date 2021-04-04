using System.Collections.Generic;

namespace Converter
{
    public class Converter
    {
        private readonly Dictionary<string, int> _romanToArabicMap = new Dictionary<string, int>
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 },
        };

        public int Convert(string numeral)
        {
            _romanToArabicMap.TryGetValue(numeral, out var result);

            return result;
        }
    }
}