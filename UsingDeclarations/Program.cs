/*
 * A using declaration is a variable declaration preceded by the using keyword. 
 * It tells the compiler that the variable being declared should be disposed at 
 * the end of the enclosing scope.
 */
 using System;

namespace UsingDeclarations
{
    class A : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Class A was disposed!");
        }
    }
    class B : IDisposable
    {
        public void Dispose()
        {

            Console.WriteLine("Class B was disposed!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OldUsingDeclarationDemo();
            NewUsingDeclarationDemo();
        }

        static int OldUsingDeclarationDemo()
        {
            int result = 0;

            using (var a = new A())
            {
                // Some business logic here
                using (var b = new B())
                {
                    // More business logic here
                    result = 10;
                }
            }
            return result;
        }

        static int NewUsingDeclarationDemo()
        {
            int result = 0;

            using var a = new A();
            // Some business logic here
            using var b = new B();
            b.Dispose();
            // More business logic here
            result = 10;

            return result;
        }
    }
}
