﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AkismetMsUnitTests
{
    [TestClass]
    public class TestSuite
    {
        [TestMethod]
        public void PassingMsUnitTest()
        {
            Assert.IsTrue(1 == 1);
        }

        [TestMethod]
        public void AnotherPassingMsUnitTest()
        {
            Assert.IsTrue(2 == 2);
        }
    }
}
