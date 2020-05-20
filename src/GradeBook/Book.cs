using System;
using System.Collections.Generic;

namespace GradeBook 
{
 
    public delegate void firstDelegate(object sender, EventArgs args);
    public interface Ibook
    {
        void addNum(double num);
        event firstDelegate GradeAddedDelegate;
        string Name{get; set;}
        double highNum{get; set;}
        double lowNum{get; set;}

    }
    public class nameObject
    {
        public string Name
        {
            get;
            set;
        }
        public nameObject(string name)
        {
            Name = name;
        }
    }

    public abstract class Book : nameObject, Ibook
    {
        public Book(string name) : base(name){}

        public double highNum{get; set;}
        public double lowNum{get; set;}
        public abstract event firstDelegate GradeAddedDelegate; 
        public abstract void addNum(double num);
        public abstract Stats getStats();
        public abstract void showStats();
    }
    public class InMemoryBook: Book
    {

        // Contructor of a class
        // base(name) pass name to nameObject
        public override event firstDelegate GradeAddedDelegate;
        public InMemoryBook(string name) : base(name)
        {
            list = new List<double>();
            Name = name;
        }
        public List<double> list = new List<double>();
        // public string Name;
        // private double highNum = double.MinValue;
        // private double lowNum = double.MaxValue;
        public string notes;
        const string CATEGORY = "Science";

        public override void addNum(double num) 
        {
            if(num > highNum) {highNum = num;};
            if(num < lowNum) {lowNum = num;};
            list.Add(num);
            
            if(GradeAddedDelegate != null)
            {
                GradeAddedDelegate(this, new EventArgs());
            }
        }

        public override void showStats()
        {
            double total = 0.0;
            foreach(var num in list) 
            {
                total += num;
                
            };

            Console.WriteLine($"{Name}'s Highest: {highNum}");
            Console.WriteLine($"{Name}'s Lowest: {lowNum}");
            Console.WriteLine($"{Name}'s average num: {total/list.Count:N1}");
        }
        public override Stats getStats()
        {
            Stats result = new Stats();
            foreach(var num in list) 
            {
                if(num > result.highNum){result.highNum = num;}
                if(num < result.lowNum){result.lowNum = num;}
                result.sum += num;
                result.count += 1;  
            };
            // result.average = total/list.Count;

            return result;
        }
    }
}