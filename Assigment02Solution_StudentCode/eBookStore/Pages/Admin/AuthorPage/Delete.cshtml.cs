using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using eBookStore.UrlAPI;
using Newtonsoft.Json;

namespace eBookStore.Pages.Admin.AuthorPage
{
    public class DeleteModel : PageModel
    {
        public DeleteModel()
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.DeleteAsync(PathAPI.AUTHOR + "/" + id);
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToPage("./Index");
                }
                else
                {
                    return BadRequest();
                }
            }

            
        }
    }
}
