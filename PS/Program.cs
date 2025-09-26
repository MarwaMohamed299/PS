// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

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

#region Running Sum of 1d Array
//Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

//Return the running sum of nums.



//Example 1:

//Input: nums = [1,2,3,4]
//Output: [1,3,6,10]
//Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
//Example 2:

//Input: nums = [1,1,1,1,1]
//Output: [1,2,3,4,5]
//Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
//Example 3:

//Input: nums = [3,1,2,10,1]
//Output: [3,4,6,16,17]Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

//Return the running sum of nums.



//Example 1:

//Input: nums = [1,2,3,4]
//Output: [1,3,6,10]
//Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
//Example 2:

//Input: nums = [1,1,1,1,1]
//Output: [1,2,3,4,5]
//Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
//Example 3:

//Input: nums = [3,1,2,10,1]
//Output: [3,4,6,16,17]'


//public class Solution
//{
//    public int[] RunningSum(int[] nums)
//    {
//        ///we need a thing to count max sum and add it to the new array
//        /// we need a new array 
//        int maxCount = 0;
//        int[] sumArr = new int[nums.Length];
//        for (int i = 0; i < nums.Length; i++)
//        {
//            maxCount = nums[i] + maxCount;
//            sumArr[i] = maxCount;
//        }
//        return sumArr;

//    }
//}

#endregion

#region Pivot Index TODO
//Given an array of integers nums, calculate the pivot index of this array.

//The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

//If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

//Return the leftmost pivot index. If no such index exists, return -1.



//Example 1:

//Input: nums = [1,7,3,6,5,6]
//Output: 3
//Explanation:
//The pivot index is 3.
//Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
//Right sum = nums[4] + nums[5] = 5 + 6 = 11
//Example 2:

//Input: nums = [1,2,3]
//Output: -1
//Explanation:
//There is no index that satisfies the conditions in the problem statement.
//Example 3:

//Input: nums = [2,1,-1]
//Output: 0
//Explanation:
//The pivot index is 0.
//Left sum = 0 (no elements to the left of index 0)
//Right sum = nums[1] + nums[2] = 1 + -1 = 0Given an array of integers nums, calculate the pivot index of this array.

//The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.

//If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.

//Return the leftmost pivot index. If no such index exists, return -1.



//Example 1:

//Input: nums = [1,7,3,6,5,6]
//Output: 3
//Explanation:
//The pivot index is 3.
//Left sum = nums[0] + nums[1] + nums[2] = 1 + 7 + 3 = 11
//Right sum = nums[4] + nums[5] = 5 + 6 = 11
//Example 2:

//Input: nums = [1,2,3]
//Output: -1
//Explanation:
//There is no index that satisfies the conditions in the problem statement.
//Example 3:

//Input: nums = [2,1,-1]
//Output: 0
//Explanation:
//The pivot index is 0.
//Left sum = 0 (no elements to the left of index 0)
//Right sum = nums[1] + nums[2] = 1 + -1 = 0

//public class Solution
//{
//    public int PivotIndex(int[] nums)
//    {
//        int totalSum = 0;
//        foreach (int num in nums)
//        {
//            totalSum += num;
//        }
//        int leftSum = 0;
//        for (int i = 0; i < nums.Length; i++)
//        {
//            int rightSum = totalSum - leftSum - nums[i];
//            if (leftSum == rightSum)
//            { return i; }
//            leftSum += nums[i];

//        }
//        return -1;
//    }
//}
#endregion

#region Find the highest altitude
//There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.

//You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). Return the highest altitude of a point.



//Example 1:

//Input: gain = [-5,1,5,0,-7]
//Output: 1
//Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.
//Example 2:

//Input: gain = [-4,-3,-2,-1,4,3,2]
//Output: 0
//Explanation: The altitudes are [0,-4,-7,-9,-10,-6,-3,-1]. The highest is 0.
// There is a biker going on a road trip. The road trip consists of n + 1 points at different altitudes. The biker starts his trip on point 0 with altitude equal 0.

