using System;
using System.Collections.Generic;

public partial class Solution {
     public static IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> result =  new List<IList<int>>();
        for(int i = 0; i < nums.Length-2; i++)
        {
            if (nums[i] <= 0 && ( i == 0 || (i > 0 && nums[i] != nums[i-1])))
            {
                int secondIdx = i+1;
                int thirdIdx = nums.Length-1;
                int searchSum = 0 - nums[i];
                while (secondIdx < thirdIdx)
                {
                    if (nums[secondIdx] + nums[thirdIdx] == searchSum)
                    {
                        result.Add(new List<int>{nums[i], nums[secondIdx], nums[thirdIdx]});
                        while (secondIdx < thirdIdx && nums[secondIdx] == nums[secondIdx+1]) secondIdx++;
                        while (secondIdx < thirdIdx && nums[thirdIdx] == nums[thirdIdx-1]) thirdIdx--;  
                        secondIdx++;
                        thirdIdx--; 
                    }  
                    else if (nums[secondIdx] + nums[thirdIdx] < searchSum)
                    {
                        secondIdx++;
                    }
                    else
                    {
                        thirdIdx--;
                    }
                }
            }
        }
        return result;
    }
}
