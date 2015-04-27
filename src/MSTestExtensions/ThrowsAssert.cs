using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MSTestExtensions
{
    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    public static class ThrowsAssert
    {
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
