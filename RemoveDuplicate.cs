using System;
using System.Collections.Generic;
using System.Linq;

namespace TestArea
{
    public class RemoveDuplicate
    {
        public int RemoveDuplicates(int[] nums)
        {
            int duplicateCount = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    duplicateCount++;
                }
            }
            List<int> result = nums.Distinct().ToList();
            foreach (int i in result)
            {
                Console.Write(i);
            }

            return result.Count;
        }

        public int RemoveElement(int[] nums, int val)
        {
            int dups = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[dups] = nums[i];
                    dups++;
                }
            }
            return dups;
        }
    }
}