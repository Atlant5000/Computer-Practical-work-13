using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    /// <summary>
    /// Дан признак геометрической фигуры на плоскости: 
    /// к – круг, п – прямоугольник, т - треугольник. 
    /// Вывести на экран периметр и площадь заданной фигуры (данные, необходимые для расчетов, запросить у пользователя).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
            Console.ReadKey();
        }
        public static void Value()
        {
            string n = Input("Введите букву ");
            GetName(n);
            Console.ReadKey();
        }
        public static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static int Input1(string message)
        {
            Console.Write(message);
            return  int.Parse(Console.ReadLine());
        }
        public static void GetName(string letter)
        {
            switch (letter.ToLower())
            {
                case "т": 
                Console.WriteLine("треугольник");
                int x1 = Input1("x1=");
                int y1 = Input1("y1=");
                int x2 = Input1("x2=");
                int y2 = Input1("y2=");
                int x3 = Input1("x3=");
                int y3 = Input1("y3=");
                Console.WriteLine($"Периметр={P(F(x1, y1, x2, y2), F(x2, y2, x3, y3), F(x3, y3, x1, y1))},Площадь={Sq(F(x1, y1, x2, y2), F(x2, y2, x3, y3), F(x3, y3, x1, y1), (D(F(x1, y1, x2, y2), F(x2, y2, x3, y3), F(x3, y3, x1, y1))/2))}");
                break;
                case "к":
                Console.WriteLine("круг");
                int r = Input1("Введите радиус круга=");
                Console.WriteLine($"Периметр={FuncP(r)},Площадь={FuncS(r)}");
                break;
                case "п":
                Console.WriteLine("прямоугольник");
                int l = Input1("Длинна прямоугольника=");
                int l1 = Input1("Ширина прямоугольника=");
                Console.WriteLine($"Периметр={RectangleP(l,l1)},Площадь={RectangleS(l,l1)}");
                break;
                default: 
                Console.Write("Введена неправильная буква");
                break;
            }
        }
        public static double FuncP(int r)
        {
             return 2 * Math.PI * r;
        }
        public static double FuncS(int r)
        {
            return Math.PI * Math.Pow(r,2);
        }
        public static double F(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        public static double P(double a, double b, double c)
        {
            return (a + b + c);
        }
        public static int RectangleP(int l, int l1)
        {
            return (l1 + l)*2;
        }
        public static int RectangleS(int l, int l1)
        {
            return l * l1;
        }
        public static double Sq(double a, double b, double c, double p)
        {
            return 2 / a * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static double D(double a, double b, double c)
        {
            return (a + b + c);
        }
    }
}