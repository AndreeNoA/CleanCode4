using Debug.Update.Models;
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
        public async Task<IActionResult> GetAll([FromBody]Message message)
        {
            var rClient = new RestClient("http://debug.database/database/db");
            var request1 = new RestRequest("/update", Method.PUT);
            request1.RequestFormat = DataFormat.Json;
            request1.AddJsonBody(message);
            var response1 = rClient.Execute(request1);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteById([FromBody]Guid id)
        {
            var rClient = new RestClient("http://debug.database/database/db");
            var request1 = new RestRequest("/delete", Method.DELETE);
            request1.RequestFormat = DataFormat.Json;
            request1.AddQueryParameter("id", id.ToString());
            var response1 = rClient.Execute(request1);
            return Ok();
        }
    }
}
