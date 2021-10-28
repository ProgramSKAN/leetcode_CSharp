using System;
using static System.Console;

namespace leetcode_CSharp
{
  /// <summary>
  /// 344. Reverse String
  /// Write a function that takes a string as input and returns the string reversed.
  /// IE) Input:  "hello"
  ///     Output: "olleh"
  /// </summary>
  public class ReverseString
  {
    public static void Run()
    {
      reverseString("hello");
    }

    private static string reverseString(string inputString)
    {
      //string to chars and reverse chars 
      var chars = inputString.ToCharArray();
      Array.Reverse(chars);
      return new String(chars);
    }

    private static string reverseString1(string inputString)
    {
      //using for loop
      //loop backwards from end of the string.
      string reversedString = "";
      for (int i = inputString.Length - 1; i >= 0; i--)
      {
        reversedString += inputString[i];
      }
      WriteLine(reversedString);
      return reversedString;
    }
  }
}

