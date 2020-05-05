using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите Ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Вашу фамилию:");
            string surname = Console.ReadLine();

            Console.WriteLine("Укажите Ваш возраст:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите Ваш рост в сантиметрах:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите Ваш вес в килограммах:");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" " + name + " " + surname + " " + age + " лет, рост - " + height + " сантиметров, вес - " + weight + " килограммов");
            Console.WriteLine(String.Format(" Меня зовут {0}. Фамилия - {1}. Мне {2} лет. Мой рост {3} сантиметров, вес - {4} килограммов.", name, surname, age, height, weight));
            Console.WriteLine($" Меня зовут {name}. Фамилия - {surname}. Мне {age} лет. Мой рост {height} сантиметров, вес - {weight} килограммов.");
            Console.ReadKey();

        }
    }
}
