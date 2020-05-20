using System;
using Xunit;

namespace GradeBook.Tests
{
    public class GradeBook
    {
        [Fact]
        public void Test1()
        {
            var test1 = new InMemoryBook("Test");
            test1.addNum(12.3);
            test1.addNum(32.1);
            test1.addNum(33.1);
            Stats result = test1.getStats();

            Console.WriteLine(result.highNum);
            // assert.equal(12,12);
            // Console.WriteLine(Xunit);
            // Assert.Equal(12,12);
            Assert.Equal(33.1,result.highNum);
            // Assert.equal(12,12);
        }

        [Fact]
        public void Test2()
        {
            var book1 = new InMemoryBook("Book1");
            book1.Name = "changed";

            // Assert.equal(book1.Name,"changed");
        }
    }
}
