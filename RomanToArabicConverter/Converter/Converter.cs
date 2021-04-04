using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            if (!DoesNumeralContainValidCharacters(numeral))
                throw new ArgumentException("Numeral contains invalid characters!");

            var characters = numeral.ToCharArray();

            var result = 0;
            for (var i = 0; i < characters.Length - 1; i++)
            {
                var sign = IsNextCharacterGreater(characters[i], characters[i + 1]) ? -1 : 1;
                result += sign * _romanToArabicMap[characters[i].ToString()];
            }

            result += _romanToArabicMap[characters[^1].ToString()];

            return result;
        }

        private static bool IsNextCharacterGreater(char c1, char c2)
        {
            return c1 switch
            {
                'I' => (c2 == 'V' || c2 == 'X'),
                'V' => false,
                'X' => (c2 == 'L' || c2 == 'C'),
                'L' => false,
                'C' => (c2 == 'D' || c2 == 'M'),
                'D' => (c2 == 'M'),
                'M' => false,
                _ => throw new ArgumentException()
            };
        }

        private static bool DoesNumeralContainValidCharacters(string numeral)
        {
            return new Regex(@"^[IVXLCDM]+$").IsMatch(numeral);
        }
    }
}