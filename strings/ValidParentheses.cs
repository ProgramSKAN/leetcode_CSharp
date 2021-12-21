using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace leetcode_CSharp
{

  /*
  20. Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
 An input string is valid if:
 Open brackets must be closed by the same type of brackets.
 Open brackets must be closed in the correct order.

 Example 1:

 Input: s = "()"
 Output: true
 Example 2:

 Input: s = "()[]{}"
 Output: true
 Example 3:

 Input: s = "(]"
 Output: false
 Example 4:

 Input: s = "([)]"
 Output: false
 Example 5:

 Input: s = "{[]}"
 Output: true
  */

  public class ValidParentheses
  {
    public static void Run()
    {
      isValid("()[]{}");
    }

    //create dictioanry of open close bracket pair of same type

    //loop through each char in the stack
    //if the element is open bracket, push it into the stack
    //if we encounter closing bracket, check the top element
    //if the elemt at top of the stack is opening bracket of same type, then pop off and continue else invalid


    public static bool isValid(string s)
    {
      var bracketsPair = new Dictionary<char, char>();
      bracketsPair.Add('(', ')');
      bracketsPair.Add('{', '}');
      bracketsPair.Add('[', ']');

      var stack = new Stack<char>();
      for (int i = 0; i < s.Length; i++)
      {
        if (bracketsPair.ContainsKey(s[i]))
        {
          stack.Push(s[i]);
        }

        if (bracketsPair.ContainsValue(s[i]) && stack.Count >= 1)
        {
          // If there is element at the top of the stack, store it as 'topChar' and see if it's key points to the current char's value

          if (stack.TryPeek(out char topChar) == true)
          {
            if (topChar == bracketsPair.FirstOrDefault(x => x.Value == s[i]).Key)
            {
              stack.Pop();
            }
            else
            {
              return false;
            }
          }
          else
          {
            return false;
          }
        }
      }

      //if there is element on stack it is invalid string
      return stack.Count == 0;
    }



    public bool IsValid(string s)//**
    {
      var stack = new Stack<char>();

      foreach (var c in s.ToCharArray())
      {
        if (c == '(')
          stack.Push(')');
        else if (c == '{')
          stack.Push('}');
        else if (c == '[')
          stack.Push(']');
        else if (stack.Count() == 0 || stack.Pop() != c)
          return false;
      }
      return stack.Count() == 0;
    }
  }
}