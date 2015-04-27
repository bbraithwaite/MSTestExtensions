using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MSTestExtensions
{
    /// <summary>
    /// Assertion methods for checking exceptions with async methods.
    /// </summary>
    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    public static class ThrowsAsyncAssert
    {
        /// <summary>
        /// This checks if an async method throws an exception as InnerException (chained exception are ignored)
        /// </summary>
        /// <param name="task">The async task under test.</param>
        /// <param name="expectedMessage">The expected message.</param>
        /// <param name="messageOptions">The message options for specifying assertion rules for the exception message.</param>
        /// <param name="inheritOptions">The inherit options for specifying assertion rules for the exception type.</param>
        /// <typeparam name="T">The type of the expected exception.</typeparam>
        /// <returns>The <see cref="T"/>. Returns the exception instance.</returns>
        public static T ThrowsAsync<T>(Task task, string expectedMessage, ExceptionMessageCompareOptions messageOptions, ExceptionInheritanceOptions inheritOptions) where T : Exception
        {
            try
            {
                task.Wait();
            }
            catch (AggregateException aggregateEx)
            {
                return ExceptionAssert.CheckException<T>(expectedMessage, messageOptions, inheritOptions, aggregateEx.InnerException);
            }

            ExceptionAssert.OnNoExceptionThrown<T>();

            return default(T);
        }

        #region Overloaded methods

        public static T ThrowsAsync<T>(this IAssertion assertion, Task task, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return ThrowsAsync<T>(task, null, ExceptionMessageCompareOptions.None, inheritOptions);
        }

        public static T ThrowsAsync<T>(Task task, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return ThrowsAsync<T>(task, null, ExceptionMessageCompareOptions.None, inheritOptions);
        }

        public static T ThrowsAsync<T>(this IAssertion assertion, Task task, string expectedMessage, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return ThrowsAsync<T>(task, expectedMessage, ExceptionMessageCompareOptions.Exact, inheritOptions);
        }

        public static T ThrowsAsync<T>(Task task, string expectedMessage, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return ThrowsAsync<T>(task, expectedMessage, ExceptionMessageCompareOptions.Exact, inheritOptions);
        }

        public static T ThrowsAsync<T>(this IAssertion assertion, Task task, string expectedMessage, ExceptionMessageCompareOptions options, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits) where T : Exception
        {
            return ThrowsAsync<T>(task, expectedMessage, options, inheritOptions);
        }

        public static Exception ThrowsAsync(this IAssertion assertion, Task task, string expectedMessage, ExceptionMessageCompareOptions options, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return ThrowsAsync<Exception>(task, expectedMessage, options, inheritOptions);
        }

        public static Exception ThrowsAsync(Task task, string expectedMessage, ExceptionMessageCompareOptions options, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return ThrowsAsync<Exception>(task, expectedMessage, options, inheritOptions);
        }

        public static Exception ThrowsAsync(this IAssertion assertion, Task task, string expectedMessage, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return ThrowsAsync<Exception>(task, expectedMessage, ExceptionMessageCompareOptions.Exact, inheritOptions);
        }

        public static Exception ThrowsAsync(Task task, string expectedMessage, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return ThrowsAsync<Exception>(task, expectedMessage, ExceptionMessageCompareOptions.Exact, inheritOptions);
        }

        public static Exception ThrowsAsync(this IAssertion assertion, Task task, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return ThrowsAsync<Exception>(task, null, ExceptionMessageCompareOptions.None, inheritOptions);
        }

        public static Exception ThrowsAsync(Task task, ExceptionInheritanceOptions inheritOptions = ExceptionInheritanceOptions.Inherits)
        {
            return ThrowsAsync<Exception>(task, null, ExceptionMessageCompareOptions.None, inheritOptions);
        }

        #endregion
    }
}
