using System;

namespace CSharpEight
{
    public class A : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Class A was disposed!");
        }
    }
    public class B : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Class B was disposed!");
        }
    }

    class UsingDeclarations
    {
        static public void FirstDemo()
        {
            using (var a = new A())
            {
                // Some business logic

                using (var b = new B())
                {

                    // More business logic
                
                }
            }

            Console.WriteLine("--------------");
            
            using var aa = new A();
            // Some business logic
            using var bb = new B();
            // More business logic
        }

        static public int SecondDemo()
        {
            using (var a = new A())
            {
                using (var b = new B())
                {

                }
            }

            using var aa = new A();
            int result = 0;
            using var bb = new B();
            return result;
        }
    }
}
