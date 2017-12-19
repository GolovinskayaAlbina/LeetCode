/////////////////////////////////////////////
//Given a 32-bit signed integer, reverse digits of an integer.
/////////////////////////////////////////////
//Example 1:
//
//Input: 123
//Output:  321
/////////////////////////////////////////////
//Example 2:
//
//Input: -123
//Output: -321
/////////////////////////////////////////////
//Example 3:
//
//Input: 120
//Output: 21
/////////////////////////////////////////////
//Note:
//Assume we are dealing with an environment which could only hold integers within the 32-bit signed integer range. 
//For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
/////////////////////////////////////////////
public class Solution {
    public int Reverse(int x) {
        long result = 0;
        long devider = 10;
        for (; x != 0 ; devider *= 10)
        {
            var devide = (int)(x % devider);
            result = result * 10 + devide/(devider/10);
            x -= devide;
        }
        if (result > int.MaxValue || result < int.MinValue)
        {
            return 0;
        }
        return (int)result;
    }
}
