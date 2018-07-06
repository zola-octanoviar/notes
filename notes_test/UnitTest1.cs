using System;
using Xunit;

namespace notes_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);       
            Assert.Equal("abc", "abc");       

            bool  expectedTrue = true;
            Assert.True(expectedTrue);

            // failed test
            //expectedTrue = false;
            //Assert.True(expectedTrue);

            bool expectedFalse = false;
            Assert.False(expectedFalse);


            // failed test
            //expectedFalse = true;
            //Assert.False(expectedFalse);
        }
    }
}
