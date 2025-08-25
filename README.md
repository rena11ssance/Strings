# Строки

Задание. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Найти самое длинное слово в строке.

Решение:
```
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

```
___
Задание. Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).

Решение:
```
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

```
___
Задание. Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. В строке может быть несколько фрагментов, заключённых в фигурные скобки. Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.

Решение:
```
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

```
