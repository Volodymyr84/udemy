using System;

namespace Separator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "/", "'", "|" };
            string[] a = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int count = 1;
            string[] b = new string[a.Length];

                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }

                count = 1;
                for (int k = 0; k < b.Length; k++)
                {
                    if (b[k] == a[i])
                        else
                    { }

                }
                
               
                Console.WriteLine(a[i] + "-" + count);
            }
           
        }
    }
}


/*
 * Дан текст телеграммы, введенный в одну строку. Слова в тексте разделяются одним или несколькими пробелами. Текст может содержать знаки препинания:
    , . : ; ? ! - " '
    Требуется посчитать, какие слова есть в этом тексте и сколько раз они встречаются. Слова вывести в алфавитном порядке в нижнем регистре в форме
    слово - КоличествоПовторений
    https://www.videosharp.info/console/task/level=1733
 */
