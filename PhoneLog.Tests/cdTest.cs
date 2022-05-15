using System;
using Xunit;

namespace PhoneLog.Tests
{
    public class cdTest
    {
        CallDestination cd1 = new CallDestination("NoCountry", "NoRegion", "15", "32");
        CallDestination cd2 = new CallDestination("NoCountry", "NoWhere", "15", "32");

        [Fact]
        public void test()
        {
            Assert.Equal(cd1, cd2);
        }
    }
}
