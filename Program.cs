﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double cont = 0;
            int a = 1;
            int b = 0;
            int c = 0;

            do
            {
                cont++;

                c = a + b;
                Console.Write("{0}, ", c);
                a = b;
                b = c;

            } 
            while (cont < 30);
        }
    }
}
