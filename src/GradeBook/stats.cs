namespace GradeBook
{
    public class Stats
    {
        public double highNum;
        public double lowNum;
        public double sum;
        public int count;

        public void add(double num)
        {
            if(num > highNum) highNum = num;
            if(num < lowNum) lowNum = num;
            sum += num;
            count++;
        }
        public Stats()
        {
            this.highNum = double.MinValue;
            this.lowNum = double.MaxValue;
            this.sum = 0;
            this.count = 0;
        }

        public double average
        {
            get {
                return sum/count;
            }
        }

    }
}