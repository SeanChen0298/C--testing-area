using System;
using System.Collections.Generic;

namespace TestArea
{
    public class LongestCommonPrefix
    {
        public string LongestComPrefix(string[] strs)
        {
            string longestPrefix = "";
            foreach (string str in strs)
            {
                string tempPrefix = "";
                if (string.IsNullOrEmpty(longestPrefix) && Array.IndexOf(strs, str) == 0)
                {
                    longestPrefix = str;

                }
                else
                {
                    string strtouse = str.Length > longestPrefix.Length ? longestPrefix : str;
                    for (int i = 0; i < strtouse.Length; i++)
                    {
                        if (str[i] == longestPrefix[i])
                        {
                            tempPrefix += str[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    longestPrefix = tempPrefix;
                }
            }

            return longestPrefix;
        }
    }
}