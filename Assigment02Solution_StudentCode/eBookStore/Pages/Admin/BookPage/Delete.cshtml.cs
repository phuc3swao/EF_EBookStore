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

namespace eBookStore.Pages.Admin.BookPage
{
    public class DeleteModel : PageModel
    {

        public DeleteModel()
        {
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync((PathAPI.GETBOOKBYID + "/" + id).ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Book = JsonConvert.DeserializeObject<Book>(jsonString);
                    if (Book == null)
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return BadRequest();
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
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.DeleteAsync((PathAPI.DELETEBOOK + "/" + id).ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var resutl = JsonConvert.DeserializeObject<Book>(jsonString);
                    if (false)
                    {
                        //process with result 
                    }
                }
                else
                {
                    return BadRequest();
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
