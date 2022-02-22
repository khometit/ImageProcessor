using System;
using System.Collections.Generic;

namespace ImageProcessor.Operations
{
    public static class RequestProcessor
    {
        static OperationFactory factory = new OperationFactory();

        public static byte[] ProcessRequest(byte[] data, string requestedActions)
        {
            //Get the requested operation list
            List<IOperation> operationList = CreateOperationList(requestedActions);

            //Execute the actions
            foreach(var operation in operationList)
            {
                operation.PerformOperation(data);
            }

            //data passed by reference?
            return data;
        }

        private static List<IOperation> CreateOperationList(string requestedActions)
        {
            List<IOperation> toReturn = new List<IOperation>();
            string[] actions = requestedActions.Split(";");

            foreach (var action in actions)
            {
                toReturn.Add(factory.CreateOperation(action));

                //todo: add check for null before adding to return list
            }

            return toReturn;
        }
    }
}
