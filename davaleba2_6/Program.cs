﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("pirveli ricxvi: ");

            int n1 = int.Parse(Console.ReadLine());

            Console.Write("meore ricxvi: ");

            int n2 = int.Parse(Console.ReadLine());

            if(n1 != n2)
            {
                Console.WriteLine(n1 + n2);
            }else 
            { 
                Console.WriteLine(3 * (n1 + n2)); 
            }
        }
    }
}
