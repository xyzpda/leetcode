using System;
using Xunit;

namespace _0001.TwoSum;

// https://leetcode.com/problems/two-sum/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int first = 0;
        int second = 1;
        for(int i = first; i < nums.Length - 1; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if (target == (nums[i] + nums[j]))
                {
                    first = i;
                    second = j;
                    continue;
                }
            }
        }
        return new int[] {first, second};
    }
}

public class UnitTest1
{
    [Fact]
    public void Example1()
    {
        // Arrage
        int [] nums = new int[] {2,7,11,15};
        int target = 9;

        // Act
        int[] actual = new Solution().TwoSum(nums, target);

        // Assert
        Assert.Equal<int[]>(new int[] {0,1}, actual);
    }

    [Fact]
    public void Example2()
    {
        // Arrage
        int [] nums = new int[] {3, 2, 4};
        int target = 6;

        // Act
        int[] actual = new Solution().TwoSum(nums, target);

        // Assert
        Assert.Equal<int[]>(new int[] {1,2}, actual);
    }

    [Fact]
    public void Example3()
    {
        // Arrage
        int [] nums = new int[] {3, 3};
        int target = 6;

        // Act
        int[] actual = new Solution().TwoSum(nums, target);

        // Assert
        Assert.Equal<int[]>(new int[] {0,1}, actual);
    }

    [Fact]
    public void Case1()
    {
        // Arrage
        int [] nums = new int[] {2, 5, 5, 11};
        int target = 10;

        // Act
        int[] actual = new Solution().TwoSum(nums, target);

        // Assert
        Assert.Equal<int[]>(new int[] {1, 2}, actual);
    }
}

