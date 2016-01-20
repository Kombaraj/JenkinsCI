using System;
using JenkinsCI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsCI.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual("Hello World",Program.CreateMessage());
        }
    }
}
