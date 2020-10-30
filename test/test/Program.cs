using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Здравствуй! Сколько дней ты уже прожил? ");
                var days = Convert.ToInt32(Console.ReadLine()); // конвертируем, т.к ReadLine возвращает только строки
                var years = days / 365;
                var month = days % 365 / 30; 
                var day = days - years * 365 - month * 30; 
                Console.WriteLine($"Тебе {years} лет, {month} месяцев и {day} дней, неплохо ;)"); // выводим 
                if (years >= 18) { 
                    for(var i = 1; i <= 10; i++) { 
                    Console.Write($"{i} "); 
                    } 
                    Console.WriteLine(); 
                    Console.Write("Ты совершеннолетний, поздравляю с:");
                } else { 
                Console.WriteLine("Тебе еще нет 18, все самое интересное впереди <3 "); 
                } 
         Console.ReadKey(); 
        }
    }
}
