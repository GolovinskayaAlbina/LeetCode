/////////////////////////////////////////////
//Given a string, find the length of the longest substring without repeating characters.
/////////////////////////////////////////////
//Examples:
//
//Given "abcabcbb", the answer is "abc", which the length is 3.
//Given "bbbbb", the answer is "b", with the length of 1.
//Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.
/////////////////////////////////////////////
public class Solution {
    public int LengthOfLongestSubstring(string s) { 
        int max = 0;
        IDictionary<char, int> uniqueCharacters = new Dictionary<char, int>();

        for(int end = 0, start = 0;end < s.Length; end++)
        {
            if (!uniqueCharacters.ContainsKey(s[end]))
            {
                    uniqueCharacters.Add(s[end], end);
            }
            else
            {
                start = Math.Max(start,uniqueCharacters[s[end]] + 1);
                uniqueCharacters[s[end]] = end;
            }
            max = Math.Max(max, end - start + 1);
        }
        return max;
    }
}