using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //Определить, существует ли тругольник . Найти одну сторону этого треугольника, периметр и площадь.
        static void Func(double a, double b, double c)
        {
            if (a < b + c & b < a + c & c < a + b)
            {
                Console.Write("Треугольник существует");
            }
            else
            {
                Console.Write("Треугольник не существует");
            }
            
        }
        public static double Side(double x1,double x2,double y1,double y2)
        {

            double dlina=Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return dlina;
        }
        public static double Perimetr(double a, double b, double c)
        {
            double P = a + b + c;
            return P;
        }
        public static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Func(a, b, c);
            Console.WriteLine();
            Console.Write("Введите x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Длина одной из сторон = {Side(x1, x2, y1, y2)}");
            Console.WriteLine($"Периметр треугольника = {Perimetr(a, b, c)}");
            Console.WriteLine($"Площадь тругольника = {Square(a,b,c)}");
            Console.ReadKey();
        }
    }
}
