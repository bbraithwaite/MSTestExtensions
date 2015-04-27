namespace MSTestExtensions
{
    /// <summary>
    /// Options for asserting the message values of an exception with the expected message.
    /// </summary>
    public enum ExceptionMessageCompareOptions
    {
        /// <summary>
        ///  Not Set.
        /// </summary>
        None,

        /// <summary>
        /// The exception message must exactly match to expected value.
        /// </summary>
        Exact,

        /// <summary>
        /// The exception message can contain partially match the expected value (useful for verbose exception messages).
        /// </summary>
        Contains,

        /// <summary>
        /// The case of the actual exception message against the expected will be ignored.
        /// </summary>
        IgnoreCase
    }
}