//You are given an integer array gain of length n where gain[i] is the net gain in altitude between points i​​​​​​ and i + 1 for all (0 <= i < n). Return the highest altitude of a point.



//Example 1:

//Input: gain = [-5,1,5,0,-7]
//Output: 1
//Explanation: The altitudes are [0,-5,-4,1,1,-6]. The highest is 1.
//Example 2:

//Input: gain = [-4,-3,-2,-1,4,3,2]
//Output: 0
//Explanation: The altitudes are [0,-4,-7,-9,-10,-6,-3,-1]. The highest is 0.

//public class Solution
//{
//    public int LargestAltitude(int[] gain)
//    {
//        int Counter = 0;
//        int MaxCount = 0;

//        for (int i = 0; i < gain.Length; i++)
//        {

//            Counter += gain[i];
//            MaxCount = Math.Max(MaxCount, Counter);
//        }
//        return MaxCount;
//    }
//}

#endregion

#region Find the Middle Index of an array  [ Same as Pivot Index]
//Given a 0-indexed integer array nums, find the leftmost middleIndex (i.e., the smallest amongst all the possible ones).

//A middleIndex is an index where nums[0] + nums[1] + ... + nums[middleIndex-1] == nums[middleIndex+1] + nums[middleIndex+2] + ... + nums[nums.length-1].

//If middleIndex == 0, the left side sum is considered to be 0. Similarly, if middleIndex == nums.length - 1, the right side sum is considered to be 0.

//Return the leftmost middleIndex that satisfies the condition, or -1 if there is no such index.



//Example 1:

//Input: nums = [2,3,-1,8,4]
//Output: 3
//Explanation: The sum of the numbers before index 3 is: 2 + 3 + -1 = 4
//The sum of the numbers after index 3 is: 4 = 4
//Example 2:

//Input: nums = [1,-1,4]
//Output: 2
//Explanation: The sum of the numbers before index 2 is: 1 + -1 = 0
//The sum of the numbers after index 2 is: 0
//Example 3:

//Input: nums = [2,5]
//Output: -1
//Explanation: There is no valid middleIndex.Given a 0-indexed integer array nums, find the leftmost middleIndex (i.e., the smallest amongst all the possible ones).

//A middleIndex is an index where nums[0] + nums[1] + ... + nums[middleIndex-1] == nums[middleIndex+1] + nums[middleIndex+2] + ... + nums[nums.length-1].

//If middleIndex == 0, the left side sum is considered to be 0. Similarly, if middleIndex == nums.length - 1, the right side sum is considered to be 0.

//Return the leftmost middleIndex that satisfies the condition, or -1 if there is no such index.



//Example 1:

//Input: nums = [2,3,-1,8,4]
//Output: 3
//Explanation: The sum of the numbers before index 3 is: 2 + 3 + -1 = 4
//The sum of the numbers after index 3 is: 4 = 4
//Example 2:

//Input: nums = [1,-1,4]
//Output: 2
//Explanation: The sum of the numbers before index 2 is: 1 + -1 = 0
//The sum of the numbers after index 2 is: 0
//Example 3:

//Input: nums = [2,5]
//Output: -1
//Explanation: There is no valid middleIndex.



//public class Solution
//{
//    public int FindMiddleIndex(int[] nums)
//    {
//        int totalSum = 0;
//        foreach (int num in nums)
//        {
//            totalSum += num;
//        }
//        int leftSum = 0;
//        for (int i = 0; i < nums.Length; i++)
//        {
//            int rightSum = totalSum - leftSum - nums[i];
//            if (leftSum == rightSum)
//            {
//                return i;
//            }
//            leftSum += nums[i];
//        }
//        return -1;
//    }
//}

#endregion

#region Kids With the Greatest Number of Candies


//There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

//Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

//Note that multiple kids can have the greatest number of candies.



//Example 1:

