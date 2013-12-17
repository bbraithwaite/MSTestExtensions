using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExtensions.Tests
{
    [TestClass]
    public class ThrowsTests : BaseTest
    {
        [TestMethod]
        public void MethodThrowsException()
        {
            Assert.Throws(() => { throw new Exception(); });
        }

        [TestMethod]
        public void MethodWithParametersThrowsException()
        {
            // Arrange
            Action<string> method = (x) => { throw new Exception(); };
            
            // Act & Assert
            Assert.Throws(() => method("some param"));
        }

        [TestMethod]
        public void MethodThrowsSpecifiedException()
        {
            Assert.Throws<ArgumentNullException>(() => { throw new ArgumentNullException(); });
        }

        [TestMethod]
        public void FunctionThrowsException()
        {
            // Arrange
            Func<object> function = () => { throw new Exception(); };
            
            // Act & Assert
            Assert.Throws(() => function());
        }

        [TestMethod]
        public void FunctionWithParameterThrowsException()
        {
            // Arrange
            Func<object, string> function = (x) => { throw new Exception(); };
            
            // Act & Assert
            Assert.Throws(() => function("some value"));
        }

        [TestMethod]
        public void FunctionThrowsSpecifiedException()
        {
            // Arrange
            Func<object> function = () => { throw new ArgumentNullException(); };

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => function());
        }

        [TestMethod]
        public void MethodThrowsExceptionWithExpectedExceptionMessage()
        {
            // Arrange
            const string expectedMessage = "something has gone wrong.";

            // Act & Assert
            Assert.Throws(() => { throw new Exception(expectedMessage); }, expectedMessage);
        }

        [TestMethod]
        public void MethodThrowsSpecificExceptionWithExpectedExceptionMessage()
        {
            // Arrange
            string expectedMessage = "Value cannot be null." + Environment.NewLine + "Parameter name: username";

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => { throw new ArgumentNullException("username"); }, expectedMessage);
        }

        [TestMethod]
        public void MethodThrowsExceptionWithPartiallyMatchingExceptionMessage()
        {
            // Arrange
            const string expectedMessage = "Parameter name: username";

            // Act & Assert
            Assert.Throws(() => { throw new ArgumentNullException("username"); }, expectedMessage, ExceptionMessageCompareOptions.Contains);
        }

        [TestMethod]
        public void FunctionThrowsInheritedException()
        {
            // Arrange
            Action<string> method = (x) => { throw new ArgumentNullException(); };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => method("some param"));
        }

        [TestMethod]
        public void MethodThrowsInheritedException()
        {
            // Arrange
            Action<string> method = (x) => { throw new ArgumentNullException(); };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => method("some param"));
        }

        [TestMethod]
        public void FunctionThrowsNonInheritedException()
        {
            // Arrange
            Action<string> method = (x) => { throw new ArgumentNullException(); };
            Action invalidAssert = () => { Assert.Throws<ArgumentException>(() => method("some param"), ExceptionInheritanceOptions.Exact); };

            // Act & Assert
            Assert.Throws<AssertFailedException>(() => invalidAssert());
        }

        [TestMethod]
        public void MethodThrowsNonInheritedException()
        {
            // Arrange
            Action<string> method = (x) => { throw new ArgumentNullException(); };
            Action invalidAssert = () => { Assert.Throws<ArgumentException>(() => method("some param"), ExceptionInheritanceOptions.Exact); };

            // Act & Assert
            Assert.Throws<AssertFailedException>(() => invalidAssert());
        }
    }
}