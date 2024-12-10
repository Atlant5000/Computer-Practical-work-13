using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    /// <summary>
    /// Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
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
            int n = Input("Введите число от 1 до 7 ,n=");
            Console.WriteLine(GetName(n)); 
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static string GetName(int day)
        {
            switch (day)
            {
                case 1:return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default:return "Введено неправильное число";
            }
        }
    }
}
