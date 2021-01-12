using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestSharp;

namespace FrontEnd.Pages
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Message Message { get; set; }
        [BindProperty]
        public Guid PickedId { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var message = new Message()
            {
                Id = PickedId,
                Text = Message.Text
            };
            var rClient = new RestClient("http://debug.update/update");
            var request1 = new RestRequest(Method.PUT);
            request1.RequestFormat = DataFormat.Json;
            request1.AddJsonBody(message);
            var response1 = rClient.Execute(request1);
            return RedirectToPage("Index");
        }
        public void OnGet(Guid id)
        {
            var x = id;
            this.PickedId = id;
        }
    }
}
