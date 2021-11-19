using System;

namespace TestArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            RomanToInteger romanToInteger = new RomanToInteger();
            Console.WriteLine($"III is {romanToInteger.RomanToInt("III")}");
            Console.WriteLine($"IV is {romanToInteger.RomanToInt("IV")}");
            Console.WriteLine($"IX is {romanToInteger.RomanToInt("IX")}");
            Console.WriteLine($"LVIII is {romanToInteger.RomanToInt("LVIII")}");
            Console.WriteLine($"MCMXCIV is {romanToInteger.RomanToInt("MCMXCIV")}");
        }
    }
}


