﻿using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args}");
            } 
            else 
            {
                Console.WriteLine("Hello Newcomer!");
            }
        }
    }
}
