using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите часы: ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int minute = int.Parse(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int seconds = int.Parse(Console.ReadLine());
            Time time = new Time(hour, minute, seconds);
            time.Print();
            time.Change();
            time.Print();
            Console.ReadKey();
        }
    }
}
