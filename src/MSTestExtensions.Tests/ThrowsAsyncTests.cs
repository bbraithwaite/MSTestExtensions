using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MSTestExtensions.Tests
{
    [TestClass]
    public class ThrowsAsyncTests : BaseTest
    {
        [TestMethod]
        public void MethodThrowsAsyncException()
        {
            var ex = new Exception();
            var result = Assert.ThrowsAsync(AsyncThrow(ex));
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodThrowsAsyncSpecifiedException()
        {
            var ex = new ArgumentNullException();

            var result = Assert.ThrowsAsync<ArgumentNullException>(AsyncThrow(ex));
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodThrowsAsyncExceptionWithExpectedExceptionMessage()
        {
            // Arrange
            const string expectedMessage = "something has gone wrong.";

            var ex = new Exception(expectedMessage);

            // Act & Assert
            var result = Assert.ThrowsAsync(AsyncThrow(ex), expectedMessage);
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodThrowsAsyncExceptionWithPartiallyMatchingExceptionMessage()
        {
            // Arrange
            const string expectedMessage = "Parameter name: username";
            var ex = new ArgumentNullException("username");

            // Act & Assert
            var result = Assert.ThrowsAsync(AsyncThrow(ex), expectedMessage, ExceptionMessageCompareOptions.Contains);
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void FunctionThrowsAsyncInheritedException()
        {
            // Arrange
            var ex = new ArgumentNullException();
            Action<string> method = (x) => { throw ex; };

            // Act & Assert
            var result = Assert.ThrowsAsync<ArgumentException>(AsyncThrow(ex));
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void FunctionThrowsAsyncNonInheritedException()
        {
            // Arrange
            var ex = new ArgumentNullException();

            Action invalidAssert = () => Assert.ThrowsAsync<ArgumentException>(AsyncThrow(ex), ExceptionInheritanceOptions.Exact);

            // Act & Assert
            Assert.Throws<AssertFailedException>(invalidAssert);
        }

        private static async Task AsyncThrow<E>(E exception) where E : Exception
        {
            throw exception;
        }
    }
}
