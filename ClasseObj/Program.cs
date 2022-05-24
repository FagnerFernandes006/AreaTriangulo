using System.Globalization;
using System;
namespace ClasseObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo X, Y;
            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com as medidas do triangulo Y:");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = X.Area();

            double areaY = Y.Area();

            Console.WriteLine("Triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior Triangulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Maior Triangulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
        }
    }
}


