﻿using NUnit.Framework;
namespace Example.Tests
{
    public class Class2
    {
        [Test]
        public void Test3()
        {
            Assert.Fail("test failed.");
        }

        [Test]
        public void Test4()
        {
            throw new System.Exception("fail");
        }
    }
}
