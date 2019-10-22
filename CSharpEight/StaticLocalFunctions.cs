/*
 * You can now add the static modifier to local functions to ensure that local 
 * function doesn't capture (reference) any variables from the enclosing scope. 
 */

namespace CSharpEight
{
    public class StaticLocalFunctions
    {
        public static int FirstDemo()
        {
            int y = -9;
            int x = 2;

            return Product(x, y);

            int Product(int firstMultiplier, int secondMultiplier)
            //static int Add(int left, int right)
            {
                y = 0;
                return firstMultiplier * secondMultiplier;
            };
        }
    }
}
