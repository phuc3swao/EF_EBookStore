using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using eBookStore.UrlAPI;
using Newtonsoft.Json;
using System.Text;

namespace eBookStore.Pages.Admin.AuthorPage
{
    public class EditModel : PageModel
    {
        public EditModel()
        {
        }

        [BindProperty]
        public Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(PathAPI.AUTHOR + "/" + id);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    Author = JsonConvert.DeserializeObject<Author>(jsonString);
                }
                else
                {
                    return NotFound();
                }
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            using (var httpClient = new HttpClient())
            {
                var jsonContent = JsonConvert.SerializeObject(Author);
                var stringContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await httpClient.PutAsync((PathAPI.AUTHOR + "/" + Author.Author_Id).ToString(), stringContent);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                }
            }

            return RedirectToPage("./Index");
        }

    }
}