//Input: candies = [2,3,5,1,3], extraCandies = 3
//Output: [true,true,true,false,true] 
//Explanation: If you give all extraCandies to:
//- Kid 1, they will have 2 + 3 = 5 candies, which is the greatest among the kids.
//- Kid 2, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//- Kid 3, they will have 5 + 3 = 8 candies, which is the greatest among the kids.
//- Kid 4, they will have 1 + 3 = 4 candies, which is not the greatest among the kids.
//- Kid 5, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//Example 2:

//Input: candies = [4,2,1,1,2], extraCandies = 1
//Output: [true,false,false,false,false] 
//Explanation: There is only 1 extra candy.
//Kid 1 will always have the greatest number of candies, even if a different kid is given the extra candy.
//Example 3:

//Input: candies = [12,1,12], extraCandies = 10
//Output: [true,false,true]
// There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

//Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

//Note that multiple kids can have the greatest number of candies.



//Example 1:

//Input: candies = [2,3,5,1,3], extraCandies = 3
//Output: [true,true,true,false,true] 
//Explanation: If you give all extraCandies to:
//- Kid 1, they will have 2 + 3 = 5 candies, which is the greatest among the kids.
//- Kid 2, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//- Kid 3, they will have 5 + 3 = 8 candies, which is the greatest among the kids.
//- Kid 4, they will have 1 + 3 = 4 candies, which is not the greatest among the kids.
//- Kid 5, they will have 3 + 3 = 6 candies, which is the greatest among the kids.
//Example 2:

//Input: candies = [4,2,1,1,2], extraCandies = 1
//Output: [true,false,false,false,false] 
//Explanation: There is only 1 extra candy.
//Kid 1 will always have the greatest number of candies, even if a different kid is given the extra candy.
//Example 3:

//Input: candies = [12,1,12], extraCandies = 10
//Output: [true,false,true]

//public class Solution
//{
//    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
//    {
//        int count = 0;
//        int maxCount = 0;
//        bool[] newArr = new bool[candies.Length];
//        int maxArr = candies.Max();
//        for (int i = 0; i < candies.Length; i++)
//        {
//            count = candies[i] + extraCandies;
//            if (count >= maxArr)
//            {
//                newArr[i] = true;
//            }
//            else
//            {
//                newArr[i] = false;
//            }
//        }
//        return newArr;
//    }
//}
#endregion

#region Array Concatentation
//public class Solution
//{
//    public int[] GetConcatenation(int[] nums)
//    {
//        int[] newArr = nums.Concat(nums).ToArray();
//        return newArr;
//    }
//}

//public class Solution
//{
//    public int[] GetConcatenation(int[] nums)
//    {
//        int n = nums.Length;
//        int[] ans = new int[2 * n];

//        for (int i = 0; i < n; i++)
//        {
//            ans[i] = nums[i];
//            ans[i + n] = nums[i];
//        }

//        return ans;
//    }

//}
#endregion

#region  Shuffle the Array TODO

//Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

//Return the array in the form [x1,y1,x2,y2,...,xn,yn].



//Example 1:

//Input: nums = [2,5,1,3,4,7], n = 3
//Output: [2,3,5,4,1,7] 
//Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].
//Example 2:

//Input: nums = [1,2,3,4,4,3,2,1], n = 4
//Output: [1,4,2,3,3,2,4,1]
//Example 3:

//Input: nums = [1,1,2,2], n = 2
//Output: [1,2,1,2]
// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].

//Return the array in the form [x1,y1,x2,y2,...,xn,yn].



//Example 1:

//Input: nums = [2,5,1,3,4,7], n = 3
//Output: [2,3,5,4,1,7] 
//Explanation: Since x1=2, x2=5, x3=1, y1=3, y2=4, y3=7 then the answer is [2,3,5,4,1,7].
//Example 2:

//Input: nums = [1,2,3,4,4,3,2,1], n = 4
//Output: [1,4,2,3,3,2,4,1]
//Example 3:

//Input: nums = [1,1,2,2], n = 2
//Output: [1,2,1,2]


