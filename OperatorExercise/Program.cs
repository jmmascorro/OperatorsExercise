using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            if (a == 17 && b == 4)
            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
           
            var areaOfCircle = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius of {radius} is {areaOfCircle}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius; 
        }
    }
}
