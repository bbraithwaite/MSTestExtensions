using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExtensions.Tests
{
    [TestClass]
    public class MsTestAssertionsTest
    {
        private class MyClass
        {
            protected bool Equals(MyClass other)
            {
                return Prop == other.Prop;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((MyClass) obj);
            }

            public override int GetHashCode()
            {
                return Prop;
            }

            public Int32 Prop { get; set; }
        }

        [TestMethod]
        public void TestMethodAreEqualTemplated()
        {
            MyClass left = new MyClass() {Prop = 1};
            MyClass right = new MyClass() {Prop = 2};
            try
            {
                Assert.AreEqual(left, right);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<MSTestExtensions.Tests.MsTestAssertionsTest+MyClass>. Actual:<MSTestExtensions.Tests.MsTestAssertionsTest+MyClass>. ", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodAreEqualTemplatedMessage()
        {
            MyClass left = new MyClass() { Prop = 1 };
            MyClass right = new MyClass() { Prop = 2 };

            try
            {
                Assert.AreEqual(left, right, "MyClasses are not equal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<MSTestExtensions.Tests.MsTestAssertionsTest+MyClass>. Actual:<MSTestExtensions.Tests.MsTestAssertionsTest+MyClass>. MyClasses are not equal", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodAreEqualTemplatedMessageFormat()
        {
            MyClass left = new MyClass() { Prop = 1 };
            MyClass right = new MyClass() { Prop = 2 };

            try
            {
                Assert.AreEqual(left, right, "{0} and {1} MyClasses are not equal", "left", "right");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<MSTestExtensions.Tests.MsTestAssertionsTest+MyClass>. Actual:<MSTestExtensions.Tests.MsTestAssertionsTest+MyClass>. left and right MyClasses are not equal", e.Message);
            }

        }

        [TestMethod]
        public void TestMethodAreEqualSingle()
        {
            const Single left = 1;
            const Single right = 2;

            try
            {
                Assert.AreEqual(left, right);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<1>. Actual:<2>. ", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodAreEqualSingleMessage()
        {
            const Single left = 1;
            const Single right = 2;

            try
            {
                Assert.AreEqual(left, right, "Singles are not equal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<1>. Actual:<2>. Singles are not equal", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodAreEqualSingleMessageFormat()
        {
            const Single left = 1;
            const Single right = 2;

            try
            {
                Assert.AreEqual(left, right, "{0} and {1} singles are not equal", left, right);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<1>. Actual:<2>. 1 and 2 singles are not equal", e.Message);
            }

        }

        [TestMethod]
        public void TestMethodAreEqualDouble()
        {
            const Double left = 1;
            const Double right = 2;

            try
            {
                Assert.AreEqual(left, right);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<1>. Actual:<2>. ", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodAreEqualDoubleMessage()
        {
            const Double left = 1;
            const Double right = 2;

            try
            {
                Assert.AreEqual(left, right, "Doubles are not equal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<1>. Actual:<2>. Doubles are not equal", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodAreEqualDoubleMessageFormat()
        {
            const Double left = 1;
            const Double right = 2;

            try
            {
                Assert.AreEqual(left, right, "{0} and {1} doubles are not equal", left, right);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<1>. Actual:<2>. 1 and 2 doubles are not equal", e.Message);
            }

        }

        [TestMethod]
        public void TestMethodAreEqualString()
        {
            try
            {
                Assert.AreEqual("Hello", "hello", false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<Hello>. Case is different for actual value:<hello>. ", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodAreEqualStringMessage()
        {
            try
            {
                Assert.AreEqual("Hello", "hello", false, "Strings are not equal");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<Hello>. Case is different for actual value:<hello>. Strings are not equal", e.Message);
            }
        }

        [TestMethod]
        public void TestMethodAreEqualStringMessageFormat()
        {
            try
            {
                Assert.AreEqual("Hello", "hello", false, "{0} and {1} strings are not equal", "Hello", "World");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Assert.AreEqual("Assert.AreEqual failed. Expected:<Hello>. Case is different for actual value:<hello>. Hello and World strings are not equal", e.Message);
            }

        }

    }
}
