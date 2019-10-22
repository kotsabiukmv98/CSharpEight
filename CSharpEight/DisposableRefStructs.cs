/*
 * A struct declared with the ref modifier may not implement any interfaces
 * and so cannot implement IDisposable. Therefore, to enable a ref struct
 * to be disposed, it must have an accessible void Dispose() method. This
 * also applies to readonly ref struct declarations.
 */
using System;

namespace CSharpEight
{
    public /*ref*/ struct Rectangle : IDisposable
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Rectangle instance was Disposed!");
        }
    }

    public class DisposableRefStructs
    {
        static public void Demo()
        {
            using (var rectangle = new Rectangle())
            {
                // Some business logic
            }
        }
    }
}
