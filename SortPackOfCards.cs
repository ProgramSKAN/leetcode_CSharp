using System;
using System.Collections.Generic;
using System.Linq;
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
  public class SortPackOfCards
  {
    public static void Run()
    {
      // var cards = new List<string>(new string[] { "4h", "2h", "4c", "2c", "4s", "2s", "4d", "2d", "As" });
      var cards = new List<string>(new string[] { "3c", "Js", "2d", "10h", "Kh", "8s", "Ac", "4h" });
      sort(cards);
    }

    public static void sort(List<string> cards)
    {
      var nums = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
      var suits = new string[] { "d", "s", "c", "h" };

      var n = cards.Count;
      for (int i = 0; i < n - 1; i++)
      {
        for (int j = 0; j < n - i - 1; j++)
        {
          string[] l = splitAlphNumeric(cards[j]);
          string[] r = splitAlphNumeric(cards[j + 1]);

          // WriteLine(l[0] + ":" + Array.IndexOf(nums, l[0]) + ">" + r[0] + ":" + Array.IndexOf(nums, r[0]));
          if (
               (Array.IndexOf(nums, l[0]) > Array.IndexOf(nums, r[0]) && l[1] == r[1]) ||
              (Array.IndexOf(suits, l[1]) > Array.IndexOf(suits, r[1])))
          {
            swap(j, j + 1, ref cards);
          }
        }
      }
      WriteLine(String.Join(',', cards));
    }

    private static void swap(int i, int j, ref List<string> arr)
    {
      string temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;
    }

    public static string[] splitAlphNumeric(string input)
    {
      return new string[] { input.Substring(0, input.Length - 1), input.Substring(input.Length - 1) };
    }
  }
}