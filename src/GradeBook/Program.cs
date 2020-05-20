using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // double result = 15.4;
            Console.WriteLine("Input your name: ");
            string nameInput = Console.ReadLine();


            var student1 = new InMemoryBook(nameInput);
            var student2 = new DiskBook(nameInput);
            // student1.GradeAddedDelegate += notification;
            // OnInputGrades(student1);
            OnInputGrades(student2);

            Stats stats = student2.getStats();
            Console.WriteLine($"{student2.Name}'s highest input is: {stats.highNum}");
            Console.WriteLine($"{student2.Name}'s lowest input is: {stats.lowNum}");
            Console.WriteLine($"{student2.Name}'s average input is: {stats.average}");
        }

        static void notification(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
            Console.WriteLine(e);

        } 
        private static void OnInputGrades(Book studentGradeBook)
        {
            while (true)
            {

                try
                {

                    Console.WriteLine($"Please input your grade: ");
                    var num = Console.ReadLine();
                    if (num == "q") { break; }

                    double parsed = double.Parse(num);
                    studentGradeBook.addNum(parsed);

                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e);
                }

            }

            
                // studentGradeBook.showStats();
        }
    }
}
