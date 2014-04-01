using MbUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.JustMock;

namespace AkismetUnitTests
{
    [TestFixture]
    public class TestsSuite
    {
        [Test]
        [Author("Very Doge")]
        [Description("Much testing. WOW")]
        public static void TestingMockingFramework()
        {
            var list = Mock.Create<IList>();
            Mock.Arrange(() => list.Count).Returns(3);
            Mock.Assert(list);
        }

        [Test]
        [Author("Nader")]
        [Description("This is a failing test")]
        public static void FailingTest()
        { 
            Assert.IsTrue(1 == 2);
        }

        [Test]
        [Author("Nader")]
        [Description("This is a passing test")]
        public static void PassingTest()
        {
            Assert.IsTrue(1 == 1);
        }
    }
}
