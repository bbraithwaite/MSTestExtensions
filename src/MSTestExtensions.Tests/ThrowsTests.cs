using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MSTestExtensions.Tests
{
    [TestClass]
    public class ThrowsTests : BaseTest
    {
        [TestMethod]
        public void MethodThrowsException()
        {
            var ex = new Exception();
            var result = Assert.Throws(() => { throw ex; });
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodWithParametersThrowsException()
        {
            // Arrange
            var ex = new Exception();
            Action<string> method = (x) => { throw ex; };

            // Act & Assert
            var result = Assert.Throws(() => method("some param"));
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodThrowsSpecifiedException()
        {
            var ex = new ArgumentNullException();

            var result = Assert.Throws<ArgumentNullException>(() => { throw ex; });
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void FunctionThrowsException()
        {
            // Arrange
            var ex = new Exception();
            Func<object> function = () => { throw ex; };

            // Act & Assert
            var result = Assert.Throws(() => function());

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void FunctionWithParameterThrowsException()
        {
            var ex = new Exception();
            // Arrange
            Func<object, string> function = (x) => { throw ex; };

            // Act & Assert
            var result = Assert.Throws(() => function("some value"));
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void FunctionThrowsSpecifiedException()
        {
            var ex = new ArgumentNullException();
            // Arrange
            Func<object> function = () => { throw ex; };

            // Act & Assert
            var result = Assert.Throws<ArgumentNullException>(() => function());
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodThrowsExceptionWithExpectedExceptionMessage()
        {
            // Arrange
            const string expectedMessage = "something has gone wrong.";

            var ex = new Exception(expectedMessage);

            // Act & Assert
            var result = Assert.Throws(() => { throw ex; }, expectedMessage);
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodThrowsSpecificExceptionWithExpectedExceptionMessage()
        {
            // Arrange
            string expectedMessage = "Value cannot be null." + Environment.NewLine + "Parameter name: username";

            var ex = new ArgumentNullException("username");

            // Act & Assert
            var result = Assert.Throws<ArgumentNullException>(() => { throw ex; }, expectedMessage);

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodThrowsSpecificExceptionWithExpectedExceptionMessageIgnoringCase()
        {
            // Arrange
            string expectedMessage = "Value Cannot be null." + Environment.NewLine + "Parameter name: username";

            var ex = new ArgumentNullException("username");

            // Act & Assert
            var result = Assert.Throws<ArgumentNullException>(() => { throw ex; }, expectedMessage, ExceptionMessageCompareOptions.IgnoreCase);

            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodThrowsExceptionWithPartiallyMatchingExceptionMessage()
        {
            // Arrange
            const string expectedMessage = "Parameter name: username";
            var ex = new ArgumentNullException("username");

            // Act & Assert
            var result = Assert.Throws(() => { throw ex; }, expectedMessage, ExceptionMessageCompareOptions.Contains);
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void FunctionThrowsInheritedException()
        {
            // Arrange
            var ex = new ArgumentNullException();
            Action<string> method = (x) => { throw ex; };

            // Act & Assert
            var result = Assert.Throws<ArgumentException>(() => method("some param"));
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void MethodThrowsInheritedException()
        {
            // Arrange
            var ex = new ArgumentNullException();
            Action<string> method = (x) => { throw ex; };

            // Act & Assert
            var result = Assert.Throws<ArgumentException>(() => method("some param"));
            Assert.AreEqual(ex, result);
        }

        [TestMethod]
        public void FunctionThrowsNonInheritedException()
        {
            // Arrange
            Action<string> method = (x) => { throw new ArgumentNullException(); };
            Action invalidAssert = () => Assert.Throws<ArgumentException>(() => method("some param"), ExceptionInheritanceOptions.Exact);

            // Act & Assert
            Assert.Throws<AssertFailedException>(invalidAssert);
        }

        [TestMethod]
        public void MethodThrowsNonInheritedException()
        {
            // Arrange
            Action<string> method = (x) => { throw new ArgumentNullException(); };
            Action invalidAssert = () => Assert.Throws<ArgumentException>(() => method("some param"), ExceptionInheritanceOptions.Exact);

            // Act & Assert
            Assert.Throws<AssertFailedException>(invalidAssert);
        }
    }
}