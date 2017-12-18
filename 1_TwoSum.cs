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