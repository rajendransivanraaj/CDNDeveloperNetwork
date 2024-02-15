// User.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CDNDeveloperNetwork.Models;

namespace CDNDeveloperNetwork.Pages
{
    public class UserModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;

        public UserModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IActionResult> OnPostAsync(User user)
        {
            var client = _clientFactory.CreateClient();
            var content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/api/user", content);

            if (response.IsSuccessStatusCode)
                return RedirectToPage();
            else
                return Page();
        }
    }
}