using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MSTestExtensions
{
    internal static class ExceptionAssert
    {
        public static void OnNoExceptionThrown<T>() where T : Exception
        {
            if (typeof(T).Equals(new Exception().GetType()))
            {
                Assert.Fail("Expected exception but no exception was thrown.");
            }
            else
            {
                Assert.Fail(string.Format("Expected exception of type {0} but no exception was thrown.", typeof(T)));
            }
        }

        public static T CheckException<T>(string expectedMessage, ExceptionMessageCompareOptions messageOptions, ExceptionInheritanceOptions inheritOptions, Exception ex) where T : Exception
        {
            AssertExceptionType<T>(ex, inheritOptions);
            AssertExceptionMessage(ex, expectedMessage, messageOptions);
            return (T)ex;
        }

        private static void AssertExceptionNotInherited<T>(Exception ex)
        {
            Assert.IsFalse(ex.GetType().IsSubclassOf(typeof(T)));
        }

        private static void AssertExceptionType<T>(Exception ex, ExceptionInheritanceOptions options)
        {
            Assert.IsInstanceOfType(ex, typeof(T), "Expected exception type failed.");
            switch (options)
            {
                case ExceptionInheritanceOptions.Exact:
                    AssertExceptionNotInherited<T>(ex);
                    break;
                case ExceptionInheritanceOptions.Inherits:
                    break;
                default:
                    throw new ArgumentOutOfRangeException("options");

            }
        }

        private static void AssertExceptionMessage(Exception ex, string expectedMessage, ExceptionMessageCompareOptions options)
        {
            if (!string.IsNullOrEmpty(expectedMessage))
            {
                switch (options)
                {
                    case ExceptionMessageCompareOptions.Exact:
                        Assert.AreEqual(expectedMessage, ex.Message, "Expected exception message failed.");
                        break;
                    case ExceptionMessageCompareOptions.IgnoreCase:
                        Assert.AreEqual(expectedMessage, ex.Message, true, "Expected exception message failed.");
                        break;
                    case ExceptionMessageCompareOptions.Contains:
                        Assert.IsTrue(ex.Message.Contains(expectedMessage), string.Format("Expected exception message does not contain <{0}>.", expectedMessage));
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("options");
                }

            }
        }
    }
}
