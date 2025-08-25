using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение, а программа проверит, является ли оно палиндромом, либо нет: ");
            string userValue = Console.ReadLine();
            string clearedString = userValue.Replace(" ", "").ToLower();
            char[] valueArray = clearedString.ToCharArray();
            bool palindrome = true;
            int length = valueArray.Length;

            char[] reversedArray = (char[])valueArray.Clone();
            Array.Reverse(reversedArray);

            for (int i = 0; i < length; i++)
            {
                if (valueArray[i] != reversedArray[i])
                {
                    palindrome = false;
                    break;
                }
            }

            string result = (palindrome) ? "Это палиндром." : "Это не палиндром.";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
