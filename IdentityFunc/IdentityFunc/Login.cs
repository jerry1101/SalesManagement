using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace IdentityFunc
{
    public static class Login
    {
        [FunctionName("LoginValidation")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var validator = new LoginValidation();
            var authentication= new Authentication();

            string name = req.Query["name"];
            string password = req.Query["password"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);

            name = name ?? data?.name;
            password = password ?? data?.password;

            if (name is null || password is null)
            {
                return new BadRequestObjectResult("Please pass a non-null name/password");
            }
            else
            {
                
                return validator.IsValidLogin(name, password)
                    ? (ActionResult) new OkObjectResult(authentication.GetSecurityProfile(name))
                    : new BadRequestObjectResult("No permission to access the system");

            }

            
        }
    }
}
