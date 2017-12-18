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
