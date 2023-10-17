
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryCalculator
{
    
    class GeometryCalculator
    {
        public static double CalculateSquareArea(double sideLength)
        {
            return sideLength * sideLength;
        }

        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static double CalculateCubeVolume(double sideLength)
        {
            return Math.Pow(sideLength, 3);
        }

        public static double CalculateSphereVolume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geometric Calculator");

            Console.Write("Enter the side length of a square: ");
            double squareSide = double.Parse(Console.ReadLine());
            double squareArea = GeometryCalculator.CalculateSquareArea(squareSide);
            Console.WriteLine($"Square area: {squareArea}");

            Console.Write("Enter the radius of a circle: ");
            double circleRadius = double.Parse(Console.ReadLine());
            double circleArea = GeometryCalculator.CalculateCircleArea(circleRadius);
            Console.WriteLine($"Circle area: {circleArea}");

            Console.Write("Enter the side length of a cube: ");
            double cubeSide = double.Parse(Console.ReadLine());
            double cubeVolume = GeometryCalculator.CalculateCubeVolume(cubeSide);
            Console.WriteLine($"Cube volume: {cubeVolume}");

            Console.Write("Enter the radius of a sphere: ");
            double sphereRadius = double.Parse(Console.ReadLine());
            double sphereVolume = GeometryCalculator.CalculateSphereVolume(sphereRadius);
            Console.WriteLine($"Sphere volume: {sphereVolume}");

            Console.Read();
        }
    }

}
