using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestMethod1()
        {
            NUnit.Framework.Assert.Pass();
        }
    }
}
