using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Message> messages { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            using (var client = new HttpClient())
            {
                var request1 = new HttpRequestMessage();
                request1.RequestUri = new Uri("http://debug.create/Create");
                var response1 = await client.SendAsync(request1);

                var request = new HttpRequestMessage();
                request.RequestUri = new Uri("http://debug.read/Read");
                var response = await client.SendAsync(request);
                var responseAsString = await response.Content.ReadAsStringAsync();
                messages = JsonConvert.DeserializeObject<List<Message>>(responseAsString);
            }
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            var rClient = new RestClient("http://debug.update/update");
            var request = new RestRequest(Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(id);
            var x = rClient.Execute(request);
            return RedirectToPage("Index");   
        }
    }
}
