using System.IO;

namespace GradeBook
{
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }
        public override event firstDelegate GradeAddedDelegate;

        public override void addNum(double num)
        {   
            string path = $"{Name}.txt";
            using (StreamWriter sw = File.AppendText(path)) 
            {
                sw.WriteLine(num);
            }	
        }

        public override Stats getStats()
        {
            Stats result = new Stats();

            using( var reader = File.OpenText($"{Name}.txt"))
            {
                var input = reader.ReadLine();
                while(input != null)
                {
                    result.add(double.Parse(input));
                    input = reader.ReadLine();
                }
            }

            return result;
        }

        public override void showStats()
        {
            throw new System.NotImplementedException();
        }
    }
}