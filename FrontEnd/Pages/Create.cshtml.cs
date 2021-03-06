using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestSharp;

namespace FrontEnd.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Message Message { get; set; }
        public RestClient RestClient = new RestClient("http://debug.create/create");

        public async Task<IActionResult> OnPostAsync()
        {

            var message = new Message()
            {
                Id = new Guid(),
                Text = Message.Text,
                Author = Message.Author
            };

            var restRequest = new RestRequest(Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddJsonBody(message);
            var executeResponse = RestClient.Execute(restRequest);
            if (executeResponse.IsSuccessful)
            {
                return RedirectToPage("Index");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
