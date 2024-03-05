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

namespace eBookStore.Pages.Member.AuthorPage
{
    public class DetailsModel : PageModel
    {
        public DetailsModel()
        {
        }

      public Author Author { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using(HttpClient httpClient = new HttpClient())
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
    }
}
