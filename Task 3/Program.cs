using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение со скобками, а программа удалит всё, что содержится внутри скобок: ");
            string userValue = Console.ReadLine();

            while (true)
            {
                int openIndex = userValue.IndexOf("(");
                if (openIndex == -1) break;

                int closedIndex = userValue.IndexOf(")", openIndex);
                if (closedIndex == -1) break;

                userValue = userValue.Remove(openIndex, closedIndex - openIndex + 1);
            }

            Console.WriteLine(userValue);
            Console.ReadKey();

        }
    }
}
