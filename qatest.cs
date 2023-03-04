using System;

namespace TriangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of 3 points in 2-dimensional coordinate system: ");

            // Read input coordinates for three points
            Console.Write("Point A(x,y): ");
            string[] inputA = Console.ReadLine().Split(",");
            double ax = double.Parse(inputA[0]);
            double ay = double.Parse(inputA[1]);

            Console.Write("Point B(x,y): ");
            string[] inputB = Console.ReadLine().Split(",");
            double bx = double.Parse(inputB[0]);
            double by = double.Parse(inputB[1]);

            Console.Write("Point C(x,y): ");
            string[] inputC = Console.ReadLine().Split(",");
            double cx = double.Parse(inputC[0]);
            double cy = double.Parse(inputC[1]);

            // Calculate the length of sides using distance formula
            double ab = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
            double bc = Math.Sqrt(Math.Pow((cx - bx), 2) + Math.Pow((cy - by), 2));
            double ac = Math.Sqrt(Math.Pow((cx - ax), 2) + Math.Pow((cy - ay), 2));

            // Check if it's an equilateral triangle
            bool isEquilateral = (ab == bc) && (bc == ac);

            // Check if it's an isosceles triangle
            bool isIsosceles = (ab == bc) || (bc == ac) || (ac == ab);

            // Check if it's a right triangle
            double delta = 0.000001;
            bool isRight = (Math.Abs(Math.Pow(bc, 2) - (Math.Pow(ab, 2) + Math.Pow(ac, 2))) <= delta) ||
                            (Math.Abs(Math.Pow(ab, 2) - (Math.Pow(bc, 2) + Math.Pow(ac, 2))) <= delta) ||
                            (Math.Abs(Math.Pow(ac, 2) - (Math.Pow(ab, 2) + Math.Pow(bc, 2))) <= delta);

            // Calculate the perimeter
            double perimeter = ab + bc + ac;

            // Print the results
            Console.WriteLine("Length of sides: AB = {0}, BC = {1}, AC = {2}", Math.Round(ab, 2), Math.Round(bc, 2), Math.Round(ac, 2));
            Console.WriteLine("Is it an equilateral triangle? {0}", isEquilateral);
            Console.WriteLine("Is it an isosceles triangle? {0}", isIsosceles);
            Console.WriteLine("Is it a right triangle? {0}", isRight);
            Console.WriteLine("Perimeter of the triangle: {0}", Math.Round(perimeter, 2));

            // Print even numbers from 0 to perimeter
            Console.WriteLine("Even numbers from 0 to {0}:", Math.Round(perimeter, 2));
            for (int i = 0; i <= Math.Round(perimeter, 0); i += 2)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
