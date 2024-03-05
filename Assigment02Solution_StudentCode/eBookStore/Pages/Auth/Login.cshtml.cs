using BusinessObject.Models;
using eBookStore.UrlAPI;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net;

namespace eBookStore.Pages.Auth
{
    public class LoginModel : PageModel
    {
        public async Task OnGet()
        {

        }
        [BindProperty]
        public User user { get; set; } = default!;
        public async Task<IActionResult> OnPostLoginAsync()
        {
            using (var httpClient = new HttpClient())
            {
                string PATH = PathAPI.LOGIN + "?email=" + user.EmailAddress + "&pass=" + user.Password;
                var response = await httpClient.GetAsync(PATH);
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    User User = JsonConvert.DeserializeObject<User>(jsonString);
                    if (User == null)
                    {
                        return Page();
                    }
                    
                    else
                    {
                        //set sestion
                        string userJson = JsonConvert.SerializeObject(User);
                        HttpContext.Session.SetString("CurrentUser", userJson);
                    }
                }else
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    ViewData["Error"] = "User not correct";
                    return Page();
                }
            }
            return RedirectToPage("/Index");
        }

        public async Task<IActionResult> OnPostLogoutAsync()
        {
            HttpContext.Session.Clear();
            return RedirectToPage("/Index");
        }
    }
}
