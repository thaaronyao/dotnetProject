using System;
using System.Collections.Generic;

namespace GradeBook 
{
    public class Book 
    {

        public Book(string name) 
        {
            list = new List<double>();
            this.name = name;
        }
        private List<double> list;
        private string name;
        private double highNum = double.MinValue;
        private double lowNum = double.MaxValue;
        public string notes;

        public void addNum(double num) 
        {
            if(num > highNum) {highNum = num;};
            if(num < lowNum) {lowNum = num;};
            list.Add(num);
        }

        public void showStats()
        {
            double total = 0.0;
            foreach(var num in list) 
            {
                total += num;
                
            };

            Console.WriteLine($"{this.name}'s Highest: {highNum}");
            Console.WriteLine($"{this.name}'s Lowest: {lowNum}");
            Console.WriteLine($"{this.name}'s average num: {total/list.Count:N1}");
        }
        public Stats getStats()
        {
            var result = new Stats();
            double total = 0.0;
            foreach(var num in list) 
            {
                total += num;
                
            };
            result.highNum = highNum;
            result.highNum = highNum;
            result.average = total/list.Count;

            return result;
        }
    }
}