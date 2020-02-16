using System;
using Xunit;
using OpenQA.Selenium;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Utilities.OpenChrome();
        }
    }
}
