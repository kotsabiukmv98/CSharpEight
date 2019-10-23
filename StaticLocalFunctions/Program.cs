/*
 * You can now add the static modifier to local functions to ensure that local 
 * function doesn't capture (reference) any variables from the enclosing scope. 
 */
 using System;

namespace StaticLocalFunctions
{
    class Program
    {
        static void Main()
        {
            int x = 2;
            int y = -9;

            var product =  Product(x, y);

            //static int Product(int firstMultiplier, int secondMultiplier)
            int Product(int firstMultiplier, int secondMultiplier)
            {
                //y = 0;
                return firstMultiplier * secondMultiplier;
            };

            Console.WriteLine(product);
        }
    }
}
