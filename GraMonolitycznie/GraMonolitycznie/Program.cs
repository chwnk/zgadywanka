﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj Świecie!");

            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();

            Console.WriteLine($"Witaj {imie} !!!");
        }
    }
}