//public class Solution
//{
//    public int[] Shuffle(int[] nums, int n)
//    {
//        int[] newArr = new int[2 * n];
//        int j = 0;

//        for (int i = 0; i < n; i++)
//        {
//            newArr[j++] = nums[i];
//            newArr[j++] = nums[i + n];
//        }

//        return newArr;
//    }

//}

#endregion

#region Number of Good Pairs TODO

//Given an array of integers nums, return the number of good pairs.

//A pair (i, j) is called good if nums[i] == nums[j] and i < j.



//Example 1:

//Input: nums = [1,2,3,1,1,3]
//Output: 4
//Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
//Example 2:

//Input: nums = [1,1,1,1]
//Output: 6
//Explanation: Each pair in the array are good.
//Example 3:

//Input: nums = [1,2,3]
//Output: 01512. Number of Good Pairs
//Easy
//Topics
//premium lock icon
//Companies
//Hint
//Given an array of integers nums, return the number of good pairs.

//A pair (i, j) is called good if nums[i] == nums[j] and i < j.



//Example 1:

//Input: nums = [1,2,3,1,1,3]
//Output: 4
//Explanation: There are 4 good pairs (0,3), (0,4), (3,4), (2,5) 0-indexed.
//Example 2:

//Input: nums = [1,1,1,1]
//Output: 6
//Explanation: Each pair in the array are good.
//Example 3:

//Input: nums = [1,2,3]
//Output: 0

//public class Solution
//{
//    public int NumIdenticalPairs(int[] nums)
//    {
//        int count = 0;
//        var dict = new Dictionary<int, int>();
//        for (int i = 0; i < nums.Length; i++)
//        {
//            if (dict.ContainsKey(nums[i]))
//            {
//                count += dict[nums[i]];
//                dict[nums[i]]++;
//            }
//            else
//            {
//                dict[nums[i]] = 1;
//            }
//        }
//        return count;
//    }
//}
#endregion

#region Find Value After Performing Operation

//There is a programming language with only four operations and one variable X:

//++X and X++ increments the value of the variable X by 1.
//--X and X-- decrements the value of the variable X by 1.
//Initially, the value of X is 0.

//Given an array of strings operations containing a list of operations, return the final value of X after performing all the operations.



//Example 1:

//Input: operations = ["--X", "X++", "X++"]
//Output: 1
//Explanation: The operations are performed as follows:
//Initially, X = 0.
//--X: X is decremented by 1, X = 0 - 1 = -1.
//X++: X is incremented by 1, X = -1 + 1 = 0.
//X++: X is incremented by 1, X = 0 + 1 = 1.
//Example 2:

//Input: operations = ["++X", "++X", "X++"]
//Output: 3
//Explanation: The operations are performed as follows:
//Initially, X = 0.
//++X: X is incremented by 1, X = 0 + 1 = 1.
//++X: X is incremented by 1, X = 1 + 1 = 2.
//X++: X is incremented by 1, X = 2 + 1 = 3.
//Example 3:

//Input: operations = ["X++", "++X", "--X", "X--"]
//Output: 0
//Explanation: The operations are performed as follows:
//Initially, X = 0.
//X++: X is incremented by 1, X = 0 + 1 = 1.
//++X: X is incremented by 1, X = 1 + 1 = 2.
//--X: X is decremented by 1, X = 2 - 1 = 1.
//X--: X is decremented by 1, X = 1 - 1 = 0.


//public class Solution
//{
//    public int FinalValueAfterOperations(string[] operations)
//    {
//        int x = 0;
//        for (int i = 0; i < operations.Length; i++)
//        {
//            if (operations[i] == "--X")
//                --x;
//            else if (operations[i] == "++X")
//                ++x;
//            else if (operations[i] == "X++")
//                x++;
//            else if (operations[i] == "X--")
//                x--;
//        }
//        return x;
//    }
//}
#endregion

#region Build Array from Permutation

//Given a zero-based permutation nums (0-indexed), build an array ans of the same length where ans[i] = nums[nums[i]] for each 0 <= i < nums.length and return it.

