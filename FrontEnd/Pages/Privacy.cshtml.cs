using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            ViewData["Message"] = "Hello from webfrontend";

            //using (var client = new System.Net.Http.HttpClient())
            //{
            //    // Call *mywebapi*, and display its response in the page
            //    var request = new System.Net.Http.HttpRequestMessage();
            //    request.RequestUri = new Uri("http://localhost/Notes"); // ASP.NET 3 (VS 2019 only)
            //    //request.RequestUri = new Uri("http://mywebapi/api/values/1"); // ASP.NET 2.x
            //    var response = await client.SendAsync(request);
            //    ViewData["Message"] += " and " + await response.Content.ReadAsStringAsync();
            //}
        }

    }
}
