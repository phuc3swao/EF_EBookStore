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
using static System.Reflection.Metadata.BlobBuilder;

namespace eBookStore.Pages.Member.BookPage
{
    public class DetailsModel : PageModel
    {
        public DetailsModel()
        {

        }

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
            }
            return Page();
        }
    }
}
