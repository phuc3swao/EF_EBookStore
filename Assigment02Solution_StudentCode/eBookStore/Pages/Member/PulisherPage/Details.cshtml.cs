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

namespace eBookStore.Pages.Member.PulisherPage
{
    public class DetailsModel : PageModel
    {
        public DetailsModel()
        {
        }

        public Publisher Publisher { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync((PathAPI.GETPULISHERBYID + "/" + id).ToString());
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    Publisher = JsonConvert.DeserializeObject<Publisher>(jsonString);
                    if (Publisher == null)
                    {
                        return NotFound();
                    }
                }
            }
            return Page();
        }
    }
}
