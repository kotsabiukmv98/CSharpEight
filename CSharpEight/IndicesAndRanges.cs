/*
 * Indices and ranges provide a succinct syntax for accessing single 
 * elements or ranges in a sequence.
 */

using System;

namespace CSharpEight
{
    public class IndicesAndRanges
    {
        private static string[] weekDays = new string[]
        {
                                // index from start                index from end
            "Monday",           // 0                               ^7
            "Tuesday",          // 1                               ^6
            "Wednesday",        // 2                               ^5
            "Thursday",         // 3                               ^4
            "Friday",           // 4                               ^3
            "Saturday",         // 5                               ^2
            "Sunday",           // 6                               ^1
                                // 7 (or words.Length)             ^0
        };
        public static void IndexDemo()
        {
            var i0 = new Index();
            var i1 = new Index(value: 0, fromEnd: false);
            var i2 = (Index)1;
            Index i3 = 5;
            var i4 = Index.FromStart(1);
            var i5 = Index.FromEnd(2);
            var i6 = Index.End;
            var i7 = Index.Start;
            var i8 = ^0;

            
            Console.WriteLine($"The last week day is {weekDays[^1]}"); // weekDays[^0] - IndexOutOfRangeException 😱😱😱
        }

        public static void RangeDemo()
        {
            var i1 = new Index(0);
            var i2 = ^0;

            var r0 = new Range();
            var r1 = new Range(i1, i2);
            var r2 = Range.All;
            var r3 = Range.EndAt(i1);
            var r4 = Range.EndAt(i2);

            var r5 = i1..i2; // new Range(i1, i2)
            var r6 = i1..;   // new Range(i1, new Index(0, true))
            var r7 = ..i2;   // new Range(new Index(0, false), i2)
            var r8 = ..;     // new Range(new Index(0, false), new Index(0, true))

            var r9 = 2..0;
            var arr = new int[] { 0, 1, 2, 3 };
            //var arr1 = arr[r9]; // ArgumentOutOfRangeException 😱😱😱
            var arr2 = arr[0..3];
            var arr3 = arr[0..^1];
            var arr4 = arr[0..^0];

            //var subStr = "hello, world"[8..3]; // ArgumentOutOfRangeException 😱😱😱
        }
    }
}
