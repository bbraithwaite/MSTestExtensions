using System;
using System.Diagnostics;

namespace MSTestExtensions
{
    /// <summary>
    /// Assertion methods for checking exceptions.
    /// </summary>
    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    public static class ThrowsAssert
    {
        /// <summary>
        /// Assertion method to verify that an exception is thrown.
        /// </summary>
        /// <param name="task">The function or method under test.</param>
        /// <param name="expectedMessage">The expected message.</param>
        /// <param name="messageOptions">The message options for specifying assertion rules for the exception message.</param>
        /// <param name="inheritOptions">The inherit options for specifying assertion rules for the exception type.</param>
        /// <typeparam name="T">The type of the expected exception.</typeparam>
        /// <returns>The <see cref="T"/>. Returns the exception instance.</returns>
        public static T Throws<T>(Action task, string expectedMessage, ExceptionMessageCompareOptions messageOptions, ExceptionInheritanceOptions inheritOptions) where T : Exception
        {
            try
            {
                task();
            }
            catch (Exception ex)
            {
                return ExceptionAssert.CheckException<T>(expectedMessage, messageOptions, inheritOptions, ex);
            }

            ExceptionAssert.OnNoExceptionThrown<T>();

            return default(T);
        }

        #region Overloaded methods

        public static T Throws<T>(this IAssertion assertion, Action task, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return Throws<T>(task, null, ExceptionMessageCompareOptions.None, inheritOptions);
        }

        public static T Throws<T>(Action task, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return Throws<T>(task, null, ExceptionMessageCompareOptions.None, inheritOptions);
        }

        public static T Throws<T>(this IAssertion assertion, Action task, string expectedMessage, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return Throws<T>(task, expectedMessage, ExceptionMessageCompareOptions.Exact, inheritOptions);
        }

        public static T Throws<T>(Action task, string expectedMessage, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return Throws<T>(task, expectedMessage, ExceptionMessageCompareOptions.Exact, inheritOptions);
        }

        public static T Throws<T>(this IAssertion assertion, Action task, string expectedMessage, ExceptionMessageCompareOptions options, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return Throws<T>(task, expectedMessage, options, inheritOptions);
        }

        public static Exception Throws(this IAssertion assertion, Action task, string expectedMessage, ExceptionMessageCompareOptions options, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return Throws<Exception>(task, expectedMessage, options, inheritOptions);
        }

        public static Exception Throws(Action task, string expectedMessage, ExceptionMessageCompareOptions options, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return Throws<Exception>(task, expectedMessage, options, inheritOptions);
        }

        public static Exception Throws(this IAssertion assertion, Action task, string expectedMessage, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return Throws<Exception>(task, expectedMessage, ExceptionMessageCompareOptions.Exact, inheritOptions);
        }

        public static Exception Throws(Action task, string expectedMessage, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return Throws<Exception>(task, expectedMessage, ExceptionMessageCompareOptions.Exact, inheritOptions);
        }

        public static Exception Throws(this IAssertion assertion, Action task, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return Throws<Exception>(task, null, ExceptionMessageCompareOptions.None, inheritOptions);
        }

        public static Exception Throws(Action task, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return Throws<Exception>(task, null, ExceptionMessageCompareOptions.None, inheritOptions);
        }

        #endregion
    }
}
