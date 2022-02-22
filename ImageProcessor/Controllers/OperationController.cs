using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImageProcessor.Operations;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ImageProcessor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationController : ControllerBase
    {
        public OperationController() { }

        [HttpPost]
        public void TransformImage([FromQuery (Name = "actions")] string requestedActions, [FromBody] byte[] data)
        {
            //Give the request to the request processor
            var processedImage = RequestProcessor.ProcessRequest(data, requestedActions);

            //Return the image if successfully carried out the operations
            Response.StatusCode = (int)System.Net.HttpStatusCode.OK;
            Response.Body.Write(processedImage);

            //Otherwise return an error code
            //todo: add null checks
        }
    }
}
