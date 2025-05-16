using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumLib
{
    public class Solver
    {
        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = i + 1; j < nums.Length; j++)
                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
            return Array.Empty<int>();
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.TryGetValue(complement, out int index))
                    return new[] { index, i };

                if (!map.ContainsKey(nums[i]))
                    map[nums[i]] = i;
            }
            return Array.Empty<int>();
        }
    }
}
