using System;

namespace Separator
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] separators = { ",", ".", "!", "?", ";", ":", " ", "/", "'", "|" };
            // string[] a = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            //string[] b = new string[a.Length];
            // int [] c = new int [a.Length];
            string[] a = { "a", "s", "a", "s", "a", "s" };
            string[] b = new string[a.Length];
            int i, j;
            int count = 0;

            for (i = 0; i < a.Length; i++)
            {
                    for (j = 0; j < a.Length; j++)
                    {
                    if (a[i] == b[j])
                    {
                        break;
                    }
                    if (a[i] != b[j] & b[j] == null)
                    {
                        b[i] = a[i];
                    }
                    if (a[i] == a[j])
                        count++;
                    }
                    if(b[i]!=null)
                Console.WriteLine(b[i]+"-"+ count);
                count = 0;
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
