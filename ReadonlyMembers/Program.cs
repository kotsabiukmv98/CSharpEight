/*
 * You can apply the readonly modifier to any member of a STRUCT. 
 * It indicates that the member does not modify state.It's more 
 * granular than applying the readonly modifier to a struct declaration. 
 */
using System;

namespace ReadonlyMembers
{
    struct Rectangle
    {
        public Rectangle(double width, double height) =>
            (Width, Height) = (width, height);

        public double Width { get; set; }
        public double Height { get; set; }
        
        public /*readonly*/ override string ToString() => 
            $"Rectangle {Width:0.##} * {Height:0.##} with area {Area:0.###}";
        
        public /*readonly*/ double Area => Width * Height;

        public /*readonly*/ void Resize(double width, double height)
        {
            Width = width;
            Height = height;
        }
    }
    class Program
    {
        static void Main()
        {
            var rectangle = new Rectangle(43, 32.032);

            Console.WriteLine(rectangle);
        }
    }
}
