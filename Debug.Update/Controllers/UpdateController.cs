using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Debug.Update.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdateController : ControllerBase
    {
        HttpClient client = new HttpClient();

        public UpdateController()
        {

        }

        [HttpPut]
        public async Task<IActionResult> GetAll()
        {
            Guid testId = new Guid("d2c2c7ef-dafe-40ce-9fc7-83eac8793dcd");
            var testText = "updaterad text";
            var rClient = new RestClient("http://debug.database/database/db");
            var request1 = new RestRequest("/update", Method.PUT);
            request1.RequestFormat = DataFormat.Json;
            request1.AddQueryParameter("id", testId.ToString());
            request1.AddQueryParameter("updatedText", testText);
            var response1 = rClient.Execute(request1);

            return Ok();
        }
    }
}