//A zero-based permutation nums is an array of distinct integers from 0 to nums.length - 1 (inclusive).



//Example 1:

//Input: nums = [0,2,1,5,3,4]
//Output: [0,1,2,4,5,3]
//Explanation: The array ans is built as follows: 
//ans = [nums[nums[0]], nums[nums[1]], nums[nums[2]], nums[nums[3]], nums[nums[4]], nums[nums[5]]]
//    = [nums[0], nums[2], nums[1], nums[5], nums[3], nums[4]]
//    = [0,1,2,4,5,3]
//Example 2:

//Input: nums = [5,0,1,2,3,4]
//Output: [4,5,0,1,2,3]
//Explanation: The array ans is built as follows:
//ans = [nums[nums[0]], nums[nums[1]], nums[nums[2]], nums[nums[3]], nums[nums[4]], nums[nums[5]]]
//    = [nums[5], nums[0], nums[1], nums[2], nums[3], nums[4]]Given a zero-based permutation nums (0-indexed), build an array ans of the same length where ans[i] = nums[nums[i]] for each 0 <= i < nums.length and return it.

//A zero-based permutation nums is an array of distinct integers from 0 to nums.length - 1 (inclusive).



//Example 1:

//Input: nums = [0,2,1,5,3,4]
//Output: [0,1,2,4,5,3]
//Explanation: The array ans is built as follows: 
//ans = [nums[nums[0]], nums[nums[1]], nums[nums[2]], nums[nums[3]], nums[nums[4]], nums[nums[5]]]
//    = [nums[0], nums[2], nums[1], nums[5], nums[3], nums[4]]
//    = [0,1,2,4,5,3]
//Example 2:

//Input: nums = [5,0,1,2,3,4]
//Output: [4,5,0,1,2,3]
//Explanation: The array ans is built as follows:
//ans = [nums[nums[0]], nums[nums[1]], nums[nums[2]], nums[nums[3]], nums[nums[4]], nums[nums[5]]]
//    = [nums[5], nums[0], nums[1], nums[2], nums[3], nums[4]]



//public class Solution
//{
//    public int[] BuildArray(int[] nums)
//    {
//        int[] newArr = new int[nums.Length];
//        for (int i = 0; i < nums.Length; i++)
//        {
//            newArr[i] = nums[nums[i]];
//        }
//        return newArr;
//    }
//}
#endregion

#region How Many Numbers Are Smaller Than the Current Number TODO

//Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].

//Return the answer in an array.



//Example 1:

//Input: nums = [8,1,2,2,3]
//Output: [4,0,1,1,3]
//Explanation: 
//For nums[0]=8 there exist four smaller numbers than it (1, 2, 2 and 3). 
//For nums[1]=1 does not exist any smaller number than it.
//For nums[2]=2 there exist one smaller number than it (1). 
//For nums[3]=2 there exist one smaller number than it (1). 
//For nums[4]=3 there exist three smaller numbers than it (1, 2 and 2).Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it. That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].

//Return the answer in an array.



//Example 1:

//Input: nums = [8,1,2,2,3]
//Output: [4,0,1,1,3]
//Explanation: 
//For nums[0]=8 there exist four smaller numbers than it (1, 2, 2 and 3). 
//For nums[1]=1 does not exist any smaller number than it.
//For nums[2]=2 there exist one smaller number than it (1). 
//For nums[3]=2 there exist one smaller number than it (1). 
//For nums[4]=3 there exist three smaller numbers than it (1, 2 and 2).


//public class Solution
//{
//    public int[] SmallerNumbersThanCurrent(int[] nums)
//    {
//        var dict = new Dictionary<int, int>();
//        var sortedNums = nums.OrderBy(x => x).ToArray();
//        for (int i = 0; i < sortedNums.Length; i++)
//        {
//            if (!dict.ContainsKey(sortedNums[i]))
//            {
//                dict[sortedNums[i]] = i;
//            }
//        }
//        int[] result = new int[nums.Length];
//        for (int i = 0; i < nums.Length; i++)
//        {
//            result[i] = dict[nums[i]];
//        }

