/*
 * Starting with C# 8.0, a constructed value type (a type that includes at least
 * one type argument) is unmanaged if it contains fields of unmanaged types only.
 * For any unmanaged type, you can create a pointer to a variable of this type
 * or allocate a block of memory on the stack for instances of this type:
 *
 * * A type is an unmanaged type if it's any of the following types:
    * sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, or bool
    * Any enum type
    * Any pointer type
    * Any user-defined struct type that contains fields of unmanaged types only and, a constructed type that includes only unmanaged type arguments
 */

using System;

namespace CSharpEight
{
    public class IntClass
    {
        public IntClass()
        {
        }
        public IntClass(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }
    public struct Point<T>
    {
        public T X;
        public T Y;
    }

    class UnmanagedConstructedTypes
    {
        static public void Demo()
        {
            Span<Point<int>> coordinates = stackalloc[]
            {
                new Point<int> { X = 0, Y = 0 },
                new Point<int> { X = 0, Y = 3 },
                new Point<int> { X = 4, Y = 0 }
            };

            //Span<Point<IntClass>> coords = stackalloc[]
            //{
            //    new Point<IntClass> { X = 0, Y = 0 },
            //    new Point<IntClass> { X = 0, Y = 3 },
            //    new Point<IntClass> { X = 4, Y = 0 }
            //};

            //Span<Point<int?>> coords = stackalloc[]
            //{
            //    new Point<int?> { X = 0, Y = 0 },
            //    new Point<int?> { X = 0, Y = 3 },
            //    new Point<int?> { X = 4, Y = 0 }
            //};


            //// Add AllowUnsafeBlocks in .csproj file
            //unsafe
            //{
            //    var pointer = stackalloc[]
            //    {
            //        new Point<int> { X = 0, Y = 0 },
            //        new Point<int> { X = 0, Y = 3 },
            //        new Point<int> { X = 4, Y = 0 }
            //    };
            //}
        }
    }
}
