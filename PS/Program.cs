// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

#region Arrays

#region Two Sum
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.



//Example 1:

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3,2,4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3,3], target = 6
//Output: [0,1]
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

//You may assume that each input would have exactly one solution, and you may not use the same element twice.

//You can return the answer in any order.



//Example 1:

//Input: nums = [2,7,11,15], target = 9
//Output: [0,1]
//Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
//Example 2:

//Input: nums = [3,2,4], target = 6
//Output: [1,2]
//Example 3:

//Input: nums = [3,3], target = 6
//Input: nums = [3,3], target = 6
//Output: [0,1]

//public class Solution
//{
//    public int[] TwoSum(int[] nums, int target)
//    {
//        Dictionary<int, int> dict = new Dictionary<int, int>();
//        for (int i = 0; i < nums.Length; i++)
//        {
//            int complement = target - nums[i];
//            if (dict.ContainsKey(complement))
//            {
//                return new int[] { dict[complement], i };
//            }
//            if (!dict.ContainsKey(nums[i]))
//            {
//                dict[nums[i]] = i;
//            }
//        }
//        return new int[0];
//    }
//}

#endregion

#region Best Time to Buy and Sell

//You are given an array prices where prices[i] is the price of a given stock on the ith day.

//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.



//Example 1:

//Input: prices = [7,1,5,3,6,4]
//Output: 5
//Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
//Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
//Example 2:

//Input: prices = [7,6,4,3,1]
//Output: 0
//Explanation: In this case, no transactions are done and the max profit = 0.
// You are given an array prices where prices[i] is the price of a given stock on the ith day.

//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.



//Example 1:

//Input: prices = [7,1,5,3,6,4]
//Output: 5
//Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
//Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
//Example 2:

//Input: prices = [7,6,4,3,1]
//Output: 0
//Explanation: In this case, no transactions are done and the max profit = 0.

// Time complexity is O(n)


//public class Solution
//{
//    public int MaxProfit(int[] prices)
//    {
//        int maxProfit = 0;
//        int minPrice = prices[0];
//        for (int i = 0; i < prices.Length; i++)
//        { 
//            int profit = prices[i] - minPrice;
//            maxProfit = Math.Max(maxProfit, profit);

//            minPrice = Math.Min(minPrice, prices[i]);
//        }
//        return maxProfit;
//    }
//}



#endregion


#region Contains Duplicate

//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.



//Example 1:

//Input: nums = [1, 2, 3, 1]

//Output: true

//Explanation:

//The element 1 occurs at the indices 0 and 3.

//Example 2:

//Input: nums = [1, 2, 3, 4]

//Output: false

//Explanation:

//All elements are distinct.

//Example 3:

//Input: nums = [1, 1, 1, 3, 3, 4, 3, 2, 4, 2]

//Output: true


//public class Solution
//{
//    public bool ContainsDuplicate(int[] nums)
//    {
//        Dictionary<int, int> Dict = new Dictionary<int, int>();
//        foreach (int num in nums)
//        {
//            if (Dict.ContainsKey(num))
//            {
//                return true;
//            }
//            Dict[num] = 1;
//        }
//        return false;
//    }
//}
#endregion


#endregion



#region Strings

#region Longest Substring Without Repeating Characters



//Given a string s, find the length of the longest substring without duplicate characters.



//Example 1:

//Input: s = "abcabcbb"
//Output: 3
//Explanation: The answer is "abc", with the length of 3.
//Example 2:

//Input: s = "bbbbb"
//Output: 1
//Explanation: The answer is "b", with the length of 1.
//Example 3:

//Input: s = "pwwkew"
//Output: 3
//Explanation: The answer is "wke", with the length of 3.
//Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.


//public class Solution
//{
//    public int LengthOfLongestSubstring(string s)
//    {
//        int counter = 0;
//        int a = 0;
//        int b = 0;

//        HashSet<char> myChars = new HashSet<char>();
//        while (b < s.Length)
//        {
//            if (!myChars.Contains(s[b]))
//            {
//                myChars.Add(s[b]);
//                b++;
//                counter = Math.Max(counter, myChars.Count);
//            }
//            else
//            {
//                myChars.Remove(s[a]);
//                a++;
//            }
//        }
//        return counter;
//    }
//}


#endregion

#region Longest Repeating Character Replacement


//You are given a string s and an integer k. You can choose any character of the string and change it to any other uppercase English character.
//You can perform this operation at most k times.

//Return the length of the longest substring containing the same letter you can get after performing the above operations.



//Example 1:

//Input: s = "ABAB", k = 2
//Output: 4
//Explanation: Replace the two 'A's with two 'B's or vice versa.
//Example 2:

//Input: s = "AABABBA", k = 1
//Output: 4
//Explanation: Replace the one 'A' in the middle with 'B' and form "AABBBBA".
//The substring "BBBB" has the longest repeating letters, which is 4.
//There may exists other ways to achieve this answer too.




public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int[] charCount = new int[26];
        int start = 0, maxCount = 0, maxLength = 0;

        for (int end = 0; end < s.Length; end++)
        {
            maxCount = Math.Max(maxCount, ++charCount[s[end] - 'A']);

            while (end - start + 1 - maxCount > k)
            {
                charCount[s[start] - 'A']--;
                start++;
            }

            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}




#endregion



#endregion


