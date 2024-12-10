using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.
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
            Console.WriteLine(GetName(n));
            Console.ReadKey();
        }
        public static string Input(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        public static string GetName(string letter)
        {
            switch (letter.ToLower())
            {
                case "ф": return "физика";
                case "м": return "математика";
                case "и": return "история";
                case "г": return "география";
                case "б": return "биология";
                default: return "Введена неправильная буква";
            }
        }
    }
}
