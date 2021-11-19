using System;
using System.Collections.Generic;

namespace TestArea
{
    public class RomanToInteger
    {
        /// <summary>
        /// Converts Roman characters ('I', 'V', 'X', 'L', 'C', 'D', 'M') into numbers.
        /// </summary>
        public int RomanToInt(string s)
        {
            // Convert string into char array. III -> ["I","I","I"]
            char[] charArray = s.ToCharArray();

            // Convert each element in char array into integer using RomanNumbers Enum.
            List<int> list = new List<int>();
            foreach (char ch in charArray)
            {
                var number = (int)Enum.Parse(typeof(RomanNumbers), ch.ToString());
                list.Add(number);
            }

            // Loops through the int list, add if next <= current, subtract if next > current. 
            int result = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (i == list.Count)
                {
                    result += list[i];
                }
                else
                {
                    if (list[i] >= list[i + 1])
                    {
                        result += list[i];
                    }
                    else if (list[i] < list[i + 1])
                    {
                        result -= list[i];
                    }
                }
            }

            // Add in the last element of int list.
            return result += list[list.Count-1];
        }
    }

    enum RomanNumbers
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }
}
