﻿/*
 * Indices and ranges provide a succinct syntax for accessing single 
 * elements or ranges in a sequence.
 */
 using System;

namespace IndicesAndRanges
{
    class Program
    {
        public static void Main()
        {
            IndexDemo();
            RangeDemo();
        }

        private static readonly string[] weekDays = new string[]
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
            Index i2 = 5;
            var i3 = (Index)1;
            var i4 = Index.FromStart(1);
            var i5 = Index.FromEnd(2);
            var i6 = Index.End;
            var i7 = Index.Start;
            var i8 = ^0;

            Console.WriteLine($"The last week day is {weekDays[^1]}"); // weekDays[^0] - IndexOutOfRangeException 😱😱😱

            Console.WriteLine("", i0, i1, i2, i3, i4, i5, i6, i7, i8);
        }

        public static void RangeDemo()
        {
            var i1 = new Index(0);
            var i2 = ^0;

            var r0 = new Range();
            var r1 = new Range(i1, i2);
            var r2 = Range.All;
            var r3 = Range.EndAt(i1);
            var r4 = Range.StartAt(i2);

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

            Console.WriteLine("", r0, r1, r2, r3, r4, r5, r6, r7, r8, r9, arr2, arr3, arr4);
        }
    }
}
