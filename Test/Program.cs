﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = "Pechkin! Pochtaljon Pechkin A";
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "/", "'", "|" };

            int i, j;
            int count = 0;
                       
            List<string> c = Text.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            c.Sort();

            string[] b = new string[c.Count];
            int[] d = new int[c.Count];

            if (c.Count > 0)
            {
                for (i = 0; i < c.Count; i++)
                {
                    for (j = 0; j < c.Count; j++)
                    {
                        if (c[i] == b[j])
                        {
                            count++;
                            break;
                        }
                        if (c[i] != b[j] & b[j] == null)
                        {
                           b[i] = c[i];
                        }
                        if (c[i] == c[j])
                        {
                          count++;
                        }
                        d[i] = count;
                    }
                    
                    if (b[i] != null | c[i] == b[i])
                    {
                        Console.WriteLine(b[i].ToLower() + "-" + d[i]);
                        count = 0;
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
