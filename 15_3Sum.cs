/////////////////////////////////////////////
//Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? 
//Find all unique triplets in the array which gives the sum of zero.
//
//Note: The solution set must not contain duplicate triplets.
/////////////////////////////////////////////
//For example, given array S = [-1, 0, 1, 2, -1, -4],
//
//A solution set is:
//[
//  [-1, 0, 1],
//  [-1, -1, 2]
//]
/////////////////////////////////////////////
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
