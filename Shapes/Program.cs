using System;
using Shapes;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            Console.WriteLine($"Width: {r.Width}");
            r.Height = 67;
            Console.WriteLine($"Height: {r.Height}");

            r.Color = "Red"; // write-only
            Console.WriteLine($"Id: {r.Id}");

            r.Name = "Rectangle1";
            Console.WriteLine($"Info: {r.Info}");
            Console.WriteLine($"Area: {r.Area}");
        }
    }
}