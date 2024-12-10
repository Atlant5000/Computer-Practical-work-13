using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    /// <summary>
    /// Дан признак транспортного средства:
    /// a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд. 
    /// Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.
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
                case "а": return "автомобиль максимальная скорость 508,73 км/ч.";
                case "в": return "велосипед максимальная скорость 295,6 км/ч";
                case "м": return "мотоцикл максимальная скорость 200 км/ч.";
                case "с": return "самолёт максимальная скорость 8200,8 км/ч.";
                case "п": return "поезд максимальная скорость 574,8 км/ч.";
                default: return "Введена неправильная буква";
            }
        }
    }
}
