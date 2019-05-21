using Bridge.Test.NUnit;
using System;

namespace Bridge.ClientTest.ConvertTests
{
    [Category(Constants.MODULE_CONVERT)]
    [TestFixture(TestNameFormat = "Convert.ChangeType - {0}")]
    public class ConvertChangeTypeTests
    {
        [Test]
        public void ChangeTypeTests()
        {
            Assert.AreEqual(true, Convert.ChangeType("true", typeof(bool)));
            Assert.AreEqual('c', Convert.ChangeType("c", typeof(char)));
            Assert.AreEqual((sbyte)-81, Convert.ChangeType("-81", typeof(sbyte)));
            Assert.AreEqual((byte)82, Convert.ChangeType("82", typeof(byte)));
            Assert.AreEqual((short)-8182, Convert.ChangeType("-8182", typeof(short)));
            Assert.AreEqual((ushort)58182, Convert.ChangeType("58182", typeof(ushort)));
            Assert.AreEqual((int)-23438182, Convert.ChangeType("-23438182", typeof(int)));
            Assert.AreEqual((uint)111158182, Convert.ChangeType("111158182", typeof(uint)));
            Assert.AreEqual((long)77777111158182L, Convert.ChangeType("77777111158182", typeof(long)));
            Assert.AreEqual((ulong)177777111158182L, Convert.ChangeType("177777111158182", typeof(ulong)));
            Assert.AreEqual((double)77777.111158182, Convert.ChangeType("77777.111158182", typeof(double)));
            Assert.AreEqual((float)111.1111, Convert.ChangeType("111.1111", typeof(float)));

        }
    }
}
