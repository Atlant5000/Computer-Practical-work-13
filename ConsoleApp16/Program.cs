using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Value();
            Console.ReadKey();
        }
        public static void Value()
        {
            int n = Input("Введите число от 1 до 12 ,month=");
            Console.WriteLine(GetName(n));
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static string GetName(int month)
        {
            switch (month)
            {
                case 1: case 2: case 12: return "Зима";
                case 3: case 4: case 5: return "Весна";
                case 6: case 7: case 8: return "Лето";
                case 9: case 10: case 11: return "Осень";
                default: return "Введено неправильное число";
            }
        }
    }
}
