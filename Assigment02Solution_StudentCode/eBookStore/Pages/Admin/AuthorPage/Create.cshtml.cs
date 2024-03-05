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

namespace eBookStore.Pages.Admin.AuthorPage
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
        public Author Author { get; set; } = default!;


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || Author == null)
            {
                return Page();
            }
            using (var httpClient = new HttpClient())
            {
                var jsonContent = JsonConvert.SerializeObject(Author);
                var stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(PathAPI.AUTHOR, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                }
            }


            return RedirectToPage("./Index");
        }
    }
}
