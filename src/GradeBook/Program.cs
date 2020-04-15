using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // double result = 15.4;

            var student1 = new Book("Tian");

            student1.addNum(12.3);
            student1.addNum(45.6);
            student1.addNum(78.9);

            student1.notes = "Tian is a idiot!";

            student1.showStats();

            Console.WriteLine(student1.notes);
            
            student1.notes = "Tian is nice!";
            Console.WriteLine(student1.notes);
            Console.WriteLine("--------------------");
            var student2 = new Book("Aaron");

            student2.addNum(34.5);
            student2.addNum(98.7);
            student2.addNum(32.1);

            student2.showStats();
            
            // Console.WriteLine(student1.Equals(student2));
            // var list = new List<double>();

            // list.Add(89.2);
            // list.Add(70.2);
            // list.Add(12.2);

            // foreach(var a in list) 
            // {
            //     result += a;
            // };

            // Console.WriteLine($"total number: {result}");

            // if(args.Length > 0)
            // {
            //     Console.WriteLine($"Hello {args}");
            // } 
            // else 
            // {
            //     Console.WriteLine("Hello Newcomer!");
            // }
        }
    }
}
