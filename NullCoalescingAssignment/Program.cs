/*
 * C# 8.0 introduces the null-coalescing assignment operator ??=. 
 * You can use the ??= operator to assign the value of its right-hand 
 * operand to its left-hand operand only if the left-hand operand 
 * evaluates to null.
 */
using System;
using System.Collections.Generic;

namespace NullCoalescingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<int> numbers = null;

            if (numbers == null)
            {
                numbers = new List<int>{ 1, 2, 3, 4, 5, 6};
            }
            Console.WriteLine(string.Join(" ", numbers));

            numbers = null;
            numbers = numbers ?? new List<int>{ 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(string.Join(" ", numbers));

            numbers = null;
            numbers ??= new List<int>{ 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
