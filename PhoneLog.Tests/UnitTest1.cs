using System;
using Xunit;

namespace PhoneLog.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanFindCountry()
        {
            Assert.Equal("Anglia", ReadData.FindCountry("4429562316", "..\\..\\..\\..\\PhoneLog\\data\\country.txt"));
            Assert.Equal("USA", ReadData.FindCountry("12345678910", "..\\..\\..\\..\\PhoneLog\\data\\country.txt"));
        }

        [Fact]
        public void CanFindCountryAndRegion()
        {
            CallDestination wtf = new CallDestination("Anglia", "Cardiff", "44", "29");
            Assert.Equal(wtf, ReadData.FindCountryAndRegion("44291234567", "..\\..\\..\\..\\PhoneLog\\data\\country.txt", "..\\..\\..\\..\\PhoneLog\\data\\area.txt"));
        }
    }
}