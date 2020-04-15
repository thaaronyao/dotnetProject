using System;
using Xunit;

namespace GradeBook.Tests
{
    public class GradeBook
    {
        [Fact]
        public void Test1()
        {
            var test1 = new Book("Test");
            test1.addNum(12.3);
            test1.addNum(32.1);
            test1.addNum(33.1);
            Stats result = test1.getStats();

            Console.WriteLine(result.highNum);
            
                // assert.equal(0,0);
                // assert
            // Xunit.Assert.equal(result.highNum, 33.1);
            // Assert.equal(result.highNum, 33.1);
        }
    }
}
