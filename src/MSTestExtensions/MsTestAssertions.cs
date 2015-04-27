using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestExtensions
{
    /* This code is auto-generated */
    [DebuggerStepThrough]
    [DebuggerNonUserCode]
    public static class MsTestAssertions
    {
        public static void AreEqual<T>(this IAssertion assertion, T expected, T actual)
        {
            Assert.AreEqual(expected, actual);
        }
        public static void AreEqual(this IAssertion assertion, System.String expected, System.String actual, System.Boolean ignoreCase)
        {
            Assert.AreEqual(expected, actual, ignoreCase);
        }
        public static void AreEqual(this IAssertion assertion, System.Single expected, System.Single actual, System.Single delta)
        {
            Assert.AreEqual(expected, actual, delta);
        }
        public static void AreEqual(this IAssertion assertion, System.Double expected, System.Double actual, System.Double delta, System.String message, params System.Object[] parameters)
        {
            Assert.AreEqual(expected, actual, delta, message, parameters);
        }
        public static void AreEqual(this IAssertion assertion, System.Object expected, System.Object actual, System.String message, params System.Object[] parameters)
        {
            Assert.AreEqual(expected, actual, message, parameters);
        }
        public static void AreEqual(this IAssertion assertion, System.Single expected, System.Single actual, System.Single delta, System.String message, params System.Object[] parameters)
        {
            Assert.AreEqual(expected, actual, delta, message, parameters);
        }
        public static void AreEqual<T>(this IAssertion assertion, T expected, T actual, System.String message, params System.Object[] parameters)
        {
            Assert.AreEqual(expected, actual, message, parameters);
        }
        public static void AreEqual(this IAssertion assertion, System.Double expected, System.Double actual, System.Double delta)
        {
            Assert.AreEqual(expected, actual, delta);
        }
        public static void AreEqual(this IAssertion assertion, System.Object expected, System.Object actual)
        {
            Assert.AreEqual(expected, actual);
        }
        public static void AreEqual(this IAssertion assertion, System.String expected, System.String actual, System.Boolean ignoreCase, System.Globalization.CultureInfo culture)
        {
            Assert.AreEqual(expected, actual, ignoreCase, culture);
        }
        public static void AreEqual(this IAssertion assertion, System.String expected, System.String actual, System.Boolean ignoreCase, System.Globalization.CultureInfo culture, System.String message, params System.Object[] parameters)
        {
            Assert.AreEqual(expected, actual, ignoreCase, culture, message, parameters);
        }
        public static void AreEqual(this IAssertion assertion, System.String expected, System.String actual, System.Boolean ignoreCase, System.String message, params System.Object[] parameters)
        {
            Assert.AreEqual(expected, actual, ignoreCase, message, parameters);
        }
        public static void AreNotEqual(this IAssertion assertion, System.String notExpected, System.String actual, System.Boolean ignoreCase, System.Globalization.CultureInfo culture)
        {
            Assert.AreNotEqual(notExpected, actual, ignoreCase, culture);
        }
        public static void AreNotEqual(this IAssertion assertion, System.String notExpected, System.String actual, System.Boolean ignoreCase, System.Globalization.CultureInfo culture, System.String message, params System.Object[] parameters)
        {
            Assert.AreNotEqual(notExpected, actual, ignoreCase, culture, message, parameters);
        }
        public static void AreNotEqual(this IAssertion assertion, System.Single notExpected, System.Single actual, System.Single delta)
        {
            Assert.AreNotEqual(notExpected, actual, delta);
        }
        public static void AreNotEqual(this IAssertion assertion, System.String notExpected, System.String actual, System.Boolean ignoreCase)
        {
            Assert.AreNotEqual(notExpected, actual, ignoreCase);
        }
        public static void AreNotEqual(this IAssertion assertion, System.Double notExpected, System.Double actual, System.Double delta)
        {
            Assert.AreNotEqual(notExpected, actual, delta);
        }
        public static void AreNotEqual(this IAssertion assertion, System.Double notExpected, System.Double actual, System.Double delta, System.String message, params System.Object[] parameters)
        {
            Assert.AreNotEqual(notExpected, actual, delta, message, parameters);
        }
        public static void AreNotEqual(this IAssertion assertion, System.Single notExpected, System.Single actual, System.Single delta, System.String message, params System.Object[] parameters)
        {
            Assert.AreNotEqual(notExpected, actual, delta, message, parameters);
        }
        public static void AreNotEqual(this IAssertion assertion, System.String notExpected, System.String actual, System.Boolean ignoreCase, System.String message, params System.Object[] parameters)
        {
            Assert.AreNotEqual(notExpected, actual, ignoreCase, message, parameters);
        }
        public static void AreNotEqual<T>(this IAssertion assertion, T notExpected, T actual)
        {
            Assert.AreNotEqual(notExpected, actual);
        }
        public static void AreNotEqual<T>(this IAssertion assertion, T notExpected, T actual, System.String message, params System.Object[] parameters)
        {
            Assert.AreNotEqual(notExpected, actual, message, parameters);
        }
        public static void AreNotEqual(this IAssertion assertion, System.Object notExpected, System.Object actual, System.String message, params System.Object[] parameters)
        {
            Assert.AreNotEqual(notExpected, actual, message, parameters);
        }
        public static void AreNotEqual(this IAssertion assertion, System.Object notExpected, System.Object actual)
        {
            Assert.AreNotEqual(notExpected, actual);
        }
        public static void AreNotSame(this IAssertion assertion, System.Object notExpected, System.Object actual)
        {
            Assert.AreNotSame(notExpected, actual);
        }
        public static void AreNotSame(this IAssertion assertion, System.Object notExpected, System.Object actual, System.String message, params System.Object[] parameters)
        {
            Assert.AreNotSame(notExpected, actual, message, parameters);
        }
        public static void AreSame(this IAssertion assertion, System.Object expected, System.Object actual)
        {
            Assert.AreSame(expected, actual);
        }
        public static void AreSame(this IAssertion assertion, System.Object expected, System.Object actual, System.String message, params System.Object[] parameters)
        {
            Assert.AreSame(expected, actual, message, parameters);
        }
        public static void Equals(this IAssertion assertion, System.Object objA, System.Object objB)
        {
            Assert.Equals(objA, objB);
        }
        public static void Fail(this IAssertion assertion)
        {
            Assert.Fail();
        }
        public static void Fail(this IAssertion assertion, System.String message, params System.Object[] parameters)
        {
            Assert.Fail(message, parameters);
        }
        public static void Inconclusive(this IAssertion assertion, System.String message, params System.Object[] parameters)
        {
            Assert.Inconclusive(message, parameters);
        }
        public static void Inconclusive(this IAssertion assertion)
        {
            Assert.Inconclusive();
        }
        public static void IsFalse(this IAssertion assertion, System.Boolean condition)
        {
            Assert.IsFalse(condition);
        }
        public static void IsFalse(this IAssertion assertion, System.Boolean condition, System.String message, params System.Object[] parameters)
        {
            Assert.IsFalse(condition, message, parameters);
        }
        public static void IsInstanceOfType(this IAssertion assertion, System.Object value, System.Type expectedType)
        {
            Assert.IsInstanceOfType(value, expectedType);
        }
        public static void IsInstanceOfType(this IAssertion assertion, System.Object value, System.Type expectedType, System.String message, params System.Object[] parameters)
        {
            Assert.IsInstanceOfType(value, expectedType, message, parameters);
        }
        public static void IsNotInstanceOfType(this IAssertion assertion, System.Object value, System.Type wrongType, System.String message, params System.Object[] parameters)
        {
            Assert.IsNotInstanceOfType(value, wrongType, message, parameters);
        }
        public static void IsNotInstanceOfType(this IAssertion assertion, System.Object value, System.Type wrongType)
        {
            Assert.IsNotInstanceOfType(value, wrongType);
        }
        public static void IsNotNull(this IAssertion assertion, System.Object value, System.String message, params System.Object[] parameters)
        {
            Assert.IsNotNull(value, message, parameters);
        }
        public static void IsNotNull(this IAssertion assertion, System.Object value)
        {
            Assert.IsNotNull(value);
        }
        public static void IsNull(this IAssertion assertion, System.Object value, System.String message, params System.Object[] parameters)
        {
            Assert.IsNull(value, message, parameters);
        }
        public static void IsNull(this IAssertion assertion, System.Object value)
        {
            Assert.IsNull(value);
        }
        public static void IsTrue(this IAssertion assertion, System.Boolean condition, System.String message, params System.Object[] parameters)
        {
            Assert.IsTrue(condition, message, parameters);
        }
        public static void IsTrue(this IAssertion assertion, System.Boolean condition)
        {
            Assert.IsTrue(condition);
        }
        public static void ReplaceNullChars(this IAssertion assertion, System.String input)
        {
            Assert.ReplaceNullChars(input);
        }
    }
}
