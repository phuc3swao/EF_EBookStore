using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BusinessObject.Models;
using eBookStore.UrlAPI;
using Newtonsoft.Json;
using System.Text;

namespace eBookStore.Pages.Admin.PulisherPage
{
    public class CreateModel : PageModel
    {
        public CreateModel()
        {
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || Publisher == null)
            {
                return Page();
            }

            using (var httpClient = new HttpClient())
            {
                var jsonContent = JsonConvert.SerializeObject(Publisher);
                var stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync(PathAPI.CREATEPULISHER, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                    // Xử lý khi thành công
                }
                else
                {

                }
            }

            return RedirectToPage("./Index");
        }
    }
}
