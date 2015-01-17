#Add Extension Methods to Assert in MSTest

An extendible implementation of the Assert class in MSTest. Allows for extending the Assert methods whilst retaining the default Assert. methods. Also includes a Throws() method for asserting exceptions.

##What Problem Does it Solve?

I wanted to be able to add my own extension methods to *Assert* e.g. **Assert.Throws()** but keeping the existing default MSTest methods. 

e.g.

```csharp
[TestMethod]
public void AddWithNegativeNumberThrowsExceptionExpectedMessage()
{
    // Arrange
    StringCalculator sc = new StringCalculator();
  
    // Act => Assert
    Assert.Throws(() => sc.Add("-1"), "you cannot supply negative numbers.");
}
```

To accommodate such syntax I had to write this wrapper.

##Get Started

1. Add the MsTestExtensions.dll lib to your project (I'm assuming you may have downloaded the package from Nuget to do this: package name = MsTestExtensions).

2. Add a using/import MsTestExtensions entry within your class.

3. Inherit from BaseTest with the Test Class you are using and you should see Assert.Throws(...) in intellisense.
  * If you would rather not inherit from BaseTest you can use the syntax: ExceptionAssert.Throws(...)
  * Lastly if the above options do not suite, you can add the following within your test class: public static readonly IAssertion Assert = new Assertion();


NB IAssertion is the interface to use for adding your own custom extensions.

For more details see the accompanying [blog post] (http://bradoncode.com/2012/02/extending-assert-in-mstest.html).

##License

MIT license - http://www.opensource.org/licenses/mit-license.php
