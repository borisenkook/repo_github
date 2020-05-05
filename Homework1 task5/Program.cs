using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_task5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(" Меня зовут Ольга Борисенко. Я живу в городе Санкт-Петербург.");

            string str = " Меня зовут Ольга Борисенко. Я живу в городе Санкт-Петербург.";
            Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.WindowHeight / 2);
            Console.WriteLine(str);
            Console.WriteLine(Signature());
            Console.ReadKey();
        }
        static string Signature()
        {
            return "Ольга Борисенко, Санкт-Петербург";
        }
        
    }
}
