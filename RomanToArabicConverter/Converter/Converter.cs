using System;

namespace Converter
{
    public class Converter
    {
        public int Convert(string numeral)
        {
            var result = numeral switch
            {
                "I" => 1,
                "V" => 5,
                "X" => 10,
                "L" => 50,
                "C" => 100,
                "D" => 500,
                "M" => 1000,
                _ => throw new ArgumentException()
            };

            return result;
        }
    }
}