using Bridge.Test.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bridge.ClientTest.Batch3.BridgeIssues
{
    [TestFixture(TestNameFormat = "#3777 - {0}")]
    public class Bridge3777
    {
        [Test]
        public static void TestAddDays()
        {
            DateTime d = DateTime.Now;
            DateTime d2 = d.AddDays(3);

            Assert.AreEqual(-1, DateTime.Compare(d, d2));
        }
    }
}