//        return result;

//    }
//}
#endregion

#region Maximum Subarray [ Kadanes Algorithm]    TODO

//Given an integer array nums, find the subarray with the largest sum, and return its sum.



//Example 1:

//Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
//Output: 6
//Explanation: The subarray[4, -1, 2, 1] has the largest sum 6.
//Example 2:

//Input: nums = [1]
//Output: 1
//Explanation: The subarray[1] has the largest sum 1.
//Example 3:

//Input: nums = [5, 4, -1, 7, 8]
//Output: 23
//Explanation: The subarray[5, 4, -1, 7, 8] has the largest sum 23.



//public class Solution
//{
//    public int MaxSubArray(int[] nums)
//    {
//        int maxCount = nums[0];
//        int currMax = nums[0];
//        for (int i = 1; i < nums.Length; i++)
//        {
//            currMax = Math.Max(currMax + nums[i], nums[i]);
//            maxCount = Math.Max(currMax, maxCount);
//        }
//        return maxCount;
//    }
//}

#endregion


#region Length of Last Word


//Given a string s consisting of words and spaces, return the length of the last word in the string.

//A word is a maximal substring consisting of non-space characters only.



//Example 1:

//Input: s = "Hello World"
//Output: 5
//Explanation: The last word is "World" with length 5.
//Example 2:

//Input: s = "   fly me   to   the moon  "
//Output: 4
//Explanation: The last word is "moon" with length 4.
//Example 3:

//Input: s = "luffy is still joyboy"
//Output: 6
//Explanation: The last word is "joyboy" with length 6.


//public class Solution
//{
//    public int LengthOfLastWord(string s)
//    {


//        string strimmed = s.Trim();
//        string[] words = strimmed.Split(' ');
//        string lastWord = words[words.Length - 1];


//        return lastWord.Count();

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




//public class Solution
//{
//    public int CharacterReplacement(string s, int k)
//    {
//        int[] charCount = new int[26];
//        int start = 0, maxCount = 0, maxLength = 0;

//        for (int end = 0; end < s.Length; end++)
//        {
//            maxCount = Math.Max(maxCount, ++charCount[s[end] - 'A']);

//            while (end - start + 1 - maxCount > k)
//            {
//                charCount[s[start] - 'A']--;
//                start++;
//            }

//            maxLength = Math.Max(maxLength, end - start + 1);
//        }

//        return maxLength;
//    }
//}




#endregion

#region Maximum Number of Words Found in Sentences
//A sentence is a list of words that are separated by a single space with no leading or trailing spaces.

//You are given an array of strings sentences, where each sentences[i] represents a single sentence.

//Return the maximum number of words that appear in a single sentence.



//Example 1:

//Input: sentences = ["alice and bob love leetcode", "i think so too", "this is great thanks very much"]
//Output: 6
//Explanation:
//-The first sentence, "alice and bob love leetcode", has 5 words in total.
//- The second sentence, "i think so too", has 4 words in total.
//- The third sentence, "this is great thanks very much", has 6 words in total.
//Thus, the maximum number of words in a single sentence comes from the third sentence, which has 6 words.
//Example 2:

//Input: sentences = ["please wait", "continue to fight", "continue to win"]
//Output: 3
//Explanation: It is possible that multiple sentences contain the same number of words. 
//In this example, the second and third sentences (underlined) have the same number of words.

//public class Solution
//{
//    public int MostWordsFound(string[] sentences)
//    {
//        int maxCount = 0;
//        int count = 0;
//        char[] separators = [' '];

//        for (int i = 0; i < sentences.Length; i++)
//        {
//            string[] newArr = sentences[i].Split(separators);
//            count = newArr.Count();
//            maxCount = Math.Max(count, maxCount);
//        }
//        return maxCount;

//    }
//}


#endregion

#endregion


