using System;
using System.Collections.Generic;

public class Solution
{
  public int MissingNumber(int[] nums)
  {
    var dummyArr = new List<int>();

    for (int i = 0; i < nums.Length + 1; i++)
    {
      dummyArr.Add(i);
    }

    for (int j = 0; j < nums.Length; j++)
    {
      if (dummyArr.Contains(nums[j]))
      {
        dummyArr.Remove(nums[j]);
      }
    }

    return dummyArr[0];
  }
}