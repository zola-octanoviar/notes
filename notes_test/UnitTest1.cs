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
           Assert.Equal(true, true);
           // failed test
           //Assert.Equal(false, true);
        }
    }
}
