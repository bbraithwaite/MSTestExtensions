using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MSTestExtensions
{
    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    public static class ThrowsAsyncAssert
    {
        /// <summary>
        /// This checks if an async method throws an exception as InnerException (chained exception are ignored)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="task"></param>
        /// <param name="expectedMessage"></param>
        /// <param name="messageOptions"></param>
        /// <param name="inheritOptions"></param>
        /// <returns></returns>
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
