using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string name;
         int age;
         string zodiacSign;
         string job;

         Console.Write("Введите ваше Имя: ");
         name = Console.ReadLine();
         Console.Clear();
         Console.Write("Введите ваш возвраст: ");
         age = Convert.ToInt32(Console.ReadLine());
         Console.Clear();
         Console.Write("Введите ваш знак зодиака: ");
         zodiacSign = Console.ReadLine();
         Console.Clear();
         Console.Write("Введите кем вы работаете: ");
         job = Console.ReadLine();
         Console.Clear();
         Console.WriteLine($"Вас зовут {name},вам {age} лет!Ваш знак зодиака {zodiacSign}.Ваша должность {job}.");
         Console.ReadKey();
        }


        
    }
}
