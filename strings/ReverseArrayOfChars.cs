using System;
using static System.Console;

namespace leetcode_CSharp
{
  /// <summary>
  /// 344. Reverse String
  /// Write a function that reverses a string. The input string is given as an array of characters s.
  // Input: s = ["h","e","l","l","o"]
  // Output: ["o","l","l","e","h"]
  /// </summary>
  public class ReverseArrayOfChars
  {
    public static void Run()
    {
      reverseArrayOfChars(new char[] { 'h', 'e', 'l', 'l', 'o' });
    }

    private static void reverseArrayOfChars(char[] input)
    {
      //swap the chars of array
      //['h','e','l','l','o']
      //length=5

      var length = input.Length;
      for (int i = 0; i < length / 2; i++)
      {
        var temp = input[i];
        input[i] = input[length - i - 1];
        input[length - i - 1] = temp;
      }

      WriteLine(input);
    }
  }
}