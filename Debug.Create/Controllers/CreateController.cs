using Debug.Create.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Debug.Create.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CreateController : ControllerBase
    {
        HttpClient client = new HttpClient();
        
        public CreateController()
        {
           
        }
    
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            var newMsg = new Message() { Author = "Andreé", Id = new Guid(), Text = "test" };
            var rClient = new RestClient("http://debug.database/database/db");
            var request1 = new RestRequest("/create", Method.POST);
            request1.RequestFormat = DataFormat.Json;
            request1.AddJsonBody(newMsg);
            var response1 = rClient.Execute(request1);

            return Ok();
        }
    
    }

}
