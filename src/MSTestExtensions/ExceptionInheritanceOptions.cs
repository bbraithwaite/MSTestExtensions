namespace MSTestExtensions
{
    /// <summary>
    /// Options for asserting the expected type of an exception.
    /// </summary>
    public enum ExceptionInheritanceOptions
    {
        /// <summary>
        ///  Not Set.
        /// </summary>
        None,

        /// <summary>
        /// The exception type must be the exact type i.e. not a subtype.
        /// </summary>
        Exact,

        /// <summary>
        /// The exception type can still match if its inherited type matches the assertion.
        /// </summary>
        Inherits
    }
}
