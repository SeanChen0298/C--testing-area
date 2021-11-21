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
            Console.WriteLine("");

            LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
            string[] strs = { "flower", "flow", "flight" };
            Console.WriteLine($"{string.Join(",", strs)} longest prefix: {longestCommonPrefix.LongestComPrefix(strs)}");
            string[] strs2 = { "dog","racecar","car" };
            Console.WriteLine($"{string.Join(",", strs2)} longest prefix: {longestCommonPrefix.LongestComPrefix(strs2)} ");
            Console.WriteLine("");

            ValidParentheses validParentheses = new ValidParentheses();
            Console.WriteLine($"() is {validParentheses.IsValid("()")}");
            Console.WriteLine($"()[]{{}} is {validParentheses.IsValid("()[]{{}}")}");
            Console.WriteLine($"(] is {validParentheses.IsValid("(]")}");
            Console.WriteLine($"([)] is {validParentheses.IsValid("([)]")}");
            Console.WriteLine($"{{[]}} is {validParentheses.IsValid("{{[]}}")}");
            Console.WriteLine("");

            MergeTwoSortedList mergeTwoSortedList = new MergeTwoSortedList();
            ListNode emptyNode = new ListNode(null);
            ListNode l1Head = new ListNode(1);
            ListNode l2Head = new ListNode(1);
            l1Head.next = new ListNode(2);
            l2Head.next = new ListNode(4);
            l1Head.next.next = new ListNode(3);
            ListNode result = mergeTwoSortedList.MergeTwoLists(l1Head, l2Head);
            while(result!=null){
                Console.Write($"{result.val} -> ");
                result = result.next;
            }
            Console.WriteLine("");
        }
    }
}


