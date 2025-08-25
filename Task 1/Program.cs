using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение, а приложение выведет самое длинное слово: ");
            string userValue = Console.ReadLine();
            string[] arrayValue = userValue.Split();
            string maxLong = arrayValue[0];

            foreach (string temporaryVariable in arrayValue)
            {
                if (temporaryVariable.Length > maxLong.Length)
                {
                    maxLong = temporaryVariable;
                }
            }

            Console.WriteLine("Самое длинное слово: " + maxLong + ".");
            Console.ReadKey();
        }
    }
}
