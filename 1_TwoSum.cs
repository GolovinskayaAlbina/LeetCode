/////////////////////////////////////////////
//Given an array of integers, return indices of the two numbers such that they add up to a specific target.
//
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
/////////////////////////////////////////////
//Example:
//Given nums = [2, 7, 11, 15], target = 9,
//
//Because nums[0] + nums[1] = 2 + 7 = 9,
//return [0, 1].
/////////////////////////////////////////////
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Count(); i++)
        {
            var pass = target - nums[i];
            if (dict.ContainsKey(pass))
            {
                return new[]{dict[pass], i};
            }
            dict[nums[i]] = i;
        }
        throw new ArgumentException("No decision for entrance values");
    }
}
