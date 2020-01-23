// Exercise 1
// Calculate the area of a triangle using Heron's formula
// Area = SquareRoot(s * (s-a) * (s-b) * (s-c)) where s=(a+b+c)/2 and a,b,c are the sides of the triangle
// Eg. a=3, b=4, c=5. Area = 6



using System;

namespace Area_of_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please provide your input for a");

            string A = Console.ReadLine();

            double a = Convert.ToDouble(A);



            Console.WriteLine("Please provide your input for b");

            string B = Console.ReadLine();

            double b = Convert.ToDouble(B);



            Console.WriteLine("Please provide your input for c");

            string C = Console.ReadLine();

            double c = Convert.ToDouble(C);



            double s = (a + b + c) / 2;

            double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Area is" + Area);
        }
    }
}
