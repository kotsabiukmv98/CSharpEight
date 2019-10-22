/*
 * You can apply the readonly modifier to any member of a struct. 
 * It indicates that the member does not modify state.It's more 
 * granular than applying the readonly modifier to a struct declaration. 
 */
using System;

namespace CSharpEight
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public /*readonly*/ double Distance => Math.Sqrt(X * X + Y * Y);

        public /*readonly*/ override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";

        public /*readonly*/ void MoveTo(double newX, double newY)
        {
            X = newX;
            Y = newY;
        }
    }
}
