using System;


namespace ImageProcessor.Operations
{
    /// <summary>
    /// Interface class for all supported commands, ie. the 7 specified operations
    /// </summary>
    public interface IOperation
    {
        /// <summary>
        /// Function to be implemented by each command
        /// </summary>
        public void PerformOperation(byte[] source);
    }
}
