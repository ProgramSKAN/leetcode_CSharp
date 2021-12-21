using System;
using static System.Console;

namespace leetcode_CSharp
{
  /// <summary>
  /// 7. Reverse Integer
  /// Given a 32-bit signed integer, reverse digits of an integer.
  /// IE) Input:  -123
  ///     Output: -321
// 
  // Input: x = 120
  // Output: 21
  /// </summary>
  public class ReverseInteger
  {
    public static void Run()
    {
      reverseInteger(-123);
      reverseInteger(120);
    }

    private static int reverseInteger(int num)
    {
      //check is number is negative
      //convert number to string
      //if number is negative add '-' at start and loop 1 less
      bool isNegative = false;
      string numToString = num.ToString();
      string reversedString = "";
      if (num < 0)
      {
        isNegative = true;
        reversedString += "-";
      }

      if (isNegative)
      {
        for (int i = numToString.Length - 1; i > 0; i--)
        {
          reversedString += numToString[i];
        }
      }
      else
      {
        for (int i = numToString.Length - 1; i >= 0; i--)
        {
          reversedString += numToString[i];
        }
      }

      //overflow cheack
      int result = 0;
      try
      {
        result = Convert.ToInt32(reversedString);
      }
      catch
      {
        return 0;
      }

      WriteLine(result);
      return result;
    }


    //int32 -2147483648 to 2147483647
    public int reverseInteger1(int x)
    {
      int reversed = 0;
      int pop;
      while (x != 0)
      {
        pop = x % 10; //123%3=3
        x = x / 10; //123/10=12

        if (reversed > Int32.MaxValue / 10 || (reversed == Int32.MaxValue / 10 && pop > 7))
          return 0;
        if (reversed < Int32.MinValue / 10 || (reversed == Int32.MinValue / 10 && pop < -8))
          return 0;

        reversed = (reversed * 10) + pop;
      }
      return reversed;
    }

  }
}