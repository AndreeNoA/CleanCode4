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

        public async Task<IActionResult> OnPostAsync()
        {

            var message = new Message()
            {
                Id = new Guid(),
                Text = Message.Text,
                Author = Message.Author
            };

            var rClient = new RestClient("http://debug.create/create");
            var request1 = new RestRequest(Method.POST);
            request1.RequestFormat = DataFormat.Json;
            request1.AddJsonBody(message);
            var response1 = rClient.Execute(request1);
            return RedirectToPage("Index");
        }

        public void OnGet()
        {
        }
    }
}
