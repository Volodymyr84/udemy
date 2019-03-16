using System;
using System.Linq;
using System.Collections.Generic;


namespace Separator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "Pechkin! Pochtaljon Pechkin A";
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "/", "'", "|" };
            string[] a = Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

         

            string[] b = new string[a.Length];
            int i, j;
            int count = 0;

            if (a.Length > 0)
            {
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
                        {
                            count++;
                        }
                    }
                    if (b[i] != null)
                    {

                        List<string> c = b[i].Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
                        c.Sort();
                        Console.WriteLine(string.Join("-",c)+"-"+ count);


                        //Console.WriteLine(b[i].ToLower() + "-" + count);
                    }
                    count = 0;
                }
            }
            else
            {
                Console.WriteLine("-");
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
