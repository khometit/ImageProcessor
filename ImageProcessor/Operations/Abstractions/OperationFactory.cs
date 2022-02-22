using System;
using System.Collections.Generic;

namespace ImageProcessor.Operations
{
    /// <summary>
    /// Factory meant to hold the list of supported operations
    ///
    /// Return the appropriate instance of the requested operation
    /// </summary>
    public class OperationFactory
    {
        public readonly Dictionary<string, IOperation> supportedActions;
        /// <summary>
        /// Singleton, only need 1 factory
        /// </summary>
        public OperationFactory()
        {
            supportedActions.Add("fliphorizontal", new FlipHorizontal());
            supportedActions.Add("flipVertical", new FlipVertical());
            supportedActions.Add("resize", new Resize());
        }

        public IOperation CreateOperation(string action)
        {
            //return appropriate instance per request
            if (supportedActions.ContainsKey(action))
            {
                return supportedActions[action];
            }

            //Return null if the specified action is not supported
            return null;
        }
    }
}
