/*
 * C# 8.0 introduces the null-coalescing assignment operator ??=. 
 * You can use the ??= operator to assign the value of its right-hand 
 * operand to its left-hand operand only if the left-hand operand 
 * evaluates to null.
 */
using System;
using System.Collections.Generic;

namespace CSharpEight
{
    public class NullCoalescingAssignment
    {
        static public void Demo(IList<int> numbers)
        {
            //if (numbers == null)
            //{
            //    numbers = new List<int>();
            //}

            //numbers = numbers ?? new List<int>();

            numbers ??= new List<int>();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
