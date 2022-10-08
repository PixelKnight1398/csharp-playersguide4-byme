using System;

namespace TheTriangleFarmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the triangle base?");
            double triBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the triangle height?");
            double triHeight = Convert.ToDouble(Console.ReadLine());

            double area = (triBase * triHeight) / 2;
            Console.WriteLine("Area of triangle is: ");
            Console.WriteLine(area);
        }
    }
}
