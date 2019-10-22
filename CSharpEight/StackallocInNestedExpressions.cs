/*
 * Starting with C# 8.0, if the result of a stackalloc expression 
 * is of the System.Span<T> or System.ReadOnlySpan<T> type, you 
 * can use the stackalloc expression in other expressions:
 */

using System;

namespace CSharpEight
{
    public class StackallocInNestedExpressions
    {
        static public void Demo()
        {
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            var ind = numbers.IndexOfAny(stackalloc[] { 2, 4, 6, 8 });

            //Span<int> span = stackalloc[] { 2, 4, 6, 8 };
            //var ind = numbers.IndexOfAny(span);

            Console.WriteLine(ind);
        }
    }
}